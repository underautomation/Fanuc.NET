using UnderAutomation.Fanuc;

public partial class DpmControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public DpmControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();


    }

    #region IUserControl
    public string Title => "DPM (Mouse Control)";

    public bool FeatureEnabled => _robot.Ftp.Connected && _robot.Snpx.Connected;

    public void PeriodicUpdate() { }

    public void OnClose() { bw.CancelAsync(); }

    public void OnOpen()
    {
        bw.RunWorkerAsync();

    }
    #endregion



    private void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        while (!bw.CancellationPending)
        {
            try
            {
                if (Joystick.GetXYZ(out var x, out var y, out var z))
                {
                    if (x != 0) _robot.Snpx.IntegerSystemVariables.Write("$DPM_SCH[1].$GRP[1].$OFS[1].$INI_OFS", (int)(x*5));
                    if (y != 0) _robot.Snpx.IntegerSystemVariables.Write("$DPM_SCH[1].$GRP[1].$OFS[2].$INI_OFS", (int)(y *5));
                    if (z != 0) _robot.Snpx.IntegerSystemVariables.Write("$DPM_SCH[1].$GRP[1].$OFS[3].$INI_OFS", (int)(z *5));
                }
                Thread.Sleep(100);

            }
            catch
            {

            }
        }
        e.Cancel = true;
    }
}
