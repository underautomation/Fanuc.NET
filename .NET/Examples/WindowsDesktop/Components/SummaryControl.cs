using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Ftp.Files;
using UnderAutomation.UniversalRobots.License;

public partial class SummaryControl : UserControl, IUserControl
{
    FanucRobot _robot;

    public SummaryControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        grid.SelectedObject = new SummaryFile();
    }

    #region IUserControl
    public string Title => "Summary";

    public bool FeatureEnabled =>_robot.Ftp.Connected;

    public void PeriodicUpdate() 
    {
       
    }

    public void OnClose() { }

    public void OnOpen() {
        if (!_robot.Ftp.Connected) return;

        UpdateFile();

        grid.ExpandAllGridItems();
   }
    #endregion

    private void UpdateFile()
    {
        grid.SelectedObject= _robot.Ftp.KnownFiles.Diagnostic.ReadSummary();
    }

}
