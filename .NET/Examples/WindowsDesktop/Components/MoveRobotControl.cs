using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Ftp.Internal;

public partial class MoveRobotControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public MoveRobotControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(GroupPosition), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(JointsPosition), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(CartesianPositionWithUserFrame), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(CartesianPositionWithTool), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(Configuration), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(IFanucContent), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(IFanucContent), new ReadOnlyAttribute(true));

        _robot = robot;
        InitializeComponent();

    }

    #region IUserControl
    public string Title => "Move robot (FTP+TELNET)";

    public bool FeatureEnabled => _robot.Ftp.Connected && _robot.Telnet.Connected;

    public void PeriodicUpdate()
    {


    }

    public void OnClose() { }

    public void OnOpen()
    {
        if (!_robot.Ftp.Connected) return;
        var currentPosition = _robot.Ftp.GetCurrentPosition();

        currentWorldPositionGrid.SetSelectedObject(currentPosition.GroupsPosition[0].WorldPositions[0]);

        if (targetWorldPositionGrid.SelectedObject is null) targetWorldPositionGrid.SetSelectedObject(currentWorldPositionGrid.SelectedObject);

    }
    #endregion


    private void Show(IFanucContent content)
    {
        currentWorldPositionGrid.SetSelectedObject(content);
    }

    private void btnCopyWorldPosition_Click(object sender, System.EventArgs e)
    {
        targetWorldPositionGrid.SetSelectedObject(currentWorldPositionGrid.SelectedObject);
    }

    private int fileNumber = 0;
    private void btnMoveWorldPosition_Click(object sender, System.EventArgs e)
    {
        var pos = targetWorldPositionGrid.SelectedObject as CartesianPositionWithTool;

        if (pos is null) return;

        var prgName = $"MOVE{fileNumber}";
        var fileName = $"{prgName.ToLower()}.LS";

        var now = DateTime.Now;
        var prg = $@"/PROG  {prgName}
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
   1:J P[1] 100% FINE    ;
/POS
P[1]{{GP1:
	UF : 0, UT : {pos.Tool},		CONFIG : '{pos.Configuration.ToString()}',
	X =  {pos.X.ToString("0.000", CultureInfo.InvariantCulture)}  mm,	Y =     {pos.Y.ToString("0.000", CultureInfo.InvariantCulture)}  mm,	Z =   {pos.Z.ToString("0.000", CultureInfo.InvariantCulture)}  mm,
	W =      {pos.W.ToString("0.000", CultureInfo.InvariantCulture)} deg,	P =      {pos.P.ToString("0.000", CultureInfo.InvariantCulture)} deg,	R =     {pos.R.ToString("0.000", CultureInfo.InvariantCulture)} deg
}};
/END
";

        txtProgram.Text = prg;
        lblPrgName.Text = fileName;

        try
        {
            _robot.Ftp.DirectFileHandling.UploadFileToController(Encoding.UTF8.GetBytes(prg), "/md:/" + fileName);
        }
        catch(Exception ex)
        {
            MessageBox.Show($"{ex.Message}\r\nNext try will use a different file name.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            fileNumber++;
            fileNumber = fileNumber % 2;
            return;

        }

        _robot.Telnet.Run(prgName);
    }

    private void btnRefreshWorldPosition_Click(object sender, EventArgs e)
    {
        OnOpen();
    }
}
