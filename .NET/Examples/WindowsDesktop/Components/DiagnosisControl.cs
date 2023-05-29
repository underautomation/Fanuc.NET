using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.MemoryAccess;
using UnderAutomation.Fanuc.MemoryAccess.Diagnosis;
using UnderAutomation.Fanuc.MemoryAccess.Internal;

public partial class DiagnosisControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public DiagnosisControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        Header.Initialize(
            "summary.dg",
            FanucFileReaders.SummaryDiagnosticReader,
            () => _robot.MemoryAccess.GetSummaryDiagnostic(),
            Show);
    }

    #region IUserControl
    public string Title => "Diagnosis";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion


    private void Show(IFanucContent content)
    {
        var summaryDiagnosis = content as SummaryDiagnosis;
        positionGrid.SetSelectedObject(summaryDiagnosis?.CurrentPosition);
        //IOStatusGrid.SetSelectedObject(summaryDiagnosis?.IOs);
        SafetyGrid.SetSelectedObject(summaryDiagnosis?.Safety);
    }
}
