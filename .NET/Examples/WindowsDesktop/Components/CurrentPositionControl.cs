using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.MemoryAccess;
using UnderAutomation.Fanuc.MemoryAccess.Diagnosis;
using UnderAutomation.Fanuc.MemoryAccess.Internal;

public partial class CurrentPositionControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public CurrentPositionControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            "curpos.dg",
            FanucFileReaders.CurrentPositionReader,
            () => _robot.MemoryAccess.GetCurrentPosition(),
            Show);
    }

    #region IUserControl
    public string Title => "Current position";

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
