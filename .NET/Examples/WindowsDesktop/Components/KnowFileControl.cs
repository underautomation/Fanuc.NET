using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Ftp.Files;

public partial class KnowFileControl : UserControl, IUserControl
{
    private VScrollBar _vscroll;
    FanucRobot _robot;

    static KnowFileControl()
    {
        TypeDescriptor.AddAttributes(typeof(SummaryFile), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(object), new TypeConverterAttribute(typeof(ObjectConverter)));
    }

    public KnowFileControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        grid.SelectedObject = new SummaryFile();
        _vscroll = grid.Controls.OfType<Control>().FirstOrDefault(ctl => ctl.AccessibilityObject.Role == AccessibleRole.Table)?.Controls?.OfType<VScrollBar>()?.FirstOrDefault();
    }

    #region IUserControl
    public string Title => "Summary";

    public bool FeatureEnabled => _robot.Ftp.Connected;

    public void PeriodicUpdate()
    {
        btnPlay.Enabled = !bw.IsBusy;
        btnPause.Enabled = bw.IsBusy;
    }

    public void OnClose()
    {
        Pause();
    }

    public void OnOpen()
    {
        if (!_robot.Ftp.Connected) return;
        Play();
    }
    #endregion


    private void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        while (!bw.CancellationPending)
        {
            bw.ReportProgress(0, null);

            var file = _robot.Ftp.KnownFiles.Diagnostic.ReadSummary();

            bw.ReportProgress(0, file);

            System.Threading.Thread.Sleep(1000);
        }
    }

    private void bw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        lblRefreshing.Visible = false;
        if (e.Error is object)
        {
            throw e.Error;
        }
    }

    private void btnPlay_Click(object sender, System.EventArgs e)
    {
        Play();
    }

    private void btnPause_Click(object sender, System.EventArgs e)
    {
        Pause();
    }

    private void Play()
    {
        if (bw.IsBusy) return;
        bw.RunWorkerAsync();
    }

    private void Pause()
    {
        bw.CancelAsync();
    }

    private void bw_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        if (e.UserState is null)
        {
            lblRefreshing.Visible = true;
        }
        else
        {
            lblRefreshing.Visible = false;

            // conserve scroll bar position after a refresh
            var vScrollValue = _vscroll?.Value;

            grid.SelectedObject = e.UserState;
            grid.ExpandAllGridItems();

            if (_vscroll != null)
                _vscroll.Value = vScrollValue ?? 0;
        }
    }
}
