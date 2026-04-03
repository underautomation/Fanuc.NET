using System.ComponentModel;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common.Files;
using UnderAutomation.Fanuc.Common.Files.List;

public partial class ErrorListControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public ErrorListControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(ErrorList), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(ErrallSectionItem), new TypeConverterAttribute(typeof(ObjectConverter)));

        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            _robot,
            "errall.ls",
            FanucFileReaders.ErrorListReader,
            (client) => client.GetAllErrorsList(),
            Show);
    }

    #region IUserControl
    public string Title => "Error list (CGTP or FTP)";

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
        gridErrorList.SetSelectedObject(content);

        gridActiveAlarms.SetSelectedObject((content as ErrorList)?.FilterActiveAlarms());
    }
}
