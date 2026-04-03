using System.ComponentModel;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Common.Files;
using UnderAutomation.Fanuc.Common.Files.Diagnosis;

public partial class CurrentPositionControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public CurrentPositionControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(GroupPosition), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(JointsPosition), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(CartesianPositionWithUserFrame), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(CartesianPositionWithTool), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(IFanucContent), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(IFanucContent), new ReadOnlyAttribute(true));

        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            _robot,
            "curpos.dg",
            FanucFileReaders.CurrentPositionReader,
            (client) => client.GetCurrentPosition(),
            Show);
    }

    #region IUserControl
    public string Title => "Current position (CGTP or FTP)";

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
        positionGrid.SetSelectedObject(content);
    }
}
