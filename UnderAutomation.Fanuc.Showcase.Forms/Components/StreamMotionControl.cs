using System.ComponentModel;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Motion;
using UnderAutomation.Fanuc.StreamMotion.Data;
using UnderAutomation.Robotics.Motion;

public partial class StreamMotionControl : UserControl, IUserControl
{
    // Limits used to plan the Cartesian demo. They are low on purpose: the joint limits of the robot
    // cannot be checked for Cartesian positions, so keep a margin.
    private static readonly CartesianLimits DemoCartesianLimits = new CartesianLimits(250, 500, 2500, 30, 90, 450);

    private readonly FanucRobot _robot;
    private readonly StatusView _statusView;

    public StreamMotionControl(FanucRobot robot)
    {
        InitializeComponent();
        _robot = robot;
        _statusView = new StatusView(robot);
        propertyGridStatus.SelectedObject = _statusView;
    }

    #region IUserControl

    public string Title => "Stream Motion (J519)";

    public bool FeatureEnabled => _robot.StreamMotion.Connected;

    public void PeriodicUpdate()
    {
        propertyGridStatus.Refresh();
        UpdateButtons();
    }

    public void OnOpen()
    {
        var sm = _robot.StreamMotion;
        sm.SessionStarted += OnSessionStarted;
        sm.SessionEnded += OnSessionEnded;
        sm.MotionCompleted += OnMotionCompleted;
        sm.Underrun += OnUnderrun;
        sm.ErrorOccurred += OnErrorOccurred;
        UpdateButtons();
    }

    public void OnClose()
    {
        var sm = _robot.StreamMotion;
        sm.SessionStarted -= OnSessionStarted;
        sm.SessionEnded -= OnSessionEnded;
        sm.MotionCompleted -= OnMotionCompleted;
        sm.Underrun -= OnUnderrun;
        sm.ErrorOccurred -= OnErrorOccurred;
    }

    #endregion

    #region Buttons

    private void btnStartMonitoring_Click(object sender, EventArgs e)
    {
        Run(() =>
        {
            // Reads the limits of the robot, starts the status output and measures the communication cycle
            _robot.StreamMotion.StartMonitoring();
            var sm = _robot.StreamMotion;
            Log($"Monitoring started. Protocol version {sm.ProtocolVersion}, communication cycle {sm.CycleTime * 1000:0.#} ms.");
            Log(sm.Limits != null ? "Joint limits read from the robot." : "The joint limits were not read (call ReadLimits before running the IBGN program).");
        });
    }

    private void btnStopMonitoring_Click(object sender, EventArgs e)
    {
        Run(() =>
        {
            _robot.StreamMotion.StopMonitoring();
            Log("Monitoring stopped.");
        });
    }

    private void btnJointDemo_Click(object sender, EventArgs e)
    {
        Run(() =>
        {
            var sm = _robot.StreamMotion;
            if (sm.JointLimits == null) throw new InvalidOperationException("The joint limits are not known. Start the monitoring before running the IBGN program.");

            // J1 goes to +amplitude, then -amplitude, then back to the start, with smooth corners (CNT100)
            double amplitude = (double)numJointAmplitude.Value;
            double speed = (double)numJointSpeed.Value;
            var start = sm.QueueEndJointPosition;
            var left = new JointsPosition(start.Values) { J1 = start.J1 + amplitude };
            var right = new JointsPosition(start.Values) { J1 = start.J1 - amplitude };

            var planner = new MotionPlanner(sm.JointLimits, null);
            var trajectory = planner.CreateJointPath(FanucMotion.ToJointValues(start))
                .MoveJoint(FanucMotion.ToJointValues(left), speed, FanucMotion.Cnt(100))
                .MoveJoint(FanucMotion.ToJointValues(right), speed, FanucMotion.Cnt(100))
                .MoveJoint(FanucMotion.ToJointValues(start), speed, FanucMotion.Fine())
                .Build();

            int id = sm.Enqueue(trajectory);
            Log($"Joint demo queued: motion {id}, {trajectory.Duration:0.00} s.{WaitingMessage()}");
        });
    }

