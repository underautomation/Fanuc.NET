using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UnderAutomation.Fanuc.MemoryAccess;
using UnderAutomation.Fanuc.MemoryAccess.Diagnosis;
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

        public void Initialize(string fileName , IFileReader<IFanucContent> reader, Func<IFanucContent> readOnRobot, Action<IFanucContent> onNewValue) 
        {
            dlgOpen.Filter = $"{fileName}|{fileName}| All files|*.*";
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
;
            }
        }
    }
}
