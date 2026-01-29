using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.StreamMotion.Data;

    public partial class StreamMotionControl : UserControl, IUserControl
    {
        private FanucRobot _robot;
        private volatile StatePacket _lastState;
        private CommandSettings _commandSettings;
        private RobotStateDisplay _robotStateDisplay;
        private int _stateUpdateCounter;
        private const int UI_UPDATE_RATE = 10; // Update UI every N packets (~50Hz at 500Hz packet rate)

        #region IUserControl Implementation
        public string Title => "Stream Motion (J519)";
        public bool FeatureEnabled => _robot.StreamMotion.Connected || _robot.StreamMotion.IsStreaming;
        public void PeriodicUpdate() { }
        public void OnOpen()
        {
            // Subscribe to events
            _robot.StreamMotion.StateReceived += OnStateReceived;
            _robot.StreamMotion.ReceiveError += OnReceiveError;

            // Initial button state
            UpdateButtonStates();
        }

        public void OnClose()
        {
            // Unsubscribe from events
            if (_robot?.StreamMotion != null)
            {
                _robot.StreamMotion.StateReceived -= OnStateReceived;
                _robot.StreamMotion.ReceiveError -= OnReceiveError;

                // Stop streaming if active
                if (_robot.StreamMotion.IsStreaming)
                {
                    try { _robot.StreamMotion.Stop(); } catch { }
                }

                // Disconnect if connected
                if (_robot.StreamMotion.IsConnected)
                {
                    try { _robot.StreamMotion.Disconnect(); } catch { }
                }
            }
        }
        #endregion

        #region Nested Classes for PropertyGrid

        /// <summary>
        /// Settings class for command configuration via PropertyGrid
        /// </summary>
        public class CommandSettings
        {
            [Category("Motion Settings")]
            [DisplayName("Data Style")]
            [Description("Type of position data (Cartesian or Joint)")]
            public DataStyle DataStyle { get; set; }

            [Category("Motion Settings")]
            [DisplayName("Is Last Data")]
            [Description("Marks this as the last command in a sequence")]
            public bool IsLastData { get; set; }

            [Category("Position - Cartesian")]
            [DisplayName("X (mm)")]
            [Description("X position in millimeters")]
            public float X { get; set; }

            [Category("Position - Cartesian")]
            [DisplayName("Y (mm)")]
            [Description("Y position in millimeters")]
            public float Y { get; set; }

            [Category("Position - Cartesian")]
            [DisplayName("Z (mm)")]
            [Description("Z position in millimeters")]
            public float Z { get; set; }

            [Category("Position - Cartesian")]
            [DisplayName("W (deg)")]
            [Description("W rotation in degrees")]
            public float W { get; set; }

            [Category("Position - Cartesian")]
            [DisplayName("P (deg)")]
            [Description("P rotation in degrees")]
            public float P { get; set; }

            [Category("Position - Cartesian")]
            [DisplayName("R (deg)")]
            [Description("R rotation in degrees")]
            public float R { get; set; }

            [Category("Position - Joints")]
            [DisplayName("J1 (deg)")]
            [Description("Joint 1 position in degrees")]
            public float J1 { get; set; }

            [Category("Position - Joints")]
            [DisplayName("J2 (deg)")]
            [Description("Joint 2 position in degrees")]
            public float J2 { get; set; }

            [Category("Position - Joints")]
            [DisplayName("J3 (deg)")]
            [Description("Joint 3 position in degrees")]
            public float J3 { get; set; }

            [Category("Position - Joints")]
            [DisplayName("J4 (deg)")]
            [Description("Joint 4 position in degrees")]
            public float J4 { get; set; }

            [Category("Position - Joints")]
            [DisplayName("J5 (deg)")]
            [Description("Joint 5 position in degrees")]
            public float J5 { get; set; }

            [Category("Position - Joints")]
            [DisplayName("J6 (deg)")]
            [Description("Joint 6 position in degrees")]
            public float J6 { get; set; }

            [Category("Position - Extended")]
            [DisplayName("E1")]
            [Description("Extended axis 1")]
            public float E1 { get; set; }

            [Category("Position - Extended")]
            [DisplayName("E2")]
            [Description("Extended axis 2")]
            public float E2 { get; set; }

            [Category("Position - Extended")]
            [DisplayName("E3")]
            [Description("Extended axis 3")]
            public float E3 { get; set; }

            [Category("IO - Read")]
            [DisplayName("Read IO Type")]
            [Description("Type of I/O to read")]
            public IOType ReadIOType { get; set; }

            [Category("IO - Read")]
            [DisplayName("Read IO Index")]
            [Description("Index of I/O to read")]
            public ushort ReadIOIndex { get; set; }

            [Category("IO - Read")]
            [DisplayName("Read IO Mask")]
            [Description("Mask for I/O read operation")]
            public ushort ReadIOMask { get; set; }

            [Category("IO - Write")]
            [DisplayName("Write IO Type")]
            [Description("Type of I/O to write")]
            public IOType WriteIOType { get; set; }

            [Category("IO - Write")]
            [DisplayName("Write IO Index")]
            [Description("Index of I/O to write")]
            public ushort WriteIOIndex { get; set; }

            [Category("IO - Write")]
            [DisplayName("Write IO Mask")]
            [Description("Mask for I/O write operation")]
            public ushort WriteIOMask { get; set; }

            [Category("IO - Write")]
            [DisplayName("Write IO Value")]
            [Description("Value to write to I/O")]
            public ushort WriteIOValue { get; set; }

            public CommandSettings()
            {
                DataStyle = DataStyle.Joint;
            }

            public CommandPacket ToCommandPacket()
            {
                var command = new CommandPacket
                {
                    DataStyle = DataStyle,
                    IsLastData = IsLastData,
                    ReadIOType = ReadIOType,
                    ReadIOIndex = ReadIOIndex,
                    ReadIOMask = ReadIOMask,
                    WriteIOType = WriteIOType,
                    WriteIOIndex = WriteIOIndex,
                    WriteIOMask = WriteIOMask,
                    WriteIOValue = WriteIOValue,
                    MotionData = new MotionData()
                };

                // Set values based on data style
                if (DataStyle == DataStyle.Cartesian)
                {
                    command.MotionData.X = X;
                    command.MotionData.Y = Y;
                    command.MotionData.Z = Z;
                    command.MotionData.W = W;
                    command.MotionData.P = P;
                    command.MotionData.R = R;
                }
                else
                {
                    command.MotionData.J1 = J1;
                    command.MotionData.J2 = J2;
                    command.MotionData.J3 = J3;
                    command.MotionData.J4 = J4;
                    command.MotionData.J5 = J5;
                    command.MotionData.J6 = J6;
                }

                command.MotionData.E1 = E1;
                command.MotionData.E2 = E2;
                command.MotionData.E3 = E3;

                return command;
            }

            public void LoadFromState(StatePacket state)
            {
                if (state == null) return;

                // Load Cartesian position
                if (state.CartesianPosition != null)
                {
                    X = state.CartesianPosition.X;
                    Y = state.CartesianPosition.Y;
                    Z = state.CartesianPosition.Z;
                    W = state.CartesianPosition.W;
                    P = state.CartesianPosition.P;
                    R = state.CartesianPosition.R;
                }

                // Load joints position
                if (state.JointPosition != null)
                {
                    J1 = state.JointPosition.J1;
                    J2 = state.JointPosition.J2;
                    J3 = state.JointPosition.J3;
                    J4 = state.JointPosition.J4;
                    J5 = state.JointPosition.J5;
                    J6 = state.JointPosition.J6;

                    E1 = state.JointPosition.E1;
                    E2 = state.JointPosition.E2;
                    E3 = state.JointPosition.E3;
                }
            }
        }

        /// <summary>
        /// Display class for robot state via PropertyGrid (read-only)
        /// </summary>
        public class RobotStateDisplay
        {
            private StatePacket _state;
            private double _robotFrequency;
            private double _measuredFrequency;
            private long _packetCount;
            private bool _isStreaming;

            [Category("Status")]
            [DisplayName("Is Streaming")]
            [Description("Whether the robot is currently streaming data")]
            public bool IsStreaming => _isStreaming;

            [Category("Frequency")]
            [DisplayName("Robot Frequency (Hz)")]
            [Description("Frequency reported by the robot in its packets")]
            public double RobotFrequency => _robotFrequency;

            [Category("Frequency")]
            [DisplayName("Measured Frequency (Hz)")]
            [Description("Actually measured packet reception frequency")]
            public double MeasuredFrequency => _measuredFrequency;

            [Category("Frequency")]
            [DisplayName("Packet Count")]
            [Description("Total number of packets received since streaming started")]
            public long PacketCount => _packetCount;

            [Category("Status")]
            [DisplayName("Sequence Number")]
            [Description("Current command sequence number")]
            public uint SequenceNumber => _state?.SequenceNumber ?? 0;

            [Category("Status")]
            [DisplayName("Timestamp")]
            [Description("Robot controller timestamp (ms)")]
            public uint TimeStamp => _state?.TimeStamp ?? 0;

            [Category("Status")]
            [DisplayName("Received At")]
            [Description("Time when packet was received")]
            public DateTime ReceivedAt => _state?.ReceivedAt ?? DateTime.MinValue;

            [Category("Status")]
            [DisplayName("Ready For Commands")]
            [Description("Robot is ready to receive commands")]
            public bool ReadyForCommands => _state?.Status?.ReadyForCommands ?? false;

            [Category("Status")]
            [DisplayName("Command Received")]
            [Description("Robot has received at least one command")]
            public bool CommandReceived => _state?.Status?.CommandReceived ?? false;

            [Category("Status")]
            [DisplayName("System Ready")]
            [Description("System is ready (SYSRDY)")]
            public bool SystemReady => _state?.Status?.SystemReady ?? false;

            [Category("Status")]
            [DisplayName("In Motion")]
            [Description("Robot is currently in motion")]
            public bool InMotion => _state?.Status?.InMotion ?? false;

            [Category("IO Read Result")]
            [DisplayName("IO Type")]
            [Description("Type of I/O that was read")]
            public IOType IOReadType => _state?.IORead?.Type ?? IOType.None;

            [Category("IO Read Result")]
            [DisplayName("IO Index")]
            [Description("Index of the I/O read")]
            public ushort IOReadIndex => _state?.IORead?.Index ?? 0;

            [Category("IO Read Result")]
            [DisplayName("IO Value")]
            [Description("Value read from I/O")]
            public ushort IOReadValue => _state?.IORead?.Value ?? 0;

            [Category("Position - Cartesian")]
            [DisplayName("X (mm)")]
            public float X => _state?.CartesianPosition?.X ?? 0;

            [Category("Position - Cartesian")]
            [DisplayName("Y (mm)")]
            public float Y => _state?.CartesianPosition?.Y ?? 0;

            [Category("Position - Cartesian")]
            [DisplayName("Z (mm)")]
            public float Z => _state?.CartesianPosition?.Z ?? 0;

            [Category("Position - Cartesian")]
            [DisplayName("W (deg)")]
            public float W => _state?.CartesianPosition?.W ?? 0;

            [Category("Position - Cartesian")]
            [DisplayName("P (deg)")]
            public float P => _state?.CartesianPosition?.P ?? 0;

            [Category("Position - Cartesian")]
            [DisplayName("R (deg)")]
            public float R => _state?.CartesianPosition?.R ?? 0;

            [Category("Position - Joints")]
            [DisplayName("J1 (deg)")]
            public float J1 => _state?.JointPosition?.J1 ?? 0;

            [Category("Position - Joints")]
            [DisplayName("J2 (deg)")]
            public float J2 => _state?.JointPosition?.J2 ?? 0;

            [Category("Position - Joints")]
            [DisplayName("J3 (deg)")]
            public float J3 => _state?.JointPosition?.J3 ?? 0;

            [Category("Position - Joints")]
            [DisplayName("J4 (deg)")]
            public float J4 => _state?.JointPosition?.J4 ?? 0;

            [Category("Position - Joints")]
            [DisplayName("J5 (deg)")]
            public float J5 => _state?.JointPosition?.J5 ?? 0;

            [Category("Position - Joints")]
            [DisplayName("J6 (deg)")]
            public float J6 => _state?.JointPosition?.J6 ?? 0;

            [Category("Position - Extended")]
            [DisplayName("E1")]
            public float E1 => _state?.JointPosition?.E1 ?? 0;

            [Category("Position - Extended")]
            [DisplayName("E2")]
            public float E2 => _state?.JointPosition?.E2 ?? 0;

            [Category("Position - Extended")]
            [DisplayName("E3")]
            public float E3 => _state?.JointPosition?.E3 ?? 0;

            [Category("Motor Currents")]
            [DisplayName("Motor 1 (A)")]
            public float Motor1 => _state?.MotorCurrents?.Axis1 ?? 0;

            [Category("Motor Currents")]
            [DisplayName("Motor 2 (A)")]
            public float Motor2 => _state?.MotorCurrents?.Axis2 ?? 0;

            [Category("Motor Currents")]
            [DisplayName("Motor 3 (A)")]
            public float Motor3 => _state?.MotorCurrents?.Axis3 ?? 0;

            [Category("Motor Currents")]
            [DisplayName("Motor 4 (A)")]
            public float Motor4 => _state?.MotorCurrents?.Axis4 ?? 0;

            [Category("Motor Currents")]
            [DisplayName("Motor 5 (A)")]
            public float Motor5 => _state?.MotorCurrents?.Axis5 ?? 0;

            [Category("Motor Currents")]
            [DisplayName("Motor 6 (A)")]
            public float Motor6 => _state?.MotorCurrents?.Axis6 ?? 0;

            public void UpdateState(StatePacket state)
            {
                _state = state;
            }

            public void UpdateFrequencies(double robotFrequency, double measuredFrequency, long packetCount, bool isStreaming)
            {
                _robotFrequency = robotFrequency;
                _measuredFrequency = measuredFrequency;
                _packetCount = packetCount;
                _isStreaming = isStreaming;
            }
        }

        #endregion

        public StreamMotionControl(FanucRobot robot)
        {
            InitializeComponent();

            _robot = robot;
            _commandSettings = new CommandSettings();
            _robotStateDisplay = new RobotStateDisplay();

            // Setup property grids
            propertyGridCommand.SelectedObject = _commandSettings;
            propertyGridState.SelectedObject = _robotStateDisplay;

        }

        /// <summary>
        /// Handle state received from robot - called on background thread
        /// </summary>
        private void OnStateReceived(object sender, StateReceivedEventArgs e)
        {
            _lastState = e.State;
            _stateUpdateCounter++;

            // Only update UI every N packets to avoid overwhelming the UI thread
            if (_stateUpdateCounter >= UI_UPDATE_RATE)
            {
                _stateUpdateCounter = 0;

                // Update UI on UI thread
                if (IsHandleCreated && !IsDisposed)
                {
                    try
                    {
                        BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                DisplayLastState();
                            }
                            catch (ObjectDisposedException)
                            {
                                // Control was disposed
                            }
                        }));
                    }
                    catch (ObjectDisposedException)
                    {
                        // Control was disposed
                    }
                    catch (InvalidOperationException)
                    {
                        // Handle not created or control disposed
                    }
                }
            }
        }

        /// <summary>
        /// Handle receive error - called on background thread
        /// </summary>
        private void OnReceiveError(object sender, ReceiveErrorEventArgs e)
        {
            if (IsHandleCreated && !IsDisposed)
            {
                try
                {
                    BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            LogMessage("Receive error: " + e.Exception.Message);
                            if (!e.IsStreaming)
                            {
                                UpdateButtonStates();
                            }
                        }
                        catch (ObjectDisposedException)
                        {
                            // Control was disposed
                        }
                    }));
                }
                catch (ObjectDisposedException)
                {
                    // Control was disposed
                }
                catch (InvalidOperationException)
                {
                    // Handle not created or control disposed
                }
            }
        }

        /// <summary>
        /// Update the display with the last received state
        /// </summary>
        private void DisplayLastState()
        {
            var state = _lastState;
            _robotStateDisplay.UpdateState(state);
            _robotStateDisplay.UpdateFrequencies(
                _robot.StreamMotion.RobotFrequency,
                _robot.StreamMotion.MeasuredFrequency,
                _robot.StreamMotion.PacketCount,
                _robot.StreamMotion.IsStreaming
            );
            propertyGridState.Refresh();
            UpdateButtonStates();
        }

        /// <summary>
        /// Update button enabled states based on current connection/streaming state
        /// </summary>
        private void UpdateButtonStates()
        {
            bool isConnected = _robot.StreamMotion.IsConnected;
            bool isStreaming = _robot.StreamMotion.IsStreaming;

            btnStart.Enabled = isConnected && !isStreaming;
            btnStop.Enabled = isConnected && isStreaming;
            btnSendCommand.Enabled = isConnected && isStreaming;
            btnLoadCurrentPosition.Enabled = _lastState != null;
        }

        #region Event Handlers


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Start streaming - this begins the background receive loop
                // State packets will be delivered via the StateReceived event
                _robot.StreamMotion.Start();
                LogMessage("Started Stream Motion streaming. Receiving state packets...");
                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                LogMessage("Start error: " + ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                _robot.StreamMotion.Stop();
                LogMessage("Stopped Stream Motion streaming. Total packets received: " + _robot.StreamMotion.PacketCount);
                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                LogMessage("Stop error: " + ex.Message);
            }
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_robot.StreamMotion.IsStreaming)
                {
                    LogMessage("Error: Cannot send command when not streaming. Start streaming first.");
                    return;
                }

                // Build command packet from settings
                var command = _commandSettings.ToCommandPacket();

                // Queue command - it will be sent with the next received state packet's sequence number
                _robot.StreamMotion.SendCommand(command);
                LogMessage("Command queued: " + _commandSettings.DataStyle + " motion");
            }
            catch (Exception ex)
            {
                LogMessage("Send command error: " + ex.Message);
            }
        }

        private void btnLoadCurrentPosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (_lastState == null)
                {
                    LogMessage("No state received yet.");
                    return;
                }

                _commandSettings.LoadFromState(_lastState);
                propertyGridCommand.Refresh();
                LogMessage("Loaded current robot position into command settings.");
            }
            catch (Exception ex)
            {
                LogMessage("Load position error: " + ex.Message);
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        #endregion

        /// <summary>
        /// Log a message to the log text box
        /// </summary>
        private void LogMessage(string message)
        {
            var timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            var fullMessage = "[" + timestamp + "] " + message + Environment.NewLine;

            if (InvokeRequired)
            {
                try
                {
                    BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            txtLog.AppendText(fullMessage);
                        }
                        catch (ObjectDisposedException)
                        {
                            // Control was disposed
                        }
                    }));
                }
                catch (ObjectDisposedException)
                {
                    // Control was disposed
                }
                catch (InvalidOperationException)
                {
                    // Handle not created
                }
            }
            else
            {
                txtLog.AppendText(fullMessage);
            }
        }
    }
