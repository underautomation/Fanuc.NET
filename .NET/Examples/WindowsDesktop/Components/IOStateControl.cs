using Equin.ApplicationFramework;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.MemoryAccess;
using UnderAutomation.Fanuc.MemoryAccess.Diagnosis;
using UnderAutomation.Fanuc.MemoryAccess.Internal;

public partial class IOStateControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public IOStateControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        var grouper = new Subro.Controls.DataGridViewGrouper(grid);
        grouper.Options.StartCollapsed = true;
        grouper.SetGroupOn(PortColumn);
        grouper.DisplayGroup += Grouper_DisplayGroup;

        Header.Initialize(
            "iostate.dg",
            FanucFileReaders.IOStateReader,
            () => _robot.MemoryAccess.GetIOState(),
            Show);
    }

    private void Grouper_DisplayGroup(object sender, Subro.Controls.GroupDisplayEventArgs e)
    {
        e.BackColor = System.Drawing.Color.White;
        e.ForeColor = System.Drawing.Color.Black;
    }

    #region IUserControl
    public string Title => "IO State";

    public bool FeatureEnabled => _robot.MemoryAccess.Connected;

    public void PeriodicUpdate() { }

    public void OnClose() { }
    public void OnOpen()
    {
        if (FeatureEnabled) Header.OnOpen();
    }
    #endregion


    private void Show(IFanucContent content)
    {
        var ioState = content as IOState;

        iOStateBindingSource.DataSource = new BindingListView<IOStatus>(ioState?.States);
    }

    private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // handle click on value check box
        if (e.ColumnIndex != ValueColumn.Index || e.RowIndex <= 0 || e.RowIndex >= grid.Rows.Count) return;

        // get associated element
        var ioStatus = (grid.Rows[e.RowIndex].DataBoundItem as ObjectView<IOStatus>)?.Object;
        if (ioStatus is null) return;

       if(_robot.RemoteCommands.Connected)
        {
            //_robot.RemoteCommands.SetPort(ioStatus.Port, ioStatus.Id, !ioStatus.Value);
        }
        else
        {
            MessageBox.Show("Cannot write IO because remote command is not connected", "Write error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
