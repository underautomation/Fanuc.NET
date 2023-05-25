﻿using System;
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

        var parameters = Config.Current.ConnectParameters ?? new ConnectParameters();

        // Use stored information or set to default
        txtIP.Text = parameters?.Address ?? "192.168.0.1";

        chkTelnet.Checked = parameters.TelnetKcl.Enable;
        txtTelnetKclPassword.Text = parameters.TelnetKcl.TelnetKclPassword;

        chkFtp.Checked = parameters.Ftp.Enable;
        txtFtpUser.Text = parameters.Ftp.FtpUser;
        txtFtpPassword.Text = parameters.Ftp.FtpPassword;
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
        var parameters = new ConnectParameters();
        parameters.Address = txtIP.Text;
        parameters.TelnetKcl.Enable = chkTelnet.Checked;
        parameters.TelnetKcl.TelnetKclPassword = txtTelnetKclPassword.Text;

        parameters.Ftp.Enable = chkFtp.Checked;
        parameters.Ftp.FtpUser = txtFtpUser.Text;
        parameters.Ftp.FtpPassword = txtFtpPassword.Text;

        // Store information
        Config.Current.ConnectParameters = parameters;
        Config.Save();

        // Connect to the robot
        _robot.Connect(parameters);
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _robot.Disconnect();
    }
}
