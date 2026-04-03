using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common.Files;

public partial class SafetyStatusControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public SafetyStatusControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            _robot,
            "sftysig.dg",
            FanucFileReaders.SafetyStatusReader,
            (client) => client.GetSafetyStatus(),
            Show);
    }

    #region IUserControl
    public string Title => "Safety status (CGTP or FTP)";

    public bool FeatureEnabled => _robot.Ftp.Connected || _robot.Cgtp.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen()
    {
        if (FeatureEnabled) Header.OnOpen();
    }
    #endregion


    private void Show(IFanucContent content)
    {
        positionGrid.SetSelectedObject(content);
    }
}
