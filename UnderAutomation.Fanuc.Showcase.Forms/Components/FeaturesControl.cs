using System.ComponentModel;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common.Files;
using UnderAutomation.Fanuc.Common.Files.Diagnosis;

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
            _robot,
            "summary.dg",
            FanucFileReaders.SummaryDiagnosticReader,
            (client) => client.GetSummaryDiagnostic(),
            Show);
    }

    #region IUserControl
    public string Title => "Features / Order No (CGTP or FTP)";

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
        gridErrorList.SetSelectedObject((content as SummaryDiagnosis)?.Features);
    }
}
