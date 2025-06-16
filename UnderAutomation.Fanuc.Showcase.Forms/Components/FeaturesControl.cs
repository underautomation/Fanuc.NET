using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Ftp;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Ftp.Internal;
using UnderAutomation.Fanuc.Ftp.List;

public partial class FeaturesControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public FeaturesControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(Features), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(Feature), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(Feature), new ReadOnlyAttribute(true));

        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            "summary.dg",
            FanucFileReaders.SummaryDiagnosticReader,
            () => _robot.Ftp.GetSummaryDiagnostic(),
            Show);
    }

    #region IUserControl
    public string Title => "Features / Order No";

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
        gridErrorList.SetSelectedObject((content as SummaryDiagnosis)?.Features );
    }
}