    private void btnCartesianDemo_Click(object sender, EventArgs e)
    {
        Run(() =>
        {
            var sm = _robot.StreamMotion;

            // Horizontal circle that starts and ends at the current position
            double radius = (double)numCircleRadius.Value;
            double speed = (double)numCircleSpeed.Value;
            var start = sm.QueueEndCartesianPosition;
            var plane = new XYZWPRPosition(start.X - radius, start.Y, start.Z, 0, 0, 0);

            var planner = new MotionPlanner(sm.JointLimits, DemoCartesianLimits);
            var trajectory = planner.CreateCartesianPath(FanucMotion.ToCartesianPose(start))
                .AddCircle(FanucMotion.ToCartesianPose(plane), radius, speed, FanucMotion.Fine())
                .Build();

            int id = sm.Enqueue(trajectory);
            Log($"Cartesian demo queued: motion {id}, {trajectory.Duration:0.00} s.{WaitingMessage()}");
        });
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        Run(() => { _robot.StreamMotion.Pause(); Log("Paused."); });
    }

    private void btnResume_Click(object sender, EventArgs e)
    {
        Run(() => { _robot.StreamMotion.Resume(); Log("Resumed."); });
    }

    private void btnAbort_Click(object sender, EventArgs e)
    {
        Run(() => { _robot.StreamMotion.Abort(); Log("Abort requested: the robot stops on its path."); });
    }

    private async void btnFinish_Click(object sender, EventArgs e)
    {
        btnFinish.Enabled = false;
        try
        {
            // Waits for the end of the queued motions, then the TP program continues after IBGN end
            bool finished = await Task.Run(() => _robot.StreamMotion.Finish(30000));
            Log(finished ? "Session finished." : "The session did not finish.");
        }
        catch (Exception ex)
        {
            Log("Error: " + ex.Message);
        }
        finally
        {
            UpdateButtons();
        }
    }

    private void trackOverride_Scroll(object sender, EventArgs e)
    {
        lblOverride.Text = $"Override: {trackOverride.Value} %";
        Run(() => _robot.StreamMotion.Override = trackOverride.Value);
    }

    private void btnClearLog_Click(object sender, EventArgs e)
    {
        txtLog.Clear();
    }

    #endregion

    #region Events of the client (raised on a background thread)

    private void OnSessionStarted(object? sender, SessionEventArgs e) => Log($"Session {e.SessionIndex} started.");

    private void OnSessionEnded(object? sender, SessionEndedEventArgs e) => Log($"Session {e.SessionIndex} ended: {e.Reason}.");

    private void OnMotionCompleted(object? sender, MotionEventArgs e) => Log($"Motion {e.MotionId} completed.");

    private void OnUnderrun(object? sender, MotionEventArgs e) => Log("No more positions while the robot was moving: it was stopped smoothly.");

    private void OnErrorOccurred(object? sender, StreamMotionErrorEventArgs e) => Log("Error: " + e.Exception.Message);

    #endregion

    private string WaitingMessage()
    {
        var state = _robot.StreamMotion.State;
        return state == StreamMotionState.Ready || state == StreamMotionState.Streaming ? "" : " It starts when the robot program reaches IBGN start.";
    }

