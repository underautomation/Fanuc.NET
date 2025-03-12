using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Ftp;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Ftp.Internal;

public partial class ProgramStatesControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public ProgramStatesControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(TaskState), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(TaskHistoryData), new TypeConverterAttribute(typeof(ObjectConverter)));

        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            "prgstate.dg",
            FanucFileReaders.ProgramStates,
            () => _robot.Ftp.GetProgramStates(),
            Show);
    }

    #region IUserControl
    public string Title => "Program states";

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
        programStatesGrid.SetSelectedObject(content );
    }
}
