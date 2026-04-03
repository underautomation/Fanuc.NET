using System.Diagnostics;
using UnderAutomation.Fanuc.Common.Files;

namespace UnderAutomation.Fanuc.Showcase.Forms.Components
{
    public partial class HeaderFileControl : UserControl
    {
        private const int PROTOCOL_CGTP = 0;
        private const int PROTOCOL_FTP = 1;

        public HeaderFileControl()
        {
            InitializeComponent();
            tsProtocol.SelectedIndex = PROTOCOL_CGTP;
        }

        private IFileReader<IFanucContent> _reader;
        private Func<FileClientBase, IFanucContent> _readOnRobot;
        private Action<IFanucContent> _onNewValue;

        private FanucRobot _robot;

        public void Initialize(FanucRobot robot, string fileName, IFileReader<IFanucContent> reader, Func<FileClientBase, IFanucContent> readOnRobot, Action<IFanucContent> onNewValue)
        {
            _robot = robot;
            dlgOpen.Filter = $"{fileName}|{fileName}|All files|*.*";
            _reader = reader;
            _readOnRobot = readOnRobot;
            _onNewValue = onNewValue;

        }

        internal void OnOpen()
        {
            if (_robot.Ftp.Connected && !_robot.Cgtp.Enabled)
                tsProtocol.SelectedIndex = PROTOCOL_FTP;
            else if (_robot.Cgtp.Enabled && !_robot.Ftp.Connected)
                tsProtocol.SelectedIndex = PROTOCOL_CGTP;

            RefreshFromRobot();
        }

        private void tsBrowse_Click(object sender, System.EventArgs e)
        {
            dlgOpen.InitialDirectory = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "Files");

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                var sw = Stopwatch.StartNew();
                var content = _reader.ReadFile(dlgOpen.FileName, ConnectControl.GetSelectedLanguage());
                sw.Stop();
                _onNewValue(content);
                lblStatus.Text = $"{dlgOpen.FileName} ({sw.ElapsedMilliseconds}ms)";
            }
        }

        private void tsRefresh_Click(object sender, EventArgs e) => RefreshFromRobot();


        private void RefreshFromRobot()
        {
            if(_robot == null) return;
            var sw = Stopwatch.StartNew();
            FileClientBase fileClient = tsProtocol.SelectedIndex == PROTOCOL_CGTP ? _robot.Cgtp.Http : _robot.Ftp;
            var content = _readOnRobot(fileClient);
            sw.Stop();
            var ms = sw.ElapsedMilliseconds;
            lblStatus.Text = $"Time taken to read data from robot : {ms}ms";
            _onNewValue(content);
        }

        private void tsProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFromRobot();
        }
    }
}
