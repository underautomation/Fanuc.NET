using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;

public partial class MainForm : Form
{
    // Fanuc instance that handles connection to the robot
    private readonly FanucRobot _robot = new FanucRobot();

    private static MainForm Instance;

    #region Initialisation
    public MainForm()
    {
        Instance = this;

        // Catch all unhandled exceptions
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        Application.ThreadException += Application_ThreadException;

        Control.CheckForIllegalCrossThreadCalls = false;

        // Load configuration file
        Config.Load();

        InitializeComponent();

        // Add nodes in left menu and instanciate associated control 
        AddNode(new ConnectControl(_robot));
        AddNode(new TelnetControl(_robot));
        AddNode(new VariablesControl(_robot));
        AddNode(new CurrentPositionControl(_robot));
        AddNode(new IOStateControl(_robot));
        AddNode(new SafetyStatusControl(_robot));
        AddNode(new ProgramStatesControl(_robot));
        AddNode(new ErrorListControl(_robot));
        AddNode(new FileHandlingControl(_robot));
        AddNode(new MoveRobotControl(_robot));
        AddNode(new TPEditorControl(_robot));
        AddNode(new DpmControl(_robot));
        AddNode(new SnpxControl(_robot));
        AddNode(new ContactControl());
        AddNode(new LicenseControl());

        // Select first node at startup
        SelectNode(leftTreeView.Nodes[0]);
        
        _robot.Telnet.CommandSent += TelnetKcl_CommandSent;
        _robot.Telnet.TpCoordinatesReceived += TelnetKcl_CoordReceived;
        _robot.Telnet.ErrorOccured += TelnetKcl_ErrorOccured;
        _robot.Telnet.MessageReceived += TelnetKcl_MessageReceived;
        _robot.Telnet.RawDataReceived += TelnetKcl_RawDataReceived;
    }

    private void TelnetKcl_RawDataReceived(object sender, UnderAutomation.Fanuc.Telnet.RawDataReceivedEventArgs e)
    {
        Logger.Log($"Telnet KCL {nameof(_robot.Telnet.RawDataReceived)}", e.Data);
    }

    private void TelnetKcl_MessageReceived(object sender, UnderAutomation.Fanuc.Telnet.MessageReceivedEventArgs e)
    {
        Logger.Log($"Telnet KCL {nameof(_robot.Telnet.MessageReceived)}", e.Message);
    }

    private void TelnetKcl_ErrorOccured(object sender, UnderAutomation.Fanuc.Telnet.KclClientErrorEventArgs e)
    {
        Logger.Log($"Telnet KCL {nameof(_robot.Telnet.ErrorOccured)}", e.Exception?.ToString());
    }

    private void TelnetKcl_CoordReceived(object sender, UnderAutomation.Fanuc.Telnet.TpCoordinatesReceivedEventArgs e)
    {
        Logger.Log($"Telnet KCL {nameof(_robot.Telnet.TpCoordinatesReceived)}", e.Coord.ToString());
    }

    private void TelnetKcl_CommandSent(object sender, UnderAutomation.Fanuc.Telnet.CommandSentEventArgs e)
    {
        Logger.Log($"Telnet KCL {nameof(_robot.Telnet.CommandSent)}", e.Command);
    }

    private void AddNode(IUserControl control)
    {
        var node = leftTreeView.Nodes.Add(control.Title);
        node.Tag = control;
    }
    #endregion

    #region Unhandled exception
    private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
        CatchApplicationException(e.Exception);
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        CatchApplicationException(e.ExceptionObject as Exception);
    }

    private void CatchApplicationException(Exception e)
    {
        try
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => CatchApplicationException(e)));
                return;
            }

            Logger.Log("ApplicationException", e.ToString());

            if (MessageBox.Show($"{e?.Message}\r\n\r\nWould you like to report this error?", "An error occurred", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                SelectNode<ContactControl>()?.SetMessage($@"Hi,

I have this exception that prevents me from using the full capabilities of the SDK. Could you take a look at it and help me out?

{e}");
            }
        }
        catch { }
    }
    #endregion

    #region User interaction
    private void leftTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        SelectNode(e.Node);
    }

    internal T SelectNode<T>() where T : class, IUserControl
    {
        var node = Instance.leftTreeView.Nodes.OfType<TreeNode>().FirstOrDefault(n => n.Tag is T);
        var control = node?.Tag as T;
        SelectNode(node);
        return control;
    }

    // Open right control associated to a node
    internal void SelectNode(TreeNode node)
    {
        if (leftTreeView.SelectedNode != node) leftTreeView.SelectedNode = node;

        if (node is null) return;

        mainPanel.SuspendLayout();

        mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.OnClose();

        mainPanel.Controls.Clear();

        var control = node.Tag as Control;

        if (control is null)
        {
            panelTitle.Text = "";
            return;
        }

        panelTitle.Text = (node.Tag as IUserControl)?.Title;

        mainPanel.Controls.Add(control);

        control.Dock = DockStyle.Fill;

        mainPanel.ResumeLayout();

        try
        {
            Cursor = Cursors.WaitCursor;
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.OnOpen();
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.PeriodicUpdate();
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    // Open browser to documentation page
    private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            var ps = new ProcessStartInfo("https://underautomation.com/fanuc")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        catch { }
    }
    #endregion

    // Timer callback to refresh the control on the right and the left menu
    private void tmrPeriodicUpdate_Tick(object sender, EventArgs e)
    {
        try
        {
            // refresh control on the right
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.PeriodicUpdate();
        }
        catch { }

        try
        {
            // Refresh left menu icons and colors
            foreach (TreeNode node in leftTreeView.Nodes)
            {
                try
                {
                    var ctrl = node?.Tag as IUserControl;
                    if (ctrl == null) continue;

                    var enabled = ctrl.FeatureEnabled;

                    var key = enabled ? "ON" : "OFF";

                    if (key != node.ImageKey)
                    {
                        node.ImageKey = key;
                        node.SelectedImageKey = key;
                        node.ForeColor = enabled ? Color.Green : Color.DarkGray;
                    }
                }
                catch { }
            }
        }
        catch { }
    }



    private void titlePictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        ScreenshotsGenerator.Generate(this);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            _robot.Disconnect();
        }
        catch { }
    }
}