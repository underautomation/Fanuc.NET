using System;
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

        // Load configuration file
        Config.Load();

        InitializeComponent();

        // Add nodes in left menu and instanciate associated control 
        AddNode(new ConnectControl(_robot));
        AddNode(new LicenseControl());

        // Select first node at startup
        SelectNode(leftTreeView.Nodes[0]);
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
        if (this.InvokeRequired)
        {
            this.Invoke(new Action(() => CatchApplicationException(e)));
            return;
        }

        MessageBox.Show(e?.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    #endregion

    #region User interaction
    private void leftTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        SelectNode(e.Node);
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
        System.Diagnostics.Process.Start("https://underautomation.com/Fanuc/documentation?f");
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
}