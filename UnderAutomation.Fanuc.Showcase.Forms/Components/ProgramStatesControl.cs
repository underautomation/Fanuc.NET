using System.ComponentModel;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common.Files;
using UnderAutomation.Fanuc.Common.Files.Diagnosis;

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
            _robot,
            "prgstate.dg",
            FanucFileReaders.ProgramStates,
            (client) => client.GetProgramStates(),
            Show);
    }

    #region IUserControl
    public string Title => "Program states (CGTP or FTP)";

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
        programStatesGrid.SetSelectedObject(content);
    }
}
