using System.ComponentModel;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Rmi.Data;
using UnderAutomation.Fanuc.Rmi.TpInstructions;

public partial class RmiControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public RmiControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(RmiControllerStatusResponse), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(RmiControllerStatusResponse), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RmiInstructionResponse), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(RmiInstructionResponse), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RmiInstructionBase), new TypeConverterAttribute(typeof(ObjectConverter)));


        _robot = robot;
        InitializeComponent();


        pnlRelativeMoves.Controls.Clear();
        pnlAbsoluteMoves.Controls.Clear();
        pnlOtherInstructions.Controls.Clear();


        // Relative moves
        AddInstruction<JointRelativeJRepTpInstruction>(pnlRelativeMoves);
        AddInstruction<LinearRelativeJRepTpInstruction>(pnlRelativeMoves);
        AddInstruction<JointRelativeTpInstruction>(pnlRelativeMoves);
        AddInstruction<LinearRelativeTpInstruction>(pnlRelativeMoves);
        AddInstruction<CircularRelativeTpInstruction>(pnlRelativeMoves);

        // Absolute moves
        AddInstruction<JointMotionJRepTpInstruction>(pnlAbsoluteMoves);
        AddInstruction<LinearMotionJRepTpInstruction>(pnlAbsoluteMoves);
        AddInstruction<JointMotionTpInstruction>(pnlAbsoluteMoves);
        AddInstruction<LinearMotionTpInstruction>(pnlAbsoluteMoves);
        AddInstruction<CircularMotionTpInstruction>(pnlAbsoluteMoves);
        SetRmiVersionForControl(AddInstruction<SplineMotionJRepTpInstruction>(pnlAbsoluteMoves), 7);
        SetRmiVersionForControl(AddInstruction<SplineMotionTpInstruction>(pnlAbsoluteMoves), 7);

        // Other instructions
        AddInstruction<WaitDinTpInstruction>(pnlOtherInstructions);
        AddInstruction<SetUFrameTpInstruction>(pnlOtherInstructions);
        AddInstruction<SetUToolTpInstruction>(pnlOtherInstructions);
        AddInstruction<WaitTimeTpInstruction>(pnlOtherInstructions);
        AddInstruction<SetPayloadTpInstruction>(pnlOtherInstructions);
        SetRmiVersionForControl(AddInstruction<CallProgramTpInstruction>(pnlOtherInstructions), 4);

        lstInstructions.Items.Clear();
        if (Config.Current.RmiState?.Instructions != null)
        {
            foreach (var instruction in Config.Current.RmiState.Instructions)
            {
                AddInstruction(instruction);
            }
        }



        lstBuffer.Items.Clear();
        lstBuffer.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
        .SetValue(lstBuffer, true, null);


        gridUFrame.SelectedObject = new XYZWPRPosition();
        gridUTool.SelectedObject = new XYZWPRPosition();

        cbPortType.Items.Clear();
        foreach (var value in Enum.GetValues<RmiIoPortType>()) cbPortType.Items.Add(value);
        cbPortType.SelectedItem = RmiIoPortType.FLAG;

        gridPRCartesian.SelectedObject = new CartesianPositionWithUserFrame();

        gridPayloadValue.SelectedObject = new RmiSetPayloadParameters();
        gridPayloadValue.ExpandAllGridItems();
        gridPayloadCompensation.SelectedObject = new RmiSetPayloadCompensationParameters();
        gridPayloadCompensation.ExpandAllGridItems();

        lstInstructions_SelectedIndexChanged(null, null);

        _robot.Rmi.UnknownPacketReceived += x => _showUnknownPacketReceived = true;

        _robot.Rmi.RecordedCartesianPositionReceived += x =>
        {
            MessageBox.Show($"Recorded Cartesian Position Received:\nID:{x.PositionId}\nX:{x.Position.X}\nY:{x.Position.Y}\nZ:{x.Position.Z}\nW:{x.Position.W}\nP:{x.Position.P}\nR:{x.Position.R}", $"RMI Event : {nameof(_robot.Rmi.RecordedCartesianPositionReceived)}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        _robot.Rmi.RecordedJointPositionReceived += x => {
            var joints = string.Join("\n", x.Joints.Values.Select((j, i) => $"J{i + 1}: {j}"));
            MessageBox.Show($"Recorded Joint Position Received:\nID:{x.PositionId}\n{joints}", $"RMI Event : {nameof(_robot.Rmi.RecordedJointPositionReceived)}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
    }

    private bool _showUnknownPacketReceived;

    private readonly Dictionary<Control, int> _rmiVersionFeatures = new Dictionary<Control, int>();

    private void SetRmiVersionForControl(Control control, int version)
    {
        _rmiVersionFeatures[control] = version;
    }

    private void UpdateControlAvailabilityBasedOnRmiVersion()
    {
        if (!FeatureEnabled) return;

        int version = _robot.Rmi.MajorVersion;
        foreach (var ctrl in _rmiVersionFeatures)
        {
            var enabled = version >= ctrl.Value;
            ctrl.Key.Enabled = enabled;

            errorProvider.SetError(ctrl.Key, enabled ? null : $"Supported from RMI version {ctrl.Value}. Your current version is {version}");
        }
    }

    #region IUserControl  
    public string Title
    {
        get { return "RMI (R912)"; }
    }

    public bool FeatureEnabled
    {
        get { return _robot.Rmi.Connected; }
    }

    public void PeriodicUpdate()
    {
        var connected = _robot.Rmi.Connected;

        var status = connected ? _robot.Rmi.GetStatus() : null;

        var ready = status?.TPEnabled == false && status?.ServoReady == true;

        btnInitialize.Enabled = connected && status?.RmiMotionStatus == false && status?.TPEnabled == false;

        btnPause.Enabled = ready && status?.ProgramStatus == UnderAutomation.Fanuc.Common.TaskStatus.Running;

        btnAbort.Enabled = ready && (status?.ProgramStatus == UnderAutomation.Fanuc.Common.TaskStatus.Running || status?.ProgramStatus == UnderAutomation.Fanuc.Common.TaskStatus.Paused);
        btnContinue.Enabled = ready && status?.ProgramStatus == UnderAutomation.Fanuc.Common.TaskStatus.Paused;

        btnSendAll.Enabled = ready && lstInstructions.Items.Count > 0;
        btnSendSelected.Enabled = btnSendAll.Enabled && lstInstructions.SelectedItems.Count > 0;

        btnClearLocalQueued.Enabled = _robot.Rmi.Instructions.Any(x => x.Status == RmiInstructionStatus.LocalQueued);
        btnClearCompleted.Enabled = _robot.Rmi.Instructions.Any(x => x.Status == RmiInstructionStatus.Completed || x.Status == RmiInstructionStatus.Error);

        btnReset.Enabled = status?.RmiMotionStatus == true;

        if (!connected) lblError.Text = "Not connected";
        else if (status.TPEnabled) lblError.Text = "Turn TP Switch to OFF";
        else if (!status.ServoReady) lblError.Text = "Servo not ready";
        else if (_robot.Rmi.IsInHoldState) lblError.Text = "In HOLD state, cannot accept new commands. Press RESET...";
        else lblError.Text = "";

        if (!ready || lblError.Text != "") lblInfo.Text = "";
        else if (status.ProgramStatus == UnderAutomation.Fanuc.Common.TaskStatus.Aborted) lblInfo.Text = "Press Initialize to start...";
        else if (status.ProgramStatus == UnderAutomation.Fanuc.Common.TaskStatus.Running) lblInfo.Text = "RUNNING. Ready to receive instructions...";
        else if (status.ProgramStatus == UnderAutomation.Fanuc.Common.TaskStatus.Paused) lblInfo.Text = "PAUSED. Press Continue to resume...";
        else lblInfo.Text = "";


        gridStatus.SelectedObject = new Status
        {
            Connected = connected,
            IsInHoldState = _robot.Rmi.IsInHoldState,
            ControllerStatus = status,
            MajorVersion = _robot.Rmi.MajorVersion,
            MinorVersion = _robot.Rmi.MinorVersion,
            LastSequenceId = _robot.Rmi.LastSequenceId,
            WorkingPort = _robot.Rmi.WorkingPort,
        };
        gridStatus.ExpandAllGridItems();

        foreach (ListViewItem itm in lstBuffer.Items)
        {
            var response = (itm as ListViewItem)?.Tag as RmiInstructionResponse;
            if (response != null)
            {
                if (response.Status == RmiInstructionStatus.Error)
                {
                    itm.SubItems[2].Text = $"Error:{response.ErrorText} ({response.ErrorId})";
                }
                else itm.SubItems[2].Text = response.Status.ToString();
            }
        }

        lstBuffer.BeginUpdate();
        lstBuffer.Items.Clear();
        foreach (var value in _robot.Rmi.Instructions)
        {
            var itm = lstBuffer.Items.Add(new ListViewItem(new[]{
                value.SequenceId.ToString(),
                value.Instruction.GetType().Name.Replace("TpInstruction", ""),
                value.Status== RmiInstructionStatus.Error ? $"Error:{value.ErrorText}" : value.Status.ToString()
            }));
            itm.Tag = value;
        }
        lstBuffer.EndUpdate();

        if (_showUnknownPacketReceived)
        {
            _showUnknownPacketReceived = false;
            MessageBox.Show("An unknown command was received and is not supported by your current controller firmware.", "Unknown command", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void OnClose()
    {
    }

    public void OnOpen()
    {
        UpdateControlAvailabilityBasedOnRmiVersion();
    }
    #endregion

    private void lstInstructions_SelectedIndexChanged(object sender, EventArgs e)
    {
        lstBuffer.SelectedIndices.Clear();

        gridInstruction.SelectedObjects = lstInstructions.SelectedItems.Count > 0 ? lstInstructions.SelectedItems.OfType<ListViewItem>().Select(x => x.Tag).ToArray() : null;
        gridInstruction.ExpandAllGridItems();

        btnUp.Enabled = lstInstructions.SelectedIndices.Count > 0 && lstInstructions.SelectedIndices[0] > 0;
        btnDown.Enabled = lstInstructions.SelectedIndices.Count > 0 && lstInstructions.SelectedIndices[0] < lstInstructions.Items.Count - 1;
        btnDelete.Enabled = lstInstructions.SelectedIndices.Count > 0;
    }


    private void lstBuffer_SelectedIndexChanged(object sender, EventArgs e)
    {
        lstInstructions.SelectedIndices.Clear();

        gridInstruction.SelectedObjects = lstBuffer.SelectedItems.Count > 0 ? lstBuffer.SelectedItems.OfType<ListViewItem>().Select(x => x.Tag).ToArray() : null;
        gridInstruction.ExpandAllGridItems();
    }

    private void btnUp_Click(object sender, EventArgs e)
    {
        DoUpDown(-1);
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
        DoUpDown(1);
    }

    private void DoUpDown(int direction)
    {
        if (lstInstructions.SelectedIndices.Count == 0) return;
        var index = lstInstructions.SelectedIndices[0];
        var newIndex = index + direction;
        if (newIndex < 0 || newIndex >= lstInstructions.Items.Count) return;
        var item = lstInstructions.Items[index];
        lstInstructions.Items.RemoveAt(index);
        lstInstructions.Items.Insert(newIndex, item);
        lstInstructions.SelectedIndices.Clear();
        lstInstructions.SelectedIndices.Add(newIndex);
        SaveState();
    }

    private void SaveState()
    {
        var state = new RmiState();

        state.Instructions = lstInstructions.Items.OfType<ListViewItem>().Select(it => it.Tag as RmiInstructionBase).ToArray();

        Config.Current.RmiState = state;
        Config.Save();
    }

    private Button AddInstruction<T>(Panel parent) where T : RmiInstructionBase, new()
    {
        var btn = new Button();
        var name = typeof(T).Name.Replace("TpInstruction", "");
        btn.Text = name;
        btn.AutoSize = true;
        parent.Controls.Add(btn);
        btn.Click += (s, e) =>
        {
            var instruction = new T();

            try
            {
                if (instruction is CartesianMotionTpInstructionBase)
                {
                    (instruction as CartesianMotionTpInstructionBase).Target = _robot.Rmi.ReadCartesianPosition().Position;
                }
                else if (instruction is JRepMotionTpInstructionBase)
                {
                    (instruction as JRepMotionTpInstructionBase).Joints = _robot.Rmi.ReadJointAngles().JointAngle;
                }
            }
            catch { }

            lstInstructions.SelectedIndices.Clear();
            var itm = AddInstruction(instruction);
            itm.Selected = true;
            SaveState();
        };
        return btn;
    }

    private ListViewItem AddInstruction(RmiInstructionBase instruction)
    {
        var name = instruction.GetType().Name.Replace("TpInstruction", "");
        var itm = lstInstructions.Items.Add(name);
        itm.Tag = instruction;
        return itm;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstInstructions.SelectedIndices.Count == 0) return;
        var items = lstInstructions.SelectedItems.OfType<ListViewItem>().ToArray();
        foreach (var item in items)
            lstInstructions.Items.Remove(item);
        SaveState();
    }

    private void gridInstruction_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
    {
        SaveState();
    }

    private void btnInitialize_Click(object sender, EventArgs e)
    {
        _robot.Rmi.Initialize();
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        _robot.Rmi.Pause();
    }

    private void btnAbort_Click(object sender, EventArgs e)
    {
        _robot.Rmi.Abort();
    }

    private void btnContinue_Click(object sender, EventArgs e)
    {
        _robot.Rmi.Continue();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        _robot.Rmi.Reset();
    }

    private void btnSendAll_Click(object sender, EventArgs e)
    {
        _robot.Rmi.AutoSetNextSequenceId();

        foreach (ListViewItem item in lstInstructions.Items)
        {
            var instruction = item.Tag as RmiInstructionBase;
            if (instruction != null)
            {
                _robot.Rmi.SendTpInstruction(instruction);
            }
        }
    }

    private void btnSendSelected_Click(object sender, EventArgs e)
    {
        _robot.Rmi.AutoSetNextSequenceId();

        foreach (ListViewItem item in lstInstructions.SelectedItems.OfType<ListViewItem>().OrderBy(x => x.Index))
        {
            var instruction = item.Tag as RmiInstructionBase;
            if (instruction != null)
            {
                _robot.Rmi.SendTpInstruction(instruction);
            }
        }
    }

    private void btnClearLocalQueued_Click(object sender, EventArgs e)
    {
        _robot.Rmi.ClearLocalQueuedInstructions();
    }

    private void btnClearCompleted_Click(object sender, EventArgs e)
    {
        _robot.Rmi.ClearCompletedInstructions();
    }

    private void btnReadError_Click(object sender, EventArgs e)
    {
        RmiControllerErrorTextResponse errors = _robot.Rmi.ReadError(udReadErrorCount.Value == -1 ? null : (byte)udReadErrorCount.Value);
        gridReadError.SelectedObject = errors;
        gridReadError.ExpandAllGridItems();
    }

    private void btnGetCurrentUFrameUTool_Click(object sender, EventArgs e)
    {
        RmiUFrameUToolNumbersResponse response = _robot.Rmi.GetUFrameUTool();
        udSetUFrame.Value = response.Frame;
        udSetUTool.Value = response.Tool;
    }

    private void btnSetCurrentUFrameUTool_Click(object sender, EventArgs e)
    {
        _robot.Rmi.SetUFrameUTool((byte)udSetUFrame.Value, (byte)udSetUTool.Value);
    }

    private void btnGetStatusExtended_Click(object sender, EventArgs e)
    {
        RmiExtendedControllerStatusResponse status = _robot.Rmi.GetExtendedStatus();
        gridStatusExtended.SelectedObject = status;
    }

    private void btnReadUFrame_Click(object sender, EventArgs e)
    {
        RmiIndexedFrameResponse frame = _robot.Rmi.ReadUFrame((byte)udUFrame.Value);
        gridUFrame.SelectedObject = frame.Frame;
        gridUFrame.ExpandAllGridItems();
    }

    private void btnWriteUFrame_Click(object sender, EventArgs e)
    {
        XYZWPRPosition frame = gridUFrame.SelectedObject as XYZWPRPosition;
        _robot.Rmi.WriteUFrame((byte)udUFrame.Value, frame);
    }

    private void btnReadUTool_Click(object sender, EventArgs e)
    {
        RmiIndexedFrameResponse tool = _robot.Rmi.ReadUTool((byte)udUTool.Value);
        gridUTool.SelectedObject = tool.Frame;
        gridUTool.ExpandAllGridItems();
    }

    private void btnWriteUTool_Click(object sender, EventArgs e)
    {
        XYZWPRPosition tool = gridUTool.SelectedObject as XYZWPRPosition;
        _robot.Rmi.WriteUTool((byte)udUTool.Value, tool);
    }

    private void btnReadDIn_Click(object sender, EventArgs e)
    {
        RmiDigitalInputValueResponse value = _robot.Rmi.ReadDIN((short)udDinDout.Value);
        lblDinValue.Text = value.PortValue.ToString();
        lblDinValue.ForeColor = value.PortValue == RmiOnOff.ON ? Color.DarkGreen : Color.DarkRed;
    }

    private void BtnWriteDoutOn_Click(object sender, EventArgs e)
    {
        _robot.Rmi.WriteDOUT((short)udDinDout.Value, RmiOnOff.ON);
    }

    private void btnWriteDoutOff_Click(object sender, EventArgs e)
    {
        _robot.Rmi.WriteDOUT((short)udDinDout.Value, RmiOnOff.OFF);
    }

    private void btnReadIOPort_Click(object sender, EventArgs e)
    {
        RmiIoPortValueResponse response = _robot.Rmi.ReadIOPort((RmiIoPortType)cbPortType.SelectedItem, (int)udPortIndex.Value);
        udPortValue.Value = (decimal)response.Value;
    }

    private void btnWriteIOPort_Click(object sender, EventArgs e)
    {
        _robot.Rmi.WriteIOPort((RmiIoPortType)cbPortType.SelectedItem, (int)udPortIndex.Value, (double)udPortValue.Value);
    }

    private void btnReadCartesian_Click(object sender, EventArgs e)
    {
        gridCurrentPosition.SelectedObject = _robot.Rmi.ReadCartesianPosition().Position;
        gridCurrentPosition.ExpandAllGridItems();
    }

    private void btnReadJoints_Click(object sender, EventArgs e)
    {
        gridCurrentPosition.SelectedObject = _robot.Rmi.ReadJointAngles().JointAngle;
        gridCurrentPosition.ExpandAllGridItems();
    }

    private void btnSetSpeedOverride_Click(object sender, EventArgs e)
    {
        _robot.Rmi.SetOverride((byte)udSpeedOverride.Value);
    }

    private void btnReadPR_Click(object sender, EventArgs e)
    {
        RmiPositionRegisterDataResponse response = _robot.Rmi.ReadPositionRegister((short)udPR.Value);
        gridPRCartesian.SelectedObject = response.CartesianPosition;
    }

    private void btnWritePRCartesian_Click(object sender, EventArgs e)
    {
        _robot.Rmi.WritePositionRegisterCartesian((short)udPR.Value, gridPRCartesian.SelectedObject as CartesianPositionWithUserFrame);
    }


    private void btnReadNumericRegister_Click(object sender, EventArgs e)
    {
        RmiNumericRegisterValueResponse response = _robot.Rmi.ReadNumericRegister((int)udNumericRegisterIndex.Value);

        rdNumericRegisterInteger.Checked = response.Value.IsInteger;
        rdNumericRegisterReal.Checked = !response.Value.IsInteger;

        udNumericRegisterValue.Value = (decimal)response.Value.RealValue;
    }

    private void btnWriteNumericRegister_Click(object sender, EventArgs e)
    {
        if (rdNumericRegisterInteger.Checked)
            _robot.Rmi.WriteNumericRegisterAsInteger((int)udNumericRegisterIndex.Value, (int)udNumericRegisterValue.Value);
        else
            _robot.Rmi.WriteNumericRegisterAsDouble((int)udNumericRegisterIndex.Value, (double)udNumericRegisterValue.Value);
    }

    private void rdNumericRegisterInteger_CheckedChanged(object sender, EventArgs e)
    {
        if (rdNumericRegisterInteger.Checked) udNumericRegisterValue.DecimalPlaces = 0;
    }

    private void rdNumericRegisterReal_CheckedChanged(object sender, EventArgs e)
    {
        if (rdNumericRegisterReal.Checked) udNumericRegisterValue.DecimalPlaces = 5;
    }


    private void btnReadVariable_Click(object sender, EventArgs e)
    {
        RmiVariableValueResponse response = _robot.Rmi.ReadVariable(txtVariableName.Text);
        rdVariableReal.Checked = !response.IsInteger;
        rdVariableInteger.Checked = response.IsInteger;

        udVariableValue.Value = (decimal)response.RealValue;
    }

    private void btnWriteVariable_Click(object sender, EventArgs e)
    {
        if (rdVariableInteger.Checked)
            _robot.Rmi.WriteVariableAsInteger(txtVariableName.Text, (int)udVariableValue.Value);
        else
            _robot.Rmi.WriteVariableAsDouble(txtVariableName.Text, (double)udVariableValue.Value);
    }

    private void rdVariableInteger_CheckedChanged(object sender, EventArgs e)
    {
        if (rdVariableInteger.Checked) udVariableValue.DecimalPlaces = 0;
    }

    private void rdVariableReal_CheckedChanged(object sender, EventArgs e)
    {
        if (rdVariableReal.Checked) udVariableValue.DecimalPlaces = 0;
    }

    private void btnSetPayloadValue_Click(object sender, EventArgs e)
    {
        _robot.Rmi.SetPayloadValue(gridPayloadValue.SelectedObject as RmiSetPayloadParameters);
    }

    private void btnSetPayloadSchedule_Click(object sender, EventArgs e)
    {
        _robot.Rmi.SetPayloadSchedule((byte)udScheduleNumber.Value);
    }

    private void btnSetPayloadCompensation_Click(object sender, EventArgs e)
    {
        _robot.Rmi.SetPayloadCompensation(gridPayloadCompensation.SelectedObject as RmiSetPayloadCompensationParameters);
    }

    private void btnReadTcpSpeed_Click(object sender, EventArgs e)
    {
        lblTcpSpeed.Text = _robot.Rmi.ReadTcpSpeed().Speed.ToString("F2");
    }
}


public class RmiState
{
    public RmiInstructionBase[] Instructions { get; set; }
}

public class Status
{
    public bool Connected { get; internal set; }
    public bool IsInHoldState { get; internal set; }
    public RmiControllerStatusResponse ControllerStatus { get; internal set; }
    public int WorkingPort { get; internal set; }
    public int LastSequenceId { get; internal set; }
    public short MajorVersion { get; internal set; }
    public short MinorVersion { get; internal set; }
}