using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Ftp;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Ftp.Internal;
using UnderAutomation.Fanuc.Ftp.List;

public partial class ErrorListControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public ErrorListControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(ErrorList), new TypeConverterAttribute(typeof(ObjectConverter)));

        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            "errall.ls",
            FanucFileReaders.ErrorListReader,
            () => _robot.Ftp.GetAllErrorsList(),
            Show);
    }

    #region IUserControl
    public string Title => "Error list";

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
        gridErrorList.SetSelectedObject(content );
    }
}
