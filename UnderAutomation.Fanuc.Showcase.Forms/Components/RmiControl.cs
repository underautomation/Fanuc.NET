using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Rmi;
using UnderAutomation.Fanuc.Rmi.Data;

public partial class RmiControl : UserControl, IUserControl
{
    private FanucRobot _robot;

    public RmiControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(Frame), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(MotionConfiguration), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(JointAngles), new TypeConverterAttribute(typeof(ObjectConverter)));

        _robot = robot;
        InitializeComponent();

        // Init default objects for PropertyGrids (readable for a novice)
        pgSetUFrameUTool.SelectedObject = new SetUFrameUToolParams();

        pgReadDIN.SelectedObject = new ReadDINParams();
        pgWriteDOUT.SelectedObject = new WriteDOUTParams();

        pgReadUFrame.SelectedObject = new ReadUFrameParams();
        pgWriteUFrame.SelectedObject = new WriteUFrameParams();
        pgReadUTool.SelectedObject = new ReadUToolParams();
        pgWriteUTool.SelectedObject = new WriteUToolParams();

        pgReadPR.SelectedObject = new ReadPositionRegisterParams();
        pgWritePR.SelectedObject = new WritePositionRegisterParams();

        // Instructions
        pgWaitDin.SelectedObject = new WaitDinParams();
        pgWaitTime.SelectedObject = new WaitTimeParams();
        pgSetUFrameInstr.SelectedObject = new SetUFrameInstructionParams();
        pgSetUToolInstr.SelectedObject = new SetUToolInstructionParams();
        pgPayLoad.SelectedObject = new PayLoadParams();
        pgLinearMotion.SelectedObject = new LinearMotionParams();
        pgLinearRelative.SelectedObject = new LinearRelativeParams();
        pgJointMotion.SelectedObject = new JointMotionParams();
        pgJointRelative.SelectedObject = new JointRelativeParams();
        pgCircularMotion.SelectedObject = new CircularMotionParams();
        pgCircularRelative.SelectedObject = new CircularRelativeParams();
        pgJointMotionJRep.SelectedObject = new JointMotionJRepParams();
        pgJointRelativeJRep.SelectedObject = new JointRelativeJRepParams();
    }

    #region IUserControl  
    public string Title
    {
        get { return "RMI"; }
    }

    public bool FeatureEnabled
    {
        get { return _robot.Rmi.Connected; }
    }

    public void PeriodicUpdate()
    {
    }

    public void OnClose()
    {
    }

    public void OnOpen()
    {
    }
    #endregion

    // ===== Helpers for display =====

    private static string FormatFrame(Frame f)
    {
        if (f == null) return "<null>";
        return string.Format(CultureInfo.InvariantCulture,
            "X={0}, Y={1}, Z={2}, W={3}, P={4}, R={5}, Ext1={6}, Ext2={7}, Ext3={8}",
            f.X, f.Y, f.Z, f.W, f.P, f.R, f.Ext1, f.Ext2, f.Ext3);
    }

    private static string FormatConfig(MotionConfiguration c)
    {
        if (c == null) return "<null>";
        return string.Format(CultureInfo.InvariantCulture,
            "UF={0}, UT={1}, FRONT={2}, UP={3}, LEFT={4}, FLIP={5}, T4={6}, T5={7}, T6={8}",
            c.UFrameNumber, c.UToolNumber, c.Front, c.Up, c.Left, c.Flip, c.Turn4, c.Turn5, c.Turn6);
    }

    private static string FormatAngles(JointAngles j)
    {
        if (j == null) return "<null>";
        return string.Format(CultureInfo.InvariantCulture,
            "J1={0}, J2={1}, J3={2}, J4={3}, J5={4}, J6={5}, J7={6}, J8={7}, J9={8}",
            j.J1, j.J2, j.J3, j.J4, j.J5, j.J6, j.J7, j.J8, j.J9);
    }


    private static string BoolToOnOff(bool b)
    {
        return b ? "ON" : "OFF";
    }

    // Remplacement des méthodes utilisant => par des blocs { }

    private void btnInitialize_Click(object sender, EventArgs e) { DemoInitialize(); }
    private void btnAbort_Click(object sender, EventArgs e) { DemoAbort(); }
    private void btnPause_Click(object sender, EventArgs e) { DemoPause(); }
    private void btnContinue_Click(object sender, EventArgs e) { DemoContinue(); }
    private void btnReset_Click(object sender, EventArgs e) { DemoReset(); }
    private void btnGetStatus_Click(object sender, EventArgs e) { DemoGetStatus(); }
    private void btnReadError_Click(object sender, EventArgs e) { DemoReadError(); }
    private void btnGetUFrameUTool_Click(object sender, EventArgs e) { DemoGetUFrameUTool(); }
    private void btnSetUFrameUTool_Click(object sender, EventArgs e) { DemoSetUFrameUTool(); }

    private void DemoInitialize()
    {
       var ErrorId= _robot.Rmi.Initialize();
        txtCommands.AppendText("Initialize error: " + ErrorId + Environment.NewLine);
    }

    private void DemoAbort()
    {
        _robot.Rmi.Abort();
        txtCommands.AppendText("Abort: OK" + Environment.NewLine);
    }

    private void DemoPause()
    {
        _robot.Rmi.Pause();
        txtCommands.AppendText("Pause: OK" + Environment.NewLine);
    }

    private void DemoContinue()
    {
        _robot.Rmi.Continue();
        txtCommands.AppendText("Continue: OK" + Environment.NewLine);
    }

    private void DemoReset()
    {
        _robot.Rmi.Reset();
        txtCommands.AppendText("Reset: OK" + Environment.NewLine);
    }

    private void DemoGetStatus()
    {
        var s = _robot.Rmi.GetStatus();
        var msg = string.Format(CultureInfo.InvariantCulture,
            "GetStatus: ErrorId={0}, ServoReady={1}, TPMode={2}, RMIMotionStatus={3}, ProgramStatus={4}, SingleStepMode={5}, NumberUTool={6}, NumberUFrame={7}, NextSequenceId={8}",
            s.ErrorId, s.ServoReady, s.TPMode, s.RMIMotionStatus, s.ProgramStatus, s.SingleStepMode, s.NumberUTool, s.NumberUFrame, s.NextSequenceId);
        txtCommands.AppendText(msg + Environment.NewLine);
    }

    private void DemoReadError()
    {
        var e = _robot.Rmi.ReadError();
        var msg = string.Format(CultureInfo.InvariantCulture, "ReadError: ErrorId={0}, ErrorData={1}", e.ErrorId, e.ErrorData);
        txtCommands.AppendText(msg + Environment.NewLine);
    }

    private void DemoGetUFrameUTool()
    {
        var r = _robot.Rmi.GetUFrameUTool();
        var msg = string.Format(CultureInfo.InvariantCulture, "GetUFrameUTool: ErrorId={0}, UFrame={1}, UTool={2}", r.ErrorId, r.UFrameNumber, r.UToolNumber);
        txtCommands.AppendText(msg + Environment.NewLine);
    }

    private void DemoSetUFrameUTool()
    {
        var p = (SetUFrameUToolParams)pgSetUFrameUTool.SelectedObject;
        _robot.Rmi.SetUFrameUTool(p.UFrameNumber, p.UToolNumber);
        txtCommands.AppendText(string.Format(CultureInfo.InvariantCulture, "SetUFrameUTool: UF={0}, UT={1} -> OK", p.UFrameNumber, p.UToolNumber) + Environment.NewLine);
    }

    // ===== I/O demos =====

    private void btnReadDIN_Click(object sender, EventArgs e) { DemoReadDIN(); }
    private void btnWriteDOUT_Click(object sender, EventArgs e) { DemoWriteDOUT(); }

    private void DemoReadDIN()
    {
        var p = (ReadDINParams)pgReadDIN.SelectedObject;
        var r = _robot.Rmi.ReadDIN(p.PortNumber);
        var msg = string.Format(CultureInfo.InvariantCulture, "ReadDIN: ErrorId={0}, Port={1}, Value={2}", r.ErrorId, r.PortNumber, r.PortValue);
        txtIO.AppendText(msg + Environment.NewLine);
    }

    private void DemoWriteDOUT()
    {
        var p = (WriteDOUTParams)pgWriteDOUT.SelectedObject;
        _robot.Rmi.WriteDOUT(p.PortNumber, p.PortValue);
        txtIO.AppendText(string.Format(CultureInfo.InvariantCulture, "WriteDOUT: Port={0}, Value={1} -> OK", p.PortNumber, p.PortValue) + Environment.NewLine);
    }

    // ===== Frames & Tools demos =====

    private void btnReadUFrameData_Click(object sender, EventArgs e) { DemoReadUFrameData(); }
    private void btnWriteUFrameData_Click(object sender, EventArgs e) { DemoWriteUFrameData(); }
    private void btnReadUToolData_Click(object sender, EventArgs e) { DemoReadUToolData(); }
    private void btnWriteUToolData_Click(object sender, EventArgs e) { DemoWriteUToolData(); }

    private void DemoReadUFrameData()
    {
        var p = (ReadUFrameParams)pgReadUFrame.SelectedObject;
        var r = _robot.Rmi.ReadUFrame(p.FrameNumber);
        var msg = string.Format(CultureInfo.InvariantCulture, "ReadUFrameData: ErrorId={0}, Index={1}, Frame=({2})", r.ErrorId, r.Index, FormatFrame(r.Frame));
        txtFrames.AppendText(msg + Environment.NewLine);
    }

    private void DemoWriteUFrameData()
    {
        var p = (WriteUFrameParams)pgWriteUFrame.SelectedObject;
        _robot.Rmi.WriteUFrame(p.FrameNumber, p.Frame);
        txtFrames.AppendText(string.Format(CultureInfo.InvariantCulture, "WriteUFrameData: UF={0} -> Frame({1}) -> OK", p.FrameNumber, FormatFrame(p.Frame)) + Environment.NewLine);
    }

    private void DemoReadUToolData()
    {
        var p = (ReadUToolParams)pgReadUTool.SelectedObject;
        var r = _robot.Rmi.ReadUTool(p.ToolNumber);
        var msg = string.Format(CultureInfo.InvariantCulture, "ReadUToolData: ErrorId={0}, Index={1}, Frame=({2})", r.ErrorId, r.Index, FormatFrame(r.Frame));
        txtFrames.AppendText(msg + Environment.NewLine);
    }

    private void DemoWriteUToolData()
    {
        var p = (WriteUToolParams)pgWriteUTool.SelectedObject;
        _robot.Rmi.WriteUTool(p.ToolNumber, p.Frame);
        txtFrames.AppendText(string.Format(CultureInfo.InvariantCulture, "WriteUToolData: UT={0} -> Frame({1}) -> OK", p.ToolNumber, FormatFrame(p.Frame)) + Environment.NewLine);
    }

    // ===== Positions demos =====

    private void btnReadCartesianPosition_Click(object sender, EventArgs e) { DemoReadCartesianPosition(); }
    private void btnReadJointAngles_Click(object sender, EventArgs e) { DemoReadJointAngles(); }
    private void btnReadTCPSpeed_Click(object sender, EventArgs e) { DemoReadTCPSpeed(); }

    private void DemoReadCartesianPosition()
    {
        var r = _robot.Rmi.ReadCartesianPosition();
        var sb = new StringBuilder();
        sb.AppendFormat(CultureInfo.InvariantCulture, "ReadCartesianPosition: ErrorId={0}, TimeTag={1}", r.ErrorId, r.TimeTag).AppendLine();
        sb.Append("  Config: ").Append(FormatConfig(r.Configuration)).AppendLine();
        sb.Append("  Pos   : ").Append(FormatFrame(r.Position));
        txtPositions.AppendText(sb.ToString() + Environment.NewLine);
    }

    private void DemoReadJointAngles()
    {
        var r = _robot.Rmi.ReadJointAngles();
        var msg = string.Format(CultureInfo.InvariantCulture, "ReadJointAngles: ErrorId={0}, TimeTag={1}, {2}", r.ErrorId, r.TimeTag, FormatAngles(r.JointAngle));
        txtPositions.AppendText(msg + Environment.NewLine);
    }

    private void DemoReadTCPSpeed()
    {
        var r = _robot.Rmi.ReadTcpSpeed();
        var msg = string.Format(CultureInfo.InvariantCulture, "ReadTCPSpeed: ErrorId={0}, TimeTag={1}, Speed={2}", r.ErrorId, r.TimeTag, r.Speed);
        txtPositions.AppendText(msg + Environment.NewLine);
    }

    // ===== Registers demos =====

    private void btnReadPositionRegister_Click(object sender, EventArgs e) { DemoReadPositionRegister(); }
    private void btnWritePositionRegister_Click(object sender, EventArgs e) { DemoWritePositionRegister(); }

    private void DemoReadPositionRegister()
    {
        var p = (ReadPositionRegisterParams)pgReadPR.SelectedObject;
        var r = _robot.Rmi.ReadPositionRegister(p.RegisterNumber);
        var msg = string.Format(CultureInfo.InvariantCulture,
            "ReadPositionRegister: ErrorId={0}, PR[{1}] Config({2}) Pos({3})",
            r.ErrorId, r.RegisterNumber, FormatConfig(r.Configuration), FormatFrame(r.Position));
        txtRegisters.AppendText(msg + Environment.NewLine);
    }

    private void DemoWritePositionRegister()
    {
        var p = (WritePositionRegisterParams)pgWritePR.SelectedObject;
        _robot.Rmi.WritePositionRegister(p.RegisterNumber, p.Configuration, p.Position);
        txtRegisters.AppendText(string.Format(CultureInfo.InvariantCulture, "WritePositionRegister: PR[{0}] -> OK", p.RegisterNumber) + Environment.NewLine);
    }

    // ===== Instructions demos =====

    private void btnWaitDin_Click(object sender, EventArgs e) { DemoWaitDin(); }
    private void btnWaitTime_Click(object sender, EventArgs e) { DemoWaitTime(); }
    private void btnSetUFrame_Click(object sender, EventArgs e) { DemoSetUFrameInstr(); }
    private void btnSetUTool_Click(object sender, EventArgs e) { DemoSetUToolInstr(); }
    private void btnPayLoad_Click(object sender, EventArgs e) { DemoPayLoad(); }

    private void btnLinearMotion_Click(object sender, EventArgs e) { DemoLinearMotion(); }
    private void btnLinearRelative_Click(object sender, EventArgs e) { DemoLinearRelative(); }
    private void btnJointMotion_Click(object sender, EventArgs e) { DemoJointMotion(); }
    private void btnJointRelative_Click(object sender, EventArgs e) { DemoJointRelative(); }
    private void btnCircularMotion_Click(object sender, EventArgs e) { DemoCircularMotion(); }
    private void btnCircularRelative_Click(object sender, EventArgs e) { DemoCircularRelative(); }
    private void btnJointMotionJRep_Click(object sender, EventArgs e) { DemoJointMotionJRep(); }
    private void btnJointRelativeJRep_Click(object sender, EventArgs e) { DemoJointRelativeJRep(); }

    private void DemoWaitDin()
    {
        var p = (WaitDinParams)pgWaitDin.SelectedObject;
        var r = _robot.Rmi.WaitDin(p.SequenceId, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "WaitDin -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoWaitTime()
    {
        var p = (WaitTimeParams)pgWaitTime.SelectedObject;
        var r = _robot.Rmi.WaitTime(p.SequenceId, p.Time);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "WaitTime -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoSetUFrameInstr()
    {
        var p = (SetUFrameInstructionParams)pgSetUFrameInstr.SelectedObject;
        var r = _robot.Rmi.SetUFrameInstruction(p.SequenceId, p.FrameNumber);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "SetUFrame -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoSetUToolInstr()
    {
        var p = (SetUToolInstructionParams)pgSetUToolInstr.SelectedObject;
        var r = _robot.Rmi.SetUToolInstruction(p.SequenceId, p.ToolNumber);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "SetUTool -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoPayLoad()
    {
        var p = (PayLoadParams)pgPayLoad.SelectedObject;
        var r = _robot.Rmi.SetPayload(p.SequenceId, p.ScheduleNumber);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "PayLoad -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoLinearMotion()
    {
        var p = (LinearMotionParams)pgLinearMotion.SelectedObject;
        var r = _robot.Rmi.LinearMotion(p.SequenceId, p.Configuration, p.Position,
            p.SpeedType, p.Speed, p.TermType, p.TermValue, p.ACC, p.OffsetPRNumber, p.VisionPRNumber, p.WristJoint, p.MROT,
            p.LCBType, p.LCBValue, p.PortType, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "LinearMotion -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoLinearRelative()
    {
        var p = (LinearRelativeParams)pgLinearRelative.SelectedObject;
        var r = _robot.Rmi.LinearRelative(p.SequenceId, p.Configuration, p.Position,
            p.SpeedType, p.Speed, p.TermType, p.TermValue, p.ACC, p.OffsetPRNumber, p.VisionPRNumber, p.WristJoint, p.MROT,
            p.LCBType, p.LCBValue, p.PortType, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "LinearRelative -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoJointMotion()
    {
        var p = (JointMotionParams)pgJointMotion.SelectedObject;
        var r = _robot.Rmi.JointMotion(p.SequenceId, p.Configuration, p.Position,
            p.SpeedType, p.Speed, p.TermType, p.TermValue, p.ACC, p.OffsetPRNumber, p.VisionPRNumber, p.MROT,
            p.LCBType, p.LCBValue, p.PortType, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "JointMotion -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoJointRelative()
    {
        var p = (JointRelativeParams)pgJointRelative.SelectedObject;
        var r = _robot.Rmi.JointRelative(p.SequenceId, p.Configuration, p.Position,
            p.SpeedType, p.Speed, p.TermType, p.TermValue, p.ACC, p.OffsetPRNumber, p.VisionPRNumber, p.MROT,
            p.LCBType, p.LCBValue, p.PortType, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "JointRelative -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoCircularMotion()
    {
        var p = (CircularMotionParams)pgCircularMotion.SelectedObject;
        var r = _robot.Rmi.CircularMotion(p.SequenceId, p.Configuration, p.Position, p.ViaConfiguration, p.ViaPosition,
            p.SpeedType, p.Speed, p.TermType, p.TermValue, p.ACC, p.OffsetPRNumber, p.VisionPRNumber, p.WristJoint, p.MROT,
            p.LCBType, p.LCBValue, p.PortType, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "CircularMotion -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoCircularRelative()
    {
        var p = (CircularRelativeParams)pgCircularRelative.SelectedObject;
        var r = _robot.Rmi.CircularRelative(p.SequenceId, p.Configuration, p.Position, p.ViaConfiguration, p.ViaPosition,
            p.SpeedType, p.Speed, p.TermType, p.TermValue, p.ACC, p.OffsetPRNumber, p.VisionPRNumber, p.WristJoint, p.MROT,
            p.LCBType, p.LCBValue, p.PortType, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "CircularRelative -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoJointMotionJRep()
    {
        var p = (JointMotionJRepParams)pgJointMotionJRep.SelectedObject;
        var r = _robot.Rmi.JointMotionJRep(p.SequenceId, p.JointAngle, p.SpeedType, p.Speed, p.TermType, p.TermValue,
            p.ACC, p.OffsetPRNumber, p.VisionPRNumber, p.MROT, p.LCBType, p.LCBValue, p.PortType, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "JointMotionJRep -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    private void DemoJointRelativeJRep()
    {
        var p = (JointRelativeJRepParams)pgJointRelativeJRep.SelectedObject;
        var r = _robot.Rmi.JointRelativeJRep(p.SequenceId, p.JointAngle, p.SpeedType, p.Speed, p.TermType, p.TermValue,
            p.ACC, p.OffsetPRNumber, p.VisionPRNumber, p.MROT, p.LCBType, p.LCBValue, p.PortType, p.PortNumber, p.PortValue);
        txtInstructions.AppendText(string.Format(CultureInfo.InvariantCulture, "JointRelativeJRep -> SequenceId={0}, ErrorId={1}", r.SequenceId, r.ErrorId) + Environment.NewLine);
    }

    // ===== UI parameter classes (shown in PropertyGrids) =====

    public class SetUFrameUToolParams
    {
        [Category("Numbers")]
        public byte UFrameNumber { get; set; }
        [Category("Numbers")]
        public byte UToolNumber { get; set; }
        public SetUFrameUToolParams() { UFrameNumber = 1; UToolNumber = 1; }
    }

    public class ReadDINParams
    {
        [Category("I/O")]
        public short PortNumber { get; set; }
        public ReadDINParams() { PortNumber = 1; }
    }

    public class WriteDOUTParams
    {
        [Category("I/O")]
        public short PortNumber { get; set; }
        [Category("I/O")]
        public OnOff PortValue { get; set; }
        public WriteDOUTParams() { PortNumber = 1; PortValue = OnOff.ON; }
    }

    public class ReadUFrameParams
    {
        [Category("UFrame")]
        public byte FrameNumber { get; set; }
        public ReadUFrameParams() { FrameNumber = 1; }
    }

    public class WriteUFrameParams
    {
        [Category("UFrame")]
        public byte FrameNumber { get; set; }
        [Category("UFrame")]
        public Frame Frame { get; set; }
        public WriteUFrameParams()
        {
            FrameNumber = 1;
            Frame = new Frame { X = 0, Y = 0, Z = 0, W = 0, P = 0, R = 0 };
        }
    }

    public class ReadUToolParams
    {
        [Category("UTool")]
        public byte ToolNumber { get; set; }
        public ReadUToolParams() { ToolNumber = 1; }
    }

    public class WriteUToolParams
    {
        [Category("UTool")]
        public byte ToolNumber { get; set; }
        [Category("UTool")]
        public Frame Frame { get; set; }
        public WriteUToolParams()
        {
            ToolNumber = 1;
            Frame = new Frame { X = 0, Y = 0, Z = 0, W = 0, P = 0, R = 0 };
        }
    }

    public class ReadPositionRegisterParams
    {
        [Category("Register")]
        public short RegisterNumber { get; set; }
        public ReadPositionRegisterParams() { RegisterNumber = 1; }
    }

    public class WritePositionRegisterParams
    {
        [Category("Register")]
        public short RegisterNumber { get; set; }
        [Category("Register")]
        public MotionConfiguration Configuration { get; set; }
        [Category("Register")]
        public Frame Position { get; set; }
        public WritePositionRegisterParams()
        {
            RegisterNumber = 1;
            Configuration = new MotionConfiguration { UFrameNumber = 1, UToolNumber = 1 };
            Position = new Frame { X = 0, Y = 0, Z = 0, W = 0, P = 0, R = 0 };
        }
    }

    // ==== Instructions param classes ====

    public class WaitDinParams
    {
        [Category("Sequence")] public int SequenceId { get; set; }
        [Category("Args")] public short PortNumber { get; set; }
        [Category("Args")] public OnOff PortValue { get; set; }
        public WaitDinParams() { SequenceId = 1; PortNumber = 1; PortValue = OnOff.ON; }
    }

    public class WaitTimeParams
    {
        [Category("Sequence")] public int SequenceId { get; set; }
        [Category("Args")] public double Time { get; set; }
        public WaitTimeParams() { SequenceId = 1; Time = 0.5; }
    }

    public class SetUFrameInstructionParams
    {
        [Category("Sequence")] public int SequenceId { get; set; }
        [Category("Args")] public byte FrameNumber { get; set; }
        public SetUFrameInstructionParams() { SequenceId = 1; FrameNumber = 1; }
    }

    public class SetUToolInstructionParams
    {
        [Category("Sequence")] public int SequenceId { get; set; }
        [Category("Args")] public byte ToolNumber { get; set; }
        public SetUToolInstructionParams() { SequenceId = 1; ToolNumber = 1; }
    }

    public class PayLoadParams
    {
        [Category("Sequence")] public int SequenceId { get; set; }
        [Category("Args")] public byte ScheduleNumber { get; set; }
        public PayLoadParams() { SequenceId = 1; ScheduleNumber = 1; }
    }

    public class LinearBase
    {
        [Category("Sequence")] public int SequenceId { get; set; }
        [Category("Motion")] public MotionConfiguration Configuration { get; set; }
        [Category("Motion")] public Frame Position { get; set; }
        [Category("Speed")] public SpeedType SpeedType { get; set; }
        [Category("Speed")] public short Speed { get; set; }
        [Category("Termination")] public TerminationType TermType { get; set; }
        [Category("Termination")] public byte TermValue { get; set; }

        [Category("Options")] public byte? ACC { get; set; }
        [Category("Options")] public short? OffsetPRNumber { get; set; }
        [Category("Options")] public short? VisionPRNumber { get; set; }
        [Category("Options")] public bool WristJoint { get; set; }
        [Category("Options")] public bool MROT { get; set; }

        [Category("LCB")] public string LCBType { get; set; }
        [Category("LCB")] public short? LCBValue { get; set; }
        [Category("LCB")] public PortType? PortType { get; set; }
        [Category("LCB")] public short? PortNumber { get; set; }
        [Category("LCB")] public OnOff? PortValue { get; set; }

        public LinearBase()
        {
            SequenceId = 1;
            Configuration = new MotionConfiguration { UFrameNumber = 1, UToolNumber = 1 };
            Position = new Frame { X = 100, Y = 0, Z = 100, W = 0, P = 0, R = 0 };
            SpeedType = SpeedType.MmSec;
            Speed = 100;
            TermType = TerminationType.Cnt;
            TermValue = 100;
        }
    }

    public class LinearMotionParams : LinearBase { }
    public class LinearRelativeParams : LinearBase { }

    public class JointMotionParams : LinearBase { }
    public class JointRelativeParams : LinearBase { }

    public class CircularBase : LinearBase
    {
        [Category("Via")] public MotionConfiguration ViaConfiguration { get; set; }
        [Category("Via")] public Frame ViaPosition { get; set; }

        public CircularBase()
        {
            ViaConfiguration = new MotionConfiguration { UFrameNumber = 1, UToolNumber = 1 };
            ViaPosition = new Frame { X = 150, Y = 50, Z = 120, W = 0, P = 0, R = 0 };
        }
    }

    public class CircularMotionParams : CircularBase { }
    public class CircularRelativeParams : CircularBase { }

    public class JointRepBase
    {
        [Category("Sequence")] public int SequenceId { get; set; }
        [Category("Joints")] public JointAngles JointAngle { get; set; }
        [Category("Speed")] public SpeedType SpeedType { get; set; }
        [Category("Speed")] public short Speed { get; set; }
        [Category("Termination")] public TerminationType TermType { get; set; }
        [Category("Termination")] public byte TermValue { get; set; }

        [Category("Options")] public byte? ACC { get; set; }
        [Category("Options")] public short? OffsetPRNumber { get; set; }
        [Category("Options")] public short? VisionPRNumber { get; set; }
        [Category("Options")] public bool MROT { get; set; }

        [Category("LCB")] public string LCBType { get; set; }
        [Category("LCB")] public short? LCBValue { get; set; }
        [Category("LCB")] public PortType? PortType { get; set; }
        [Category("LCB")] public short? PortNumber { get; set; }
        [Category("LCB")] public OnOff? PortValue { get; set; }

        public JointRepBase()
        {
            SequenceId = 1;
            JointAngle = new JointAngles { J1 = 0, J2 = 0, J3 = 0, J4 = 0, J5 = 0, J6 = 0 };
            SpeedType = SpeedType.Percent;
            Speed = 10;
            TermType = TerminationType.Fine;
            TermValue = 0;
        }
    }

    public class JointMotionJRepParams : JointRepBase { }
    public class JointRelativeJRepParams : JointRepBase { }
}
