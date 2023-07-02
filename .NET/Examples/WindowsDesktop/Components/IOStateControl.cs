using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.MemoryAccess;
using UnderAutomation.Fanuc.MemoryAccess.Diagnosis;
using UnderAutomation.Fanuc.MemoryAccess.Internal;

public partial class IOStateControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public IOStateControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            "iostate.dg",
            FanucFileReaders.IOStateReader,
            () => _robot.MemoryAccess.GetIOState(),
            Show);
    }

    #region IUserControl
    public string Title => "IO State";

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
