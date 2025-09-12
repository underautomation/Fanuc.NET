using System.ComponentModel;
using System.Diagnostics;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Snpx.Assignment;
using UnderAutomation.Fanuc.Snpx.Internal;

public partial class SnpxControl : UserControl, IUserControl
{
    FanucRobot _robot;

    public string Title => "SNPX";

    public bool FeatureEnabled => _robot.Snpx.Connected;

    public SnpxControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        TypeDescriptor.AddAttributes(typeof(Position), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(ExtendedCartesianPosition), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(JointsPosition), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        gridPR.SelectedObject = new Position() { CartesianPosition = new ExtendedCartesianPosition(), JointsPosition = new JointsPosition() };
        gridPR.ExpandAllGridItems();

        snpxSignalControlDigitals.InitializeForDigitalSignal(robot);
        snpxSignalControlNumericIOs.InitializeForNumericIO(robot);

        gridIntegerVariablesAssignment.Rows.Add("$RMT_MASTER");
        gridIntegerVariablesAssignment.Rows.Add("$REMOTE_CFG.$REMOTE_TYPE");

        gridStringVariablesAssignment.Rows.Add("$ROBOT_NAME");
        gridStringVariablesAssignment.Rows.Add("$ROB_ORD_NUM[1]");
        gridStringVariablesAssignment.Rows.Add("$SERV_DEV");
        gridStringVariablesAssignment.Rows.Add("$TP_DEFPROG");
        gridStringVariablesAssignment.Rows.Add("$TP_SCREEN");


        gridPositionVariablesAssignment.Rows.Add("$DIAG_GRP[1].$CUR_TCP");
        gridPositionVariablesAssignment.Rows.Add("$ZMP_GRP[1].$P_ACT");

        gridFloatVariablesAssignment.Rows.Add("$DB_MINDIST");
    }

    #region Assignments
    private void btnClearAssignments_Click(object sender, System.EventArgs e)
    {
        _numericRegistersBatchAssignment = null;
        _positionRegistersBatchAssignment = null;
        _stringRegistersBatchAssignment = null;

        _integerVariablesBatchAssignment = null;
        _floatVariablesBatchAssignment = null;
        _positionVariablesBatchAssignment = null;
        _stringVariablesBatchAssignment = null;

        _robot.Snpx.ClearAssignments();
    }

    private Assignment[] _assignments = new Assignment[0];
    #endregion

    public void PeriodicUpdate()
    {
        var assignments = _robot.Snpx.GetAssignments();
        if (!assignments.SequenceEqual(_assignments))
        {
            _assignments = assignments;
            try
            {
                lstAssignments.BeginUpdate();
                lstAssignments.Items.Clear();

                foreach (var assignment in _assignments)
                {
                    lstAssignments.Items.Add(new ListViewItem(new[] { assignment.Name, assignment.Offset.ToString() }));
                }
            }
            finally { lstAssignments.EndUpdate(); }
        }

        btnCreateNumericRegisterAssignment.Enabled = _numericRegistersBatchAssignment is null;
        btnCreatePositionRegisterAssignment.Enabled = _positionRegistersBatchAssignment is null;
        btnCreateStringRegisterAssignment.Enabled = _stringRegistersBatchAssignment is null;

        btnReadNumericRegisterAssignment.Enabled = _numericRegistersBatchAssignment is object;
        btnReadPositionRegisterAssignment.Enabled = _positionRegistersBatchAssignment is object;
        btnReadStringRegisterAssignment.Enabled = _stringRegistersBatchAssignment is object;


        btnCreateIntegerVariablesAssignment.Enabled = _integerVariablesBatchAssignment is null;
        btnCreateFloatVariablesAssignment.Enabled = _floatVariablesBatchAssignment is null;
        btnCreatePositionVariablesAssignment.Enabled = _positionVariablesBatchAssignment is null;
        btnCreateStringVariablesAssignment.Enabled = _stringVariablesBatchAssignment is null;

        btnReadIntegerVariablesAssignment.Enabled = _integerVariablesBatchAssignment is object;
        btnReadFloatVariablesAssignment.Enabled = _floatVariablesBatchAssignment is object;
        btnReadPositionVariablesAssignment.Enabled = _positionVariablesBatchAssignment is object;
        btnReadStringVariablesAssignment.Enabled = _stringVariablesBatchAssignment is object;

    }

