using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Ftp;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Ftp.Internal;

public partial class SafetyStatusControl: UserControl, IUserControl
{
    private FanucRobot _robot;
    public SafetyStatusControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            "sftysig.dg",
            FanucFileReaders.SafetyStatusReader,
            () => _robot.Ftp.GetSafetyStatus(),
            Show);
    }

    #region IUserControl
    public string Title => "Safety status";

    public bool FeatureEnabled => _robot.Ftp.Connected;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen()
    {
        if (FeatureEnabled) Header.OnOpen();
    }
    #endregion


    private void Show(IFanucContent content)
    {
        positionGrid.SetSelectedObject(content );
    }
}