    private void UpdateButtons()
    {
        var sm = _robot.StreamMotion;
        var state = sm.State;
        bool monitoring = state != StreamMotionState.Disconnected && state != StreamMotionState.Connected;

        // The format (joint or Cartesian) of the first trajectory queued, or of the callback or tracking source,
        // is fixed until the queue is empty and no session, callback streaming or tracking is active anymore.
        bool hasActiveFormat = monitoring && sm.HasActiveFormat;
        PositionFormat activeFormat = sm.ActiveFormat;
        bool jointAllowed = !hasActiveFormat || activeFormat == PositionFormat.Joint;
        bool cartesianAllowed = !hasActiveFormat || activeFormat == PositionFormat.Cartesian;

        btnStartMonitoring.Enabled = state == StreamMotionState.Connected;
        btnStopMonitoring.Enabled = state == StreamMotionState.Monitoring || state == StreamMotionState.Ready;
        btnJointDemo.Enabled = monitoring && jointAllowed;
        btnCartesianDemo.Enabled = monitoring && cartesianAllowed;
        btnPause.Enabled = monitoring;
        btnResume.Enabled = monitoring;
        btnAbort.Enabled = monitoring;
        btnFinish.Enabled = state == StreamMotionState.Ready || state == StreamMotionState.Streaming;

        lblJointFormatNote.Visible = !jointAllowed;
        lblJointFormatNote.Text = "Disabled: the current session is in Cartesian format. Call Finish to end it, then this demo becomes available for the next session.";

        lblCartesianFormatNote.Visible = !cartesianAllowed;
        lblCartesianFormatNote.Text = "Disabled: the current session is in Joint format. Call Finish to end it, then this demo becomes available for the next session.";
    }

    private void Run(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            Log("Error: " + ex.Message);
        }
        UpdateButtons();
    }

    private void Log(string message)
    {
        string line = "[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] " + message + Environment.NewLine;
        if (IsDisposed) return;
        if (InvokeRequired)
        {
            try { BeginInvoke(new Action(() => txtLog.AppendText(line))); }
            catch (InvalidOperationException) { }
            return;
        }
        txtLog.AppendText(line);
    }

    /// <summary>
    /// Read-only view of the client shown in the property grid
    /// </summary>
    private class StatusView
    {
        private readonly FanucRobot _robot;

        public StatusView(FanucRobot robot)
        {
            _robot = robot;
        }

        private StreamMotionStatus? Status => _robot.StreamMotion.LastStatus;

        [Category("Client"), Description("Disconnected, Connected, Monitoring, Ready (IBGN start reached), Streaming or Finishing")]
        public StreamMotionState State => _robot.StreamMotion.State;

        [Category("Client"), DisplayName("Cycle time (ms)")]
        public double CycleTime => _robot.StreamMotion.CycleTime * 1000;

        [Category("Client"), DisplayName("Protocol version")]
        public int ProtocolVersion => _robot.StreamMotion.ProtocolVersion;

        [Category("Client"), DisplayName("Queued motions")]
        public int QueuedMotions => _robot.StreamMotion.QueuedMotionCount;

        [Category("Client"), DisplayName("Override (%)")]
        public double Override => _robot.StreamMotion.Override;

        [Category("Client"), DisplayName("Paused")]
        public bool Paused => _robot.StreamMotion.IsPaused;

        [Category("Client"), DisplayName("Sessions")]
        public int Sessions => _robot.StreamMotion.SessionCount;

        [Category("Robot status"), DisplayName("Waiting for positions")]
        public bool IsWaitingForCommand => Status?.IsWaitingForCommand ?? false;

        [Category("Robot status"), DisplayName("Moving")]
        public bool IsMoving => Status?.IsMoving ?? false;

        [Category("Robot status"), DisplayName("Joints (deg)")]
        public string Joints => Status?.JointPosition?.ToString() ?? "";

        [Category("Robot status"), DisplayName("Cartesian (mm, deg)")]
        public string Cartesian => Status?.CartesianPosition?.ToString() ?? "";

        [Category("Statistics"), DisplayName("Lost status")]
        public long LostStatus => _robot.StreamMotion.Statistics.LostStatusCount;

        [Category("Statistics"), DisplayName("Underruns")]
        public long Underruns => _robot.StreamMotion.Statistics.UnderrunCount;

        [Category("Statistics"), DisplayName("Positions sent")]
        public long CommandCount => _robot.StreamMotion.Statistics.CommandCount;
    }
}
