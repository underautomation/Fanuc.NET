using UnderAutomation.Fanuc.Common;

public partial class SnpxWritePosition
{

    public bool ShouldWriteCartesian { get; private set; } = false;

    public ExtendedCartesianPosition CartesianPosition => gridCartesian.SelectedObject as ExtendedCartesianPosition;
    public JointsPosition JointsPosition => gridJoints.SelectedObject as JointsPosition;

    public SnpxWritePosition(ExtendedCartesianPosition cartesian, JointsPosition joint, string name)
    {
        InitializeComponent();
        this.Text = name;
        gridCartesian.SelectedObject = cartesian ?? new ExtendedCartesianPosition();
        gridJoints.SelectedObject = joint ?? new JointsPosition();
    }


    private void btnWriteCartesian_Click(object sender, EventArgs e)
    {
        ShouldWriteCartesian = true;
    }
}