    public void OnOpen()
    {
    }

    public void OnClose()
    {
    }

    #region Positions

    private void btnResetPosition_Click(object sender, System.EventArgs e)
    {
        gridPR.SelectedObject = new Position() { CartesianPosition = new ExtendedCartesianPosition(), JointsPosition = new JointsPosition() };
        gridPR.ExpandAllGridItems();
    }

    private void btnResetPositionCartesian_Click(object sender, System.EventArgs e)
    {
        gridPR.SelectedObject = new Position() { CartesianPosition = new ExtendedCartesianPosition() };
        gridPR.ExpandAllGridItems();
    }

    private void btnResetPositionJoint_Click(object sender, System.EventArgs e)
    {
        gridPR.SelectedObject = new Position() { JointsPosition = new JointsPosition() };
        gridPR.ExpandAllGridItems();
    }

    private void btnReadPR_Click(object sender, System.EventArgs e)
    {
        Position position = _robot.Snpx.PositionRegisters.Read((int)udPositionRegister.Value);
        gridPR.SelectedObject = position;
        gridPR.ExpandAllGridItems();
    }

    private void btnWritePR_Click(object sender, System.EventArgs e)
    {
        var position = gridPR.SelectedObject as Position;
        int index = (int)udPositionRegister.Value;

        var frm = new SnpxWritePosition(position?.CartesianPosition, position?.JointsPosition, $"Position register PR[{index}]");

        if (frm.ShowDialog() == DialogResult.OK)
        {

            if (frm.ShouldWriteCartesian)
            {
                _robot.Snpx.PositionRegisters.Write(index, frm.CartesianPosition);
            }
            else
            {
                _robot.Snpx.PositionRegisters.Write(index, frm.JointsPosition);
            }
            btnReadPR.PerformClick();
        }
    }


    private void btnReadPositionVariable_Click(object sender, System.EventArgs e)
    {
        Position position = _robot.Snpx.PositionSystemVariables.Read(txtPositionVariable.Text);
        gridPR.SelectedObject = position;
        gridPR.ExpandAllGridItems();
    }

    private void btnWritePositionVariable_Click(object sender, System.EventArgs e)
    {
        _robot.Snpx.PositionSystemVariables.Write(txtPositionVariable.Text, gridPR.SelectedObject as Position);

        var position = gridPR.SelectedObject as Position;

        var frm = new SnpxWritePosition(position?.CartesianPosition, position?.JointsPosition, $"Variable : {txtPositionVariable.Text}");

        if (frm.ShowDialog() == DialogResult.OK)
        {

            if (frm.ShouldWriteCartesian)
            {
                _robot.Snpx.PositionSystemVariables.Write(txtPositionVariable.Text, frm.CartesianPosition);
            }
            else
            {
                _robot.Snpx.PositionSystemVariables.Write(txtPositionVariable.Text, frm.JointsPosition);
            }
            btnReadPositionVariable.PerformClick();
        }
    }
    private void btnPositionWorld_Click(object sender, EventArgs e)
    {
        Position position = _robot.Snpx.CurrentPosition.ReadWorldPosition();
        gridPR.SelectedObject = position;
        gridPR.ExpandAllGridItems();
    }

    private void btnPositionUserFrame_Click(object sender, EventArgs e)
    {
        Position position = _robot.Snpx.CurrentPosition.ReadUserFramePosition((int)udFrame.Value);
        gridPR.SelectedObject = position;
        gridPR.ExpandAllGridItems();
    }

    #endregion

    #region Strings
    private void btnReadStringRegister_Click(object sender, System.EventArgs e)
    {
        string value = _robot.Snpx.StringRegisters.Read((int)udStringRegister.Value);
        txtStringValue.Text = value;
    }

    private void btnWriteStringRegister_Click(object sender, System.EventArgs e)
    {
        _robot.Snpx.StringRegisters.Write((int)udStringRegister.Value, txtStringValue.Text);
    }

    private void btnReadStringVariable_Click(object sender, System.EventArgs e)
    {
        string value = _robot.Snpx.StringSystemVariables.Read(txtStringVariable.Text);
        txtStringValue.Text = value;
    }

