using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
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
        TypeDescriptor.AddAttributes(typeof(PositionCartesian), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(PositionJoint), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        gridPR.SelectedObject = new Position() { Cartesian = new PositionCartesian(), Joint = new PositionJoint() };
        gridPR.ExpandAllGridItems();

        snpxSignalControlDigitals.InitializeForDigitalSignal(robot);
        snpxSignalControlNumericIOs.InitializeForNumericIO(robot);
    }

    #region Assignments
    private void btnClearAssignments_Click(object sender, System.EventArgs e)
    {
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
        gridPR.SelectedObject = new Position() { Cartesian = new PositionCartesian(), Joint = new PositionJoint() };
        gridPR.ExpandAllGridItems();
    }

    private void btnResetPositionCartesian_Click(object sender, System.EventArgs e)
    {
        gridPR.SelectedObject = new Position() { Cartesian = new PositionCartesian() };
        gridPR.ExpandAllGridItems();
    }

    private void btnResetPositionJoint_Click(object sender, System.EventArgs e)
    {
        gridPR.SelectedObject = new Position() { Joint = new PositionJoint() };
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
        _robot.Snpx.PositionRegisters.Write((int)udPositionRegister.Value, gridPR.SelectedObject as Position);
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
    #endregion

    #region Alarms
    private void btnClearAlarms_Click(object sender, System.EventArgs e)
    {
        _robot.Snpx.ClearAlarms();
    }
    #endregion


}
