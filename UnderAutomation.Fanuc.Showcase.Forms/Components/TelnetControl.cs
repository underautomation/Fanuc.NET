using UnderAutomation.Fanuc;

public partial class TelnetControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public TelnetControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        KclControl.KclClient = robot.Telnet;
    }

    #region IUserControl
    public string Title => "Telnet";

    public bool FeatureEnabled => _robot.Telnet.PollAndGetUpdatedConnectedState();

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen()
    {

    }
    #endregion


}