    private void btnWriteStringVariable_Click(object sender, System.EventArgs e)
    {
        _robot.Snpx.StringSystemVariables.Write(txtStringValue.Text, txtStringValue.Text);
    }
    #endregion

    #region Numerics
    private void btnReadNumericRegister_Click(object sender, System.EventArgs e)
    {
        float value = _robot.Snpx.NumericRegisters.Read((int)udNumericRegister.Value);
        udNumericValue.Value = (decimal)value;
    }
    private void btnWriteNumericRegister_Click(object sender, System.EventArgs e)
    {
        _robot.Snpx.NumericRegisters.Write((int)udNumericRegister.Value, (float)udNumericValue.Value);
    }


    private void btnReadIntegerVariable_Click(object sender, System.EventArgs e)
    {
        int value = _robot.Snpx.IntegerSystemVariables.Read(txtIntegerVariable.Text);
        udNumericValue.Value = value;
    }
    private void btnWriteIntegerVariable_Click(object sender, System.EventArgs e)
    {
        _robot.Snpx.IntegerSystemVariables.Write(txtIntegerVariable.Text, (int)udNumericValue.Value);
    }


    private void btnReadRealVariable_Click(object sender, EventArgs e)
    {
        float value = _robot.Snpx.RealSystemVariables.Read(txtRealVariable.Text);
        udNumericValue.Value = (decimal)value;
    }

    private void btnWriteRealVariable_Click(object sender, EventArgs e)
    {
        _robot.Snpx.RealSystemVariables.Write(txtRealVariable.Text, (float)udNumericValue.Value);
    }
    #endregion

    #region Batch

    private NumericRegistersBatchAssignment _numericRegistersBatchAssignment;
    private PositionRegistersBatchAssignment _positionRegistersBatchAssignment;
    private StringRegistersBatchAssignment _stringRegistersBatchAssignment;
    private IntegerSystemVariablesBatchAssignment _integerVariablesBatchAssignment;
    private RealSystemVariablesBatchAssignment _floatVariablesBatchAssignment;
    private PositionSystemVariablesBatchAssignment _positionVariablesBatchAssignment;
    private StringSystemVariablesBatchAssignment _stringVariablesBatchAssignment;

    private void SetGridBatchValueValue(object value, long elapsedTicks, int length)
    {
        gridBatchValue.SelectedObject = value;
        gridBatchValue.ExpandAllGridItems();
        lblBatchStats.Text = $"Read {length} items in {(double)elapsedTicks / Stopwatch.Frequency * 1000.0:F2} ms :";
    }

    private void btnCreateNumericRegisterAssignment_Click(object sender, EventArgs e)
    {
        _numericRegistersBatchAssignment = _robot.Snpx.NumericRegisters.CreateBatchAssignment((int)udBatchStart.Value, (int)udBatchCount.Value);
    }

    private void btnCreatePositionRegisterAssignment_Click(object sender, EventArgs e)
    {
        _positionRegistersBatchAssignment = _robot.Snpx.PositionRegisters.CreateBatchAssignment((int)udBatchStart.Value, (int)udBatchCount.Value);
    }

    private void btnCreateStringRegisterAssignment_Click(object sender, EventArgs e)
    {
        _stringRegistersBatchAssignment = _robot.Snpx.StringRegisters.CreateBatchAssignment((int)udBatchStart.Value, (int)udBatchCount.Value);
    }

    private void btnReadNumericRegisterAssignment_Click(object sender, EventArgs e)
    {
        var sw = Stopwatch.StartNew();

        float[] value = _numericRegistersBatchAssignment.Read();

        sw.Stop();
        SetGridBatchValueValue(value, sw.ElapsedTicks, _numericRegistersBatchAssignment.Assignments.Length);
    }

    private void btnReadPositionRegisterAssignment_Click(object sender, EventArgs e)
    {
        var sw = Stopwatch.StartNew();

        Position[] value = _positionRegistersBatchAssignment.Read();

        sw.Stop();
        SetGridBatchValueValue(value, sw.ElapsedTicks, _positionRegistersBatchAssignment.Assignments.Length);
    }

