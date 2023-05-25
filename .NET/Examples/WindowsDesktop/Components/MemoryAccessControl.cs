using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.MemoryAccess.Files;

public partial class MemoryAccessControl : UserControl, IUserControl
{
    private VScrollBar _vscroll;
    FanucRobot _robot;

    static MemoryAccessControl()
    {
        TypeDescriptor.AddAttributes(typeof(object), new TypeConverterAttribute(typeof(ObjectConverter)));
    }

    public MemoryAccessControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        _vscroll = grid.Controls.OfType<Control>().FirstOrDefault(ctl => ctl.AccessibilityObject.Role == AccessibleRole.Table)?.Controls?.OfType<VScrollBar>()?.FirstOrDefault();

        Init();


    }

    public class VariableFileList : IGenericVariableType
    {
        public GenericVariable[] Variables { get; set; }

        public string Name { get; set; }

        public IGenericVariableType Parent { get; set; }

        IGenericVariableType[] IGenericVariableType.Fields => Variables;
    }

    public void Init()
    {
        // var errall = FanucFileReaders.ErrorListReader.ReadFile(@"D:\System\UA\FanucDev\Fanuc\MemoryAccess\Tests\ERRALL.LS");

        //   var summary = FanucFileReaders.SummaryDiagnosticReader.ReadFile(@"D:\System\UA\FanucDev\Fanuc\MemoryAccess\Tests\SUMMARY.DG");

        var variableFileList = new VariableFileList() { Name = "All files" };

        var variables = new List<GenericVariableFile>();
        foreach (var file in Directory.GetFiles(@"D:\System\UA\FanucDev\Fanuc\MemoryAccess\Tests\", "*.va"))
        {
            var fileContent = FanucFileReaders.VariableReader.ReadFile(file);
            fileContent.SetParent(variableFileList);
            variables.Add(fileContent);
        }


        //*var synosave =  FanucFileReaders.VariableReader.ReadFile(@"D:\System\UA\FanucDev\Fanuc\MemoryAccess\Tests\system.va");

        variableFileList.Variables = variables.SelectMany(x => x.Variables).OrderBy(x => x.Name).ToArray();

        variableTable.Show(variableFileList);
    }




    #region IUserControl
    public string Title => "Memory access";

    public bool FeatureEnabled => _robot.MemoryAccess.Connected;

    public void PeriodicUpdate()
    {
    }

    public void OnClose()
    {
    }

    public void OnOpen()
    {
    }
    #endregion


}

