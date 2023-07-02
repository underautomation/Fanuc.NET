using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.MemoryAccess;
using UnderAutomation.Fanuc.MemoryAccess.Diagnosis;
using UnderAutomation.Fanuc.MemoryAccess.Internal;

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
            () => _robot.MemoryAccess.GetSafetyStatus(),
            Show);
    }

    #region IUserControl
    public string Title => "Safety status";

    public bool FeatureEnabled => _robot.MemoryAccess.Connected;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion


    private void Show(IFanucContent content)
    {
        positionGrid.SetSelectedObject(content );
    }
}