    private void btnReadStringRegisterAssignment_Click(object sender, EventArgs e)
    {
        var sw = Stopwatch.StartNew();

        string[] value = _stringRegistersBatchAssignment.Read();

        sw.Stop();
        SetGridBatchValueValue(value, sw.ElapsedTicks, _stringRegistersBatchAssignment.Assignments.Length);
    }

    private string[] GetGridVariablesName(DataGridView grid)
    {
        return grid.Rows.OfType<DataGridViewRow>()
            .Select(r => r.Cells[0].Value)
            .Where(v => v is string && !string.IsNullOrWhiteSpace((string)v))
            .Select(v => v.ToString())
            .ToArray();
    }

    private void btnCreateIntegerVariablesAssignment_Click(object sender, EventArgs e)
    {
        string[] variables = GetGridVariablesName(gridIntegerVariablesAssignment);

        _integerVariablesBatchAssignment = _robot.Snpx.IntegerSystemVariables.CreateBatchAssignment(variables);
    }

    private void btnCreateFloatVariablesAssignment_Click(object sender, EventArgs e)
    {
        string[] variables = GetGridVariablesName(gridFloatVariablesAssignment);

        _floatVariablesBatchAssignment = _robot.Snpx.RealSystemVariables.CreateBatchAssignment(variables);
    }

    private void btnCreatePositionVariablesAssignment_Click(object sender, EventArgs e)
    {
        string[] variables = GetGridVariablesName(gridPositionVariablesAssignment);

        _positionVariablesBatchAssignment = _robot.Snpx.PositionSystemVariables.CreateBatchAssignment(variables);
    }

    private void btnCreateStringVariablesAssignment_Click(object sender, EventArgs e)
    {
        string[] variables = GetGridVariablesName(gridStringVariablesAssignment);

        _stringVariablesBatchAssignment = _robot.Snpx.StringSystemVariables.CreateBatchAssignment(variables);
    }

    private void btnReadIntegerVariablesAssignment_Click(object sender, EventArgs e)
    {
        var sw = Stopwatch.StartNew();

        int[] value = _integerVariablesBatchAssignment.Read();

        sw.Stop();
        SetGridBatchValueValue(value, sw.ElapsedTicks, _integerVariablesBatchAssignment.Assignments.Length);
    }

    private void btnReadFloatVariablesAssignment_Click(object sender, EventArgs e)
    {
        var sw = Stopwatch.StartNew();

        float[] value = _floatVariablesBatchAssignment.Read();

        sw.Stop();
        SetGridBatchValueValue(value, sw.ElapsedTicks, _floatVariablesBatchAssignment.Assignments.Length);
    }

    private void btnReadPositionVariablesAssignment_Click(object sender, EventArgs e)
    {
        var sw = Stopwatch.StartNew();

        Position[] value = _positionVariablesBatchAssignment.Read();

        sw.Stop();
        SetGridBatchValueValue(value, sw.ElapsedTicks, _positionVariablesBatchAssignment.Assignments.Length);
    }

    private void btnReadStringVariablesAssignment_Click(object sender, EventArgs e)
    {
        var sw = Stopwatch.StartNew();

        string[] value = _stringVariablesBatchAssignment.Read();

        sw.Stop();
        SetGridBatchValueValue(value, sw.ElapsedTicks, _stringVariablesBatchAssignment.Assignments.Length);
    }

    #endregion

    #region Alarm
    private void btnClearAlarms_Click(object sender, EventArgs e)
    {
        _robot.Snpx.ClearAlarms();
    }   
    
    private void btnReadActiveAlarm_Click(object sender, EventArgs e)
    {
        RobotAlarm value = _robot.Snpx.ActiveAlarm.Read((int)udActiveAlarm.Value);
        gridActiveAlarm.SelectedObject = value;
        gridActiveAlarm.ExpandAllGridItems();
    }

    private void btnReadAlarmHistory_Click(object sender, EventArgs e)
    {
        RobotAlarm value = _robot.Snpx.AlarmHistory.Read((int)udAlarmHistory.Value);
        gridAlarmHistory.SelectedObject = value;
        gridAlarmHistory.ExpandAllGridItems();
    }
    #endregion
}
