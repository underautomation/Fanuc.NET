using System;
using System.Drawing;
using System.Windows.Forms;
using UnderAutomation.Fanuc;

public partial class ConnectControl : UserControl, IUserControl
{
    FanucRobot _robot;

    public ConnectControl(FanucRobot Fanuc)
    {
        _robot = Fanuc;
        InitializeComponent();

        var parameters = Config.Current.ConnectParameters ?? new ConnectionParameters();

        // Use stored information or set to default
        txtIP.Text = parameters?.Address ?? "192.168.0.1";

        chkTelnet.Checked = parameters.Telnet.Enable;
        txtTelnetKclPassword.Text = parameters.Telnet.TelnetKclPassword;

        chkFtp.Checked = parameters.Ftp.Enable;
        txtFtpUser.Text = parameters.Ftp.FtpUser;
        txtFtpPassword.Text = parameters.Ftp.FtpPassword;

        chkSnpx.Checked = parameters.Snpx.Enable;
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.Enabled;

    public string Title => "Connection";

    public void OnClose() { }

    public void OnOpen() { }

    public void PeriodicUpdate()
    {
        var connected = FeatureEnabled;
        btnDisconnect.Enabled = connected;
        btnConnect.Text = connected ? "Reconnect" : "Connect";
        lblConnected.Text = connected ? "Connected" : "Disconnected";
        lblConnected.ForeColor = connected ? Color.Green : Color.Red;

    }
    #endregion

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        var parameters = new ConnectionParameters();
        parameters.Address = txtIP.Text;
        parameters.Telnet.Enable = chkTelnet.Checked;
        parameters.Telnet.TelnetKclPassword = txtTelnetKclPassword.Text;

        parameters.Ftp.Enable = chkFtp.Checked;
        parameters.Ftp.FtpUser = txtFtpUser.Text;
        parameters.Ftp.FtpPassword = txtFtpPassword.Text;

        parameters.Snpx.Enable = chkSnpx.Checked;

        // Store information
        Config.Current.ConnectParameters = parameters;
        Config.Save();

        if (parameters.Address == "127.0.0.1" || string.Equals(parameters.Address, "localhost", StringComparison.InvariantCultureIgnoreCase) || string.Equals(parameters.Address, "loopback", StringComparison.InvariantCultureIgnoreCase))
        {
            if (MessageBox.Show("Please enter the path to your ROBOGUIDE folder instead of the localhost IP so that the SDK can read the services.txt and connect to the correct TCP ports. Go on anyway?", "Make sure you use localhost ?", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        }

        // Connect to the robot
        _robot.Connect(parameters);
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _robot.Disconnect();
    }
}
