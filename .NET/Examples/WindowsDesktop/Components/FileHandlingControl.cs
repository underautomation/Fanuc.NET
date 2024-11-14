using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.MemoryAccess;

public partial class FileHandlingControl : UserControl, IUserControl
{
    private FanucRobot _robot;

    public FileHandlingControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(FtpListItem), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(FtpListItem), new ReadOnlyAttribute(true));

        _robot = robot;
        InitializeComponent();
    }

    #region IUserControl
    public string Title => "File handling";

    public bool FeatureEnabled => _robot.MemoryAccess.Connected;

    public void PeriodicUpdate()
    {
        this.Enabled = FeatureEnabled;
    }


    public void OnClose()
    {
        Config.Current.FtpPath = txtPath.Text;
        Config.Save();

        lstFolder.Items.Clear();
        gridFile.SelectedObject = null;
    }

    public void OnOpen()
    {
        try
        {
            InitializeFtp();
        }
        catch
        {
            Config.Current.FtpPath = "/";
            InitializeFtp();
        }
    }
    #endregion

    public void InitializeFtp()
    {
        FillList(Config.Current.FtpPath ?? "/");
    }

    // Display directory content in the list view
    private void FillList(string path)
    {
        gridFile.SelectedObject = null;
        lstFolder.Items.Clear();

        if (!_robot.MemoryAccess.Connected) return;

        path = path.Replace(@"\", "/");
        if (!path.EndsWith("/"))
            path = path + "/";

        txtPath.Text = path;

        var files = _robot.MemoryAccess.DirectFileHandling.GetListing(path);

        foreach (var file in files)
        {
            // do not display special folders
            // if (file.Name == "." || file.Name == "..") continue;

            var itm = lstFolder.Items.Add(file.Name);

            itm.Tag = file;

            if (file.Type == FtpFileSystemObjectType.Directory)
                itm.ImageKey = "folder";
            else if (file.Type == FtpFileSystemObjectType.Link)
                itm.ImageKey = "symbolicLink";
            else
                itm.ImageKey = "file";
        }
    }

    // Open directory after double click
    private void lstFolder_ItemActivate(object sender, EventArgs e)
    {
        var file = lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as FtpListItem;

        if (file == null || (file.Type != FtpFileSystemObjectType.Directory && file.Type != FtpFileSystemObjectType.Link)) return;

        if (file.Type == FtpFileSystemObjectType.Link)
        {
            try
            {
                // var value = _robot.Ftp.Download(.ReadAllText(file.FullName);

                MessageBox.Show(file.FullName);
            }
            catch
            {
                FillList(file.FullName);
            }
        }
        else
        {
            FillList(file.FullName);
        }
    }

    // Show select item data inside right grid
    private void lstFolder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        gridFile.SelectedObject = e.Item?.Tag;
    }
    private void lstFolder_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstFolder.SelectedItems.Count == 0) gridFile.SelectedObject = null;
    }

    // Navigate to parent directory
    private void btnPrevious_Click(object sender, EventArgs e)
    {
        var p = GetPath().TrimEnd('/');
        if (p == "") return;
        FillList(Path.GetDirectoryName(p));
    }

    // Refresh current directory
    private void btnOpenPath_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        ReloadList();
    }
    private void ReloadList()
    {
        FillList(GetPath());
        gridFile.SelectedObject = null;
    }

    // Delete an element
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you really want to delete selected item ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        if (!_robot.MemoryAccess.Connected) return;

        foreach (var itm in lstFolder.SelectedItems.OfType<ListViewItem>())
        {
            var file = itm.Tag as FtpListItem;

            if (file == null) return;

            if (file.Type == FtpFileSystemObjectType.File)
            {
                _robot.MemoryAccess.DirectFileHandling.DeleteFile(file.FullName);
            }
            else
            {
                _robot.MemoryAccess.DirectFileHandling.DeleteDirectory(file.FullName);
            }
            Thread.Sleep(500);
            ReloadList();
        }
    }

    // Edit item to rename element
    private void btnRename_Click(object sender, EventArgs e)
    {
        lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.BeginEdit();
    }

    // Send file to the robot and refresh list
    private void btnUpload_Click(object sender, EventArgs e)
    {
        if (!_robot.MemoryAccess.Connected) return;

        if (dlgOpen.ShowDialog() != DialogResult.OK) return;

        using (var selectedFile = File.OpenRead(dlgOpen.FileName))
        {
            _robot.MemoryAccess.DirectFileHandling.UploadFileToController(selectedFile, GetPath() + Path.GetFileName(dlgOpen.FileName).Replace(@"\", "/"));
        }

        Thread.Sleep(500);
        ReloadList();
        SelectFile(Path.GetFileName(dlgOpen.FileName));
    }

    // Get current directory path
    private string GetPath()
    {
        if (!txtPath.Text.EndsWith("/")) return txtPath.Text + "/";
        return txtPath.Text;
    }

    // Select a file in list view by its name
    private void SelectFile(string name)
    {
        var itm = lstFolder.Items.OfType<ListViewItem>().FirstOrDefault(x => string.Equals(x.Text, name, StringComparison.InvariantCultureIgnoreCase));
        if (itm != null) itm.Selected = true;
    }

    // Save remote file to local computer
    private void btnDownload_Click(object sender, EventArgs e)
    {
        if (!_robot.MemoryAccess.Connected) return;

        var file = lstFolder.SelectedItems.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as FtpListItem;

        if (file == null) return;

        dlgSave.FileName = Path.GetFileName(file.FullName).Replace(@"\", "/");

        if (dlgSave.ShowDialog() != DialogResult.OK) return;

        _robot.MemoryAccess.DirectFileHandling.DownloadFileFromController(dlgSave.FileName, file.FullName);

        Explorer.RevealFile(dlgSave.FileName);
    }


    // Perform renaming or directory creation
    private void lstFolder_AfterLabelEdit(object sender, LabelEditEventArgs e)
    {
        if (!_robot.MemoryAccess.Connected) return;

        try
        {
            if (lstFolder.Items[e.Item].Tag is null)
            {
                // if it is a directory creation
                _robot.MemoryAccess.DirectFileHandling.CreateDirectory(txtPath.Text + e.Label);
            }
        }
        finally
        {
            e.CancelEdit = true;
            Thread.Sleep(500);
            ReloadList();
            SelectFile(e.Label);
        }
    }


    private void btnNewFolder_Click(object sender, EventArgs e)
    {
        if (!_robot.MemoryAccess.Connected) return;
        lstFolder.Items.Add("new directory", "folder").BeginEdit();
    }


    private void gridFile_SelectedObjectsChanged(object sender, EventArgs e)
    {
        var selected = gridFile.SelectedObject as FtpListItem;

        btnDownload.Enabled = selected is object && selected.Type == FtpFileSystemObjectType.File;
        btnDelete.Enabled = selected is object;
    }

}
