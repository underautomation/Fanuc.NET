using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Ftp;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Ftp.Internal;

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
            "curpos.dg",
            FanucFileReaders.CurrentPositionReader,
            () => _robot.Ftp.GetCurrentPosition(),
            Show);
    }

    #region IUserControl
    public string Title => "Current position";

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
        positionGrid.SetSelectedObject(content);
    }
}
