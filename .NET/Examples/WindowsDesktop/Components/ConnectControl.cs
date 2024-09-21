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

        var parameters = Config.Current.ConnectParameters ?? new ConnectionParameters();

        // Use stored information or set to default
        txtIP.Text = parameters?.Address ?? "192.168.0.1";

        chkTelnet.Checked = parameters.RemoteCommands.Enable;
        txtTelnetKclPassword.Text = parameters.RemoteCommands.TelnetKclPassword;

        chkFtp.Checked = parameters.MemoryAccess.Enable;
        txtFtpUser.Text = parameters.MemoryAccess.FtpUser;
        txtFtpPassword.Text = parameters.MemoryAccess.FtpPassword;
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
        parameters.RemoteCommands.Enable = chkTelnet.Checked;
        parameters.RemoteCommands.TelnetKclPassword = txtTelnetKclPassword.Text;

        parameters.MemoryAccess.Enable = chkFtp.Checked;
        parameters.MemoryAccess.FtpUser = txtFtpUser.Text;
        parameters.MemoryAccess.FtpPassword = txtFtpPassword.Text;

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
