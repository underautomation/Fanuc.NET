using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Fanuc.MemoryAccess.Internal;

namespace UnderAutomation.Fanuc.Sample.WindowsDesktop.Components
{
    public partial class CyclicReadingFileControl : UserControl
    {
        public CyclicReadingFileControl()
        {
            InitializeComponent();
        }

        private IFileReader<IFanucContent> _reader;
        private Func<IFanucContent> _readOnRobot;
        private Action<IFanucContent> _onNewValue;

        public void Initialize(string fileName, IFileReader<IFanucContent> reader, Func<IFanucContent> readOnRobot, Action<IFanucContent> onNewValue)
        {
            dlgOpen.Filter = $"{fileName}|{fileName}|All files|*.*";
            _reader = reader;
            _readOnRobot = readOnRobot;
            _onNewValue = onNewValue;
        }


        private void tsBrowse_Click(object sender, System.EventArgs e)
        {
            dlgOpen.InitialDirectory = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location), "Files");

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                var sw = Stopwatch.StartNew();
                var content = _reader.ReadFile(dlgOpen.FileName);
                sw.Stop();
                _onNewValue(content);
                lblStatus.Text = $"{dlgOpen.FileName} ({ sw.ElapsedMilliseconds}ms)";
            }
        }

        private class State
        {
            public IFanucContent Content;
            public long ElapsedMilliseconds;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!e.Cancel)
            {
                var state = new State();
                var sw = Stopwatch.StartNew();
                state.Content = _readOnRobot();
                sw.Stop();
                state.ElapsedMilliseconds = sw.ElapsedMilliseconds;
                bw.ReportProgress(0, state);
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var state = e.UserState as State;

            if (state is null) return;

            lblStatus.Text = $"{ state.ElapsedMilliseconds}ms)";
            _onNewValue(state.Content);
        }

        private void tsStart_Click(object sender, EventArgs e)
        {

        }

        private void tsStop_Click(object sender, EventArgs e)
        {

        }
    }
}
