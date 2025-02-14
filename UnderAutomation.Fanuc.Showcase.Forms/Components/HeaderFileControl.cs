using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Fanuc.Ftp.Internal;

namespace UnderAutomation.Fanuc.Showcase.Forms.Components
{
    public partial class HeaderFileControl : UserControl
    {
        public HeaderFileControl()
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

        internal void OnOpen() => RefreshFromRobot();

        private void tsBrowse_Click(object sender, System.EventArgs e)
        {
            dlgOpen.InitialDirectory = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "Files");

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                var sw = Stopwatch.StartNew();
                var content = _reader.ReadFile(dlgOpen.FileName);
                sw.Stop();
                _onNewValue(content);
                lblStatus.Text = $"{dlgOpen.FileName} ({ sw.ElapsedMilliseconds}ms)";
            }
        }

        private void tsRefresh_Click(object sender, EventArgs e) => RefreshFromRobot();
        

        private void RefreshFromRobot()
        {
            var sw = Stopwatch.StartNew();
            var content  = _readOnRobot();
            sw.Stop();
            var ms = sw.ElapsedMilliseconds;
            lblStatus.Text = $"Time taken to read data from robot : {ms}ms";
            _onNewValue(content);
        }
    }
}
