using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Snpx.Internal;

public partial class SnpxSignalControl : UserControl
{
    private FanucRobot _robot;


    public SnpxSignalControl()
    {
        InitializeComponent();
    }

    public void InitializeForDigitalSignal(FanucRobot robot)
    {
        _robot = robot;
        cb.Items.AddRange(_robot.Snpx.DigitalSignals.Select(x => x.SegmentName.ToString()).ToArray());
        cb.SelectedItem = cb.Items[0];
        grp.Text = "Digital signals";
    }

    public void InitializeForNumericIO(FanucRobot robot)
    {
        _robot = robot;
        cb.Items.AddRange(_robot.Snpx.NumericIOs.Select(x => x.SegmentName.ToString()).ToArray());
        cb.SelectedItem = cb.Items[0];
        grp.Text = "Numeric IOs";
    }

    private DigitalSignals SelectedDigitalSignal => _robot.Snpx.DigitalSignals.FirstOrDefault(x => string.Equals(x.SegmentName.ToString(), cb.Text));
    private NumericIO SelectedNumericIO => _robot.Snpx.NumericIOs.FirstOrDefault(x => string.Equals(x.SegmentName.ToString(), cb.Text));

    private void btnRead_Click(object sender, EventArgs e)
    {
        var index = (int)udIndex.Value;
        var count = (ushort)udCount.Value;
        pnl.Controls.Clear();

        if (SelectedDigitalSignal != null)
        {
            var values = SelectedDigitalSignal.Read(index, count);

            for (int i = 0; i < values.Length; i++)
            {
                pnl.Controls.Add(new CheckBox() {Margin = new Padding(0), Text = (index + i).ToString(), Checked = values[i] });
            }
        }
        else if (SelectedNumericIO != null)
        {
            var values = SelectedNumericIO.Read(index, count);

            for (int i = 0; i < values.Length; i++)
            {
                pnl.Controls.Add(new NumericUpDown() { Minimum = ushort.MinValue, Maximum = ushort.MaxValue, Value = values[i] });
            }
        }
    }

    private void btnWrite_Click(object sender, EventArgs e)
    {
        var index = (int)udIndex.Value;

        if (SelectedDigitalSignal != null)
        {
            bool[] values = pnl.Controls.OfType<CheckBox>().Select(x => x.Checked).ToArray();

            SelectedDigitalSignal.Write(index, values);
        }
        else if (SelectedNumericIO != null)
        {
            ushort[] values = pnl.Controls.OfType<NumericUpDown>().Select(x => (ushort)x.Value).ToArray();

            SelectedNumericIO.Write(index, values);
        }
    }
}
