using System.Diagnostics;
using System.Globalization;
using System.Text;
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
        UpdateProgramText();
    }
    #endregion

    private void UpdateProgramText()
    {
        var now = DateTime.Now;

        var pos = _robot.Snpx.CurrentPosition.ReadWorldPosition();
        pos.CartesianPosition.Configuration.ArmLeftRight = UnderAutomation.Fanuc.Common.ArmLeftRight.Unknown;


        txtPrg.Text =$@"/PROG DPM_MOUSE
/ATTR
OWNER		= MNEDITOR;
COMMENT		= """";
PROG_SIZE	= 542;
CREATE		= DATE {now.ToString("yy-MM-dd")}  TIME {now.ToString("hh:mm:ss")};
MODIFIED	= DATE {now.ToString("yy-MM-dd")}  TIME {now.ToString("hh:mm:ss")};
FILE_NAME	= ;
VERSION		= 0;
LINE_COUNT	= 1;
MEMORY_SIZE	= 1030;
PROTECT		= READ_WRITE;
TCD:  STACK_SIZE	= 0,
      TASK_PRIORITY	= 50,
      TIME_SLICE	= 0,
      BUSY_LAMP_OFF	= 0,
      ABORT_REQUEST	= 0,
      PAUSE_REQUEST	= 0;
DEFAULT_GROUP	= 1,*,*,*,*;
CONTROL_CODE	= 00000000 00000000;
/MN
   1:J P[1] 80% FINE    ;
   2:  Track DPM[1] ;
   3:L P[2] 100mm/sec FINE    ;
   4:  Track End ;
   5:L P[2] 100mm/sec FINE    ;
/POS
P[1]{{GP1:
	UF : 0, UT : {pos.UserTool},		CONFIG : '{pos.CartesianPosition.Configuration.ToString()}',
	X =  {pos.CartesianPosition.X.ToString("0.000", CultureInfo.InvariantCulture)}  mm,	Y =     {pos.CartesianPosition.Y.ToString("0.000", CultureInfo.InvariantCulture)}  mm,	Z =   {pos.CartesianPosition.Z.ToString("0.000", CultureInfo.InvariantCulture)}  mm,
	W =      {pos.CartesianPosition.W.ToString("0.000", CultureInfo.InvariantCulture)} deg,	P =      {pos.CartesianPosition.P.ToString("0.000", CultureInfo.InvariantCulture)} deg,	R =     {pos.CartesianPosition.R.ToString("0.000", CultureInfo.InvariantCulture)} deg
}};
P[2]{{GP1:
	UF : 0, UT : {pos.UserTool},		CONFIG : '{pos.CartesianPosition.Configuration.ToString()}',
	X =  {pos.CartesianPosition.X.ToString("0.000", CultureInfo.InvariantCulture)}  mm,	Y =     {pos.CartesianPosition.Y.ToString("0.000", CultureInfo.InvariantCulture)}  mm,	Z =   {(pos.CartesianPosition.Z+1).ToString("0.000", CultureInfo.InvariantCulture)}  mm,
	W =      {pos.CartesianPosition.W.ToString("0.000", CultureInfo.InvariantCulture)} deg,	P =      {pos.CartesianPosition.P.ToString("0.000", CultureInfo.InvariantCulture)} deg,	R =     {pos.CartesianPosition.R.ToString("0.000", CultureInfo.InvariantCulture)} deg
}};
/END
";

    }

    private void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        while (!bw.CancellationPending)
        {
            try
            {
                if (Joystick.GetXYZ(out var x, out var y, out var z))
                {
                    if (x != 0) _robot.Snpx.IntegerSystemVariables.Write("$DPM_SCH[1].$GRP[1].$OFS[1].$INI_OFS", Math.Sign(x) + (int)(x * 5));
                    if (y != 0) _robot.Snpx.IntegerSystemVariables.Write("$DPM_SCH[1].$GRP[1].$OFS[2].$INI_OFS", Math.Sign(y) + (int)(y * 5));
                    if (z != 0) _robot.Snpx.IntegerSystemVariables.Write("$DPM_SCH[1].$GRP[1].$OFS[3].$INI_OFS", Math.Sign(z) + (int)(z * 5));
                }
                Thread.Sleep(100);
            }
            catch { }
        }
        e.Cancel = true;
    }

    private void lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            var ps = new ProcessStartInfo("https://underautomation.com/fanuc/documentation/move-robot-with-mouse")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        catch { }
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        _robot.Ftp.DirectFileHandling.UploadFileToController(Encoding.ASCII.GetBytes(txtPrg.Text), $"/md:/DPM_MOUSE.ls");
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        _robot.Telnet.Run("DPM_MOUSE");
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        _robot.Telnet.Abort("DPM_MOUSE");
    }
}
