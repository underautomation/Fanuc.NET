using System.ComponentModel;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Kinematics;

public partial class KinematicsControl : UserControl, IUserControl
{
    FanucRobot _robot;
    public KinematicsControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(DhParameters), new TypeConverterAttribute(typeof(ObjectConverter)));

        _robot = robot;

        InitializeComponent();

        cbModele.Items.Clear();
        cbModele.Items.Add("");
        foreach (var model in Enum.GetNames<ArmKinematicModels>())
        {
            cbModele.Items.Add(model.ToString());
        }
        cbModele.SelectedIndex = 0;

        gridJointsFK.SelectedObject = new JointsPosition(10, 0, 0, 0, 0, 0);
        gridDH.SelectedObject = DhParameters.FromArmKinematicModel(ArmKinematicModels.CRX10iA);
        gridCartesianIK.SelectedObject = new CartesianPosition(300, 0, 0, 0, 0, 0);

        lstIKResults.Items.Clear();
    }

    #region IUserControl
    public string Title => "Forward & Invert Kinematics";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate()
    {
        btnImportDH.Enabled = cbModele.SelectedIndex > 0;
        BtnCopyIKSelectedResult.Enabled = lstIKResults.SelectedItems.Count > 0;

        btnReadCurrentCartesianPosition.Enabled = _robot.Snpx.Connected || _robot.Ftp.Connected;
        btnReadCurrentJoints.Enabled = _robot.Snpx.Connected || _robot.Ftp.Connected;
        btnReadCurrentDh.Enabled = _robot.Ftp.Connected;

        btnCopyCurrentJoints.Enabled = gridCurrentJoints.SelectedObject is JointsPosition && gridCurrentDh.SelectedObject is DhParameters;
        btnCopyCurrentCartesian.Enabled = gridCurrentCartesian.SelectedObject is CartesianPosition && gridCurrentDh.SelectedObject is DhParameters;
    }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion


    private void btnCopyCurrentJoints_Click(object sender, EventArgs e)
    {
        var joints = gridCurrentJoints.SelectedObject as JointsPosition;
        var currentDh = gridCurrentDh.SelectedObject as DhParameters;
        if (joints is null || currentDh is null) return;

        gridJointsFK.SelectedObject = new JointsPosition(joints.Values);
        gridDH.SelectedObject = new DhParameters(currentDh);
        cbModele.SelectedIndex = 0;
    }

    private void btnCopyCurrentCartesian_Click(object sender, EventArgs e)
    {
        var CartesianPosition = gridCurrentCartesian.SelectedObject as CartesianPosition;
        var currentDh = gridCurrentDh.SelectedObject as DhParameters;
        if (CartesianPosition is null || currentDh is null) return;
        gridCartesianIK.SelectedObject = new CartesianPosition(CartesianPosition);
        gridDH.SelectedObject = new DhParameters(currentDh);
        cbModele.SelectedIndex = 0;
    }

    private void btnImportDH_Click(object sender, EventArgs e)
    {
        gridDH.SelectedObject = DhParameters.FromArmKinematicModel(Enum.Parse<ArmKinematicModels>(cbModele.SelectedItem.ToString()));
    }

    private void btnCopyFKResult_Click(object sender, EventArgs e)
    {
        var result = gridFKResult.SelectedObject as CartesianPosition;
        if (result is null) return;
        gridCartesianIK.SelectedObject = new CartesianPosition(result);
    }

    private void BtnCopyIKSelectedResult_Click(object sender, EventArgs e)
    {
        if (lstIKResults.SelectedItems.Count == 0) return;

        var joints = lstIKResults.SelectedItems[0].Tag as JointsPosition;

        if (joints is null) return;

        gridJointsFK.SelectedObject = new JointsPosition(joints.Values);
    }

    private void btnForwardKinematics_Click(object sender, EventArgs e)
    {
        var joints = gridJointsFK.SelectedObject as JointsPosition;
        var dh = gridDH.SelectedObject as DhParameters;

        if (joints is null || dh is null) return;

        gridFKResult.SelectedObject = KinematicsUtils.ForwardKinematics(joints, dh);
    }

    private void btnInvertKinematics_Click(object sender, EventArgs e)
    {
        var CartesianPosition = gridCartesianIK.SelectedObject as CartesianPosition;
        var dh = gridDH.SelectedObject as DhParameters;

        if (CartesianPosition is null || dh is null) return;

        var results = KinematicsUtils.InverseKinematics(CartesianPosition, dh);

        lstIKResults.Items.Clear();
        for (int i = 0; i < results.Length; i++)
        {
            var result = results[i];
            var item = new ListViewItem();
            item.Text = (i + 1).ToString();
            foreach (var value in result.Values) item.SubItems.Add(value.ToString("F4"));
            item.Tag = result;

            lstIKResults.Items.Add(item);
        }
    }

    private void btnReadCurrentJoints_Click(object sender, EventArgs e)
    {
        JointsPosition pos = null;
        if (_robot.Snpx.Connected)
        {
            pos = _robot.Snpx.CurrentPosition.ReadWorldPosition().JointsPosition;
        }
        else if (_robot.Ftp.Connected)
        {
            pos = _robot.Ftp.GetCurrentPosition().GroupsPosition[0].JointsPosition;
        }

        gridCurrentJoints.SelectedObject = pos;
    }

    private void btnReadCurrentDh_Click(object sender, EventArgs e)
    {
        var file = _robot.Ftp.KnownVariableFiles.GetSymotnFile();
        gridCurrentDh.SelectedObject = DhParameters.FromSymotnFile(file).FirstOrDefault();
    }

    private void btnReadCurrentCartesianPosition_Click(object sender, EventArgs e)
    {
        CartesianPosition pos = null;
        if (_robot.Snpx.Connected)
        {
            pos = _robot.Snpx.CurrentPosition.ReadWorldPosition().CartesianPosition;
        }
        else if (_robot.Ftp.Connected)
        {
            pos = _robot.Ftp.GetCurrentPosition().GroupsPosition[0].WorldPositions[0];
        }

        gridCurrentCartesian.SelectedObject = pos;
    }
}
