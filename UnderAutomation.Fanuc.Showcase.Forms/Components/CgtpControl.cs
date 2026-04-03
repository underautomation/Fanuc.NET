using System.ComponentModel;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Cgtp;
using UnderAutomation.Fanuc.Cgtp.BatchVariables;
using UnderAutomation.Fanuc.Common;

public partial class CgtpControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public CgtpControl(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(VectorVariable), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(CartesianPositionVariable), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(NumericRegisterWithComment), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(StringRegisterWithComment), new TypeConverterAttribute(typeof(ObjectConverter)));

        _robot = robot;
        InitializeComponent();

        KclControl.KclClient = robot.Cgtp.Kcl;

        cbProgramType.Items.Add(CgtpProgramSubType.None);
        cbProgramType.Items.Add(CgtpProgramSubType.Macro);

        cbNewProgramType.Items.Add(CgtpProgramSubType.None);
        cbNewProgramType.Items.Add(CgtpProgramSubType.Macro);
        cbNewProgramType.SelectedIndex = 0;

        foreach (CgtpIoPortType type in Enum.GetValues(typeof(CgtpIoPortType)))
        {
            cbIoTypes.Items.Add(type);
        }
        cbIoTypes.SelectedIndex = 1;

        gridVariableJointValue.SelectedObject = new JointPositionVariable();
        gridVariableCartesianValue.SelectedObject = new CartesianPositionVariable();

        foreach (CgtpCommentType type in Enum.GetValues(typeof(CgtpCommentType)))
        {
            cbCommentType.Items.Add(type);
        }
        cbCommentType.SelectedIndex = 1;

        InitBatchVariable();
    }

    #region IUserControl
    public string Title => "CGTP";

    public bool FeatureEnabled => _robot.Cgtp.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen()
    {

    }

    #endregion

    #region Programs

    private void btnSelectProgramLine_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SelectProgram(txtProgram.Text, (int)udProgramLine.Value);
    }

    private void btnStartProgram_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.RunProgram(txtProgram.Text, (int)udProgramLine.Value);
    }

    private void btnDeleteProgram_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show($"Are you sure you want to delete program {txtProgram.Text}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            _robot.Cgtp.DeleteProgram(txtProgram.Text);
    }

    private void btnCreateProgram_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.CreateProgram(txtNewProgramName.Text, txtNewProgramOwner.Text, txtNewProgramComment.Text, (int)udNEwProgramGroup.Value, (CgtpProgramSubType)cbNewProgramType.SelectedItem);
    }

    private void btnRenameProgram_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show($"Are you sure you want to rename program {txtProgram.Text} to {txtProgramNewName.Text}?", "Confirm Rename", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            _robot.Cgtp.RenameProgram(txtProgram.Text, txtProgramNewName.Text);
            txtProgram.Text = txtProgramNewName.Text;
        }
    }

    private void btnGetProgramComment_Click(object sender, EventArgs e)
    {
        txtProgramComment.Text = _robot.Cgtp.GetProgramComment(txtProgram.Text);
    }

    private void btnSetProgramComment_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramComment(txtProgram.Text, txtProgramComment.Text);
    }

    private void btnGetProgramStackSize_Click(object sender, EventArgs e)
    {
        udProgramStackSize.Value = _robot.Cgtp.GetProgramStackSize(txtProgram.Text);
    }

    private void btnSetProgramStackSize_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramStackSize(txtProgram.Text, (int)udProgramStackSize.Value);
    }

    private void btnGetProgramIgnorePause_Click(object sender, EventArgs e)
    {
        chkProgramIgnorePause.Checked = _robot.Cgtp.GetProgramIgnorePause(txtProgram.Text);
    }

    private void btnSetProgramIgnorePause_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramIgnorePause(txtProgram.Text, chkProgramIgnorePause.Checked);
    }

    private void btnGetProgramWriteProtect_Click(object sender, EventArgs e)
    {
        chkWriteProtect.Checked = _robot.Cgtp.GetProgramWriteProtect(txtProgram.Text);
    }

    private void btnSetProgramWriteProtect_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramWriteProtect(txtProgram.Text, chkWriteProtect.Checked);
    }

    private void btnGetProgramType_Click(object sender, EventArgs e)
    {
        cbProgramType.SelectedItem = _robot.Cgtp.GetProgramSubType(txtProgram.Text);
    }

    private void btnSetProgramType_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramSubType(txtProgram.Text, (CgtpProgramSubType)cbProgramType.SelectedItem);
    }

    private void btnGetProgramOwner_Click(object sender, EventArgs e)
    {
        txtProgramOwner.Text = _robot.Cgtp.GetProgramOwner(txtProgram.Text);
    }

    private void btnSetProgramOwner_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramOwner(txtProgram.Text, txtProgramOwner.Text);
    }

    private void btnSelectProgram_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.ChangeActiveProgram(txtProgram.Text);
    }

    private void btnAbort_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.AbortTask(txtProgram.Text);
    }

    private void BtnPause_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.PauseAllPrograms();
    }

    #endregion

    #region Files
    private void btnListFiles_Click(object sender, EventArgs e)
    {
        string[] files = _robot.Cgtp.ListFiles(txtPath.Text);

        treeFiles.Nodes.Clear();

        foreach (string file in files)
        {
            treeFiles.Nodes.Add(file);
        }

    }

    private void btnReadContent_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtFile.Text))
        {
            txtContent.Text = "";
            return;
        }
        txtContent.Text = _robot.Cgtp.GetFileAsString(Path.Combine(txtPath.Text, txtFile.Text));
    }

    private void treeFiles_AfterSelect(object sender, TreeViewEventArgs e)
    {
        txtFile.Text = e.Node?.Text;
        btnReadContent_Click(sender, e);
    }

    #endregion

    #region I/O
    private void btnSimulate_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SimulateIo((CgtpIoPortType)cbIoTypes.SelectedItem, (int)udIoIndex.Value);
        btnReadSimulation_Click(sender, e);
    }

    private void btnUnsimulate_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.UnsimulateIo((CgtpIoPortType)cbIoTypes.SelectedItem, (int)udIoIndex.Value);
        btnReadSimulation_Click(sender, e);
    }

    private void btnReadSimulation_Click(object sender, EventArgs e)
    {
        var type = (CgtpIoPortType)cbIoTypes.SelectedItem;
        var index = (int)udIoIndex.Value;
        bool isSimulated = _robot.Cgtp.GetIoSimulationStatus(type, index);

        txtSimulationStatus.Text = $"{type}[{index}] : {(isSimulated ? "" : "NOT ")}SIMULATED";
        txtSimulationStatus.BackColor = isSimulated ? Color.Yellow : Color.LightGray;
    }

    private void btnReadIo_Click(object sender, EventArgs e)
    {
        udIoValue.Value = _robot.Cgtp.ReadIo((CgtpIoPortType)cbIoTypes.SelectedItem, (int)udIoIndex.Value);
    }

    private void btnWriteIo_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.WriteIo((CgtpIoPortType)cbIoTypes.SelectedItem, (int)udIoIndex.Value, (int)udIoValue.Value);
    }
    #endregion

    #region Current position
    private void btnReadCartesian_Click(object sender, EventArgs e)
    {
        gridCartesianPosition.SelectedObject = _robot.Cgtp.ReadCartesianPosition((int)udGroup.Value);
    }

    private void btnReadJointsPosition_Click(object sender, EventArgs e)
    {
        gridJointPosition.SelectedObject = _robot.Cgtp.ReadJointPosition((int)udGroup.Value);
    }

    private void btnForwardKinematics_Click(object sender, EventArgs e)
    {
        gridCartesianPosition.SelectedObject = _robot.Cgtp.ForwardKinematics((int)udGroup.Value, (JointsPosition)gridJointPosition.SelectedObject);
    }

    private void btnInverseKinematics_Click(object sender, EventArgs e)
    {
        gridJointPosition.SelectedObject = _robot.Cgtp.InvertKinematics((int)udGroup.Value, (CartesianPosition)gridCartesianPosition.SelectedObject);
    }
    #endregion

    #region Variables

    private void btnReadVariable_Click(object sender, EventArgs e)
    {
        txtVariableValue.Text = _robot.Cgtp.ReadVariableAsString(txtVariableName.Text, txtVariableProgram.Text);
    }

    private void btnWriteVariable_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.WriteVariable(txtVariableName.Text, txtVariableValue.Text);
    }

    private void btnReadVariableAsPosition_Click(object sender, EventArgs e)
    {
        var value = _robot.Cgtp.ReadVariable(txtVariableName.Text, txtVariableProgram.Text);

        try
        {
            gridVariableJointValue.SelectedObject = value.JointPositionValue;
        }
        catch
        {
            gridVariableJointValue.SelectedObject = new JointPositionVariable();
        }

        try
        {
            gridVariableCartesianValue.SelectedObject = value.CartesianPositionValue;
        }
        catch
        {
            gridVariableCartesianValue.SelectedObject = new CartesianPositionVariable();
        }
    }

    private void btnWriteJointPositionVariable_Click(object sender, EventArgs e)
    {
        var position = (JointPositionVariable)gridVariableJointValue.SelectedObject;

        var variables = new CgtpBatchVariables();
        CgtpVariable variable = variables.AddVariable(txtVariableName.Text);

        variable.JointPositionValue = position;

        _robot.Cgtp.WriteBatchVariables(variables);
    }

    private void btnWriteCartesianVariableValue_Click(object sender, EventArgs e)
    {
        var position = (CartesianPositionVariable)gridVariableCartesianValue.SelectedObject;

        var variables = new CgtpBatchVariables();
        CgtpVariable variable = variables.AddVariable(txtVariableName.Text);

        variable.CartesianPositionValue = position;

        _robot.Cgtp.WriteBatchVariables(variables);
    }

    #endregion

    private void lstUserAlarms_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        if (!e.IsSelected) return;

        var alarm = e.Item?.Tag as UserAlarmDefinition;

        if (alarm != null)
        {
            udUserAlarmIndex.Value = e.ItemIndex + 1;
            txtUserAlarmComment.Text = alarm.Comment;
            udUserAlarmSeverity.Value = alarm.Severity;
        }
    }

    #region User alarms
    private void btnUserAlarmSetComment_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetComment(CgtpCommentType.UserAlarm, (int)udUserAlarmIndex.Value, txtUserAlarmComment.Text);
        btnReadUserAlarms_Click(sender, e);
    }

    private void btnUserAlarmSetSeverity_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetUserAlarmSeverity((int)udUserAlarmIndex.Value, (int)udUserAlarmSeverity.Value);
        btnReadUserAlarms_Click(sender, e);
    }

    private void btnReadUserAlarms_Click(object sender, EventArgs e)
    {
        UserAlarmDefinition[] alarms = _robot.Cgtp.ReadUserAlarms();

        lstUserAlarms.Items.Clear();

        try
        {
            lstUserAlarms.BeginUpdate();
            for (var i = 0; i < alarms.Length; i++)
            {
                var alarm = alarms[i];
                var item = new ListViewItem(new[] { (i + 1).ToString(), alarm.Comment, alarm.Severity.ToString() });
                item.Tag = alarm;
                lstUserAlarms.Items.Add(item);
            }
        }
        finally
        {
            lstUserAlarms.EndUpdate();
        }
    }
    #endregion

    #region Comments
    private void btnReadComments_Click(object sender, EventArgs e)
    {
        string[] comments = _robot.Cgtp.GetComments((CgtpCommentType)cbCommentType.SelectedItem);

        lstComments.Items.Clear();

        try
        {
            lstComments.BeginUpdate();
            for (var i = 0; i < comments.Length; i++)
            {
                var comment = comments[i];
                var item = new ListViewItem(new[] { (i + 1).ToString(), comment });
                item.Tag = comment;
                lstComments.Items.Add(item);
            }
        }
        finally
        {
            lstComments.EndUpdate();
        }
    }

    private void lstComments_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        if (!e.IsSelected) return;

        var comment = e.Item?.Tag as string;

        if (comment != null)
        {
            udCommentIndex.Value = e.ItemIndex + 1;
            txtComment.Text = comment;
        }
    }

    private void btnSetComment_Click_1(object sender, EventArgs e)
    {
        _robot.Cgtp.SetComment((CgtpCommentType)cbCommentType.SelectedItem, (int)udCommentIndex.Value, txtComment.Text);
        btnReadComments_Click(sender, e);
    }
    #endregion



    #region HTTP
    private void lstHttpItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        if (!e.IsSelected || e.Item is null) return;


        btnHttpDownloadAscii.Visible = !string.IsNullOrEmpty(e.Item.SubItems[1].Text);
        btnHttpDownloadAscii.Text = e.Item.SubItems[1].Text;

        btnHttpDownloadFile.Enabled = !string.IsNullOrEmpty(e.Item.SubItems[0].Text);
        btnHttpDownloadFile.Text = e.Item.SubItems[0].Text;
    }

    private void btnHttpDownloadFile_Click(object sender, EventArgs e)
    {
        var file = (sender as Button)?.Text;

        if (string.IsNullOrEmpty(file)) return;

        var bytes = _robot.Cgtp.Http.DownloadAsBytes(file);

        dlgSaveFile.FileName = file;

        if (dlgSaveFile.ShowDialog() == DialogResult.OK)
        {
            var savePath = dlgSaveFile.FileName;
            if (string.IsNullOrEmpty(savePath)) return;
            File.WriteAllBytes(savePath, bytes);

            Explorer.RevealFile(savePath);
        }

    }

    private void btnHttpListVariables_Click(object sender, EventArgs e)
    {
        ShowHttpFiles(_robot.Cgtp.Http.ListVariableFiles());

    }
    private void btnHttpListPrograms_Click(object sender, EventArgs e)
    {
        ShowHttpFiles(_robot.Cgtp.Http.ListTpPrograms());
    }

    private void btnHttpListDiagnosticFiles_Click(object sender, EventArgs e)
    {
        ShowHttpFiles(_robot.Cgtp.Http.ListDiagnosticFiles());
    }

    private void btnHttpListOther_Click(object sender, EventArgs e)
    {
        ShowHttpFiles(_robot.Cgtp.Http.ListOtherFiles());
    }

    private void ShowHttpFiles(CgtpFileItem[] items)
    {
        lstHttpItems.Items.Clear();

        foreach (var item in items)
        {
            lstHttpItems.Items.Add(new ListViewItem(new[] { item.File, (item as CgtpAsciiFileItem)?.AsciiFile, item.Comment }));
        }

    }
    #endregion

    #region Batch Variables
    private readonly CgtpBatchVariables _variables = new CgtpBatchVariables();
    private void InitBatchVariable()
    {
        _variables.AddNumericRegister(1);
        _variables.AddNumericRegister(2);

        _variables.AddPositionRegister(1);
        _variables.AddPositionRegister(2);

        _variables.AddStringRegister(1);
        _variables.AddStringRegister(2);

        _variables.AddVariable("$RMT_MASTER");
        _variables.AddVariable("$MNUFRAME[1,1]");
        _variables.AddVariable("$SHELL_WRK.$CUST_NAME");

        UpdateVariableList();
    }

    private void UpdateVariableList()
    {
        var selected = lstBatchVariables.SelectedIndices.OfType<int>().ToArray();
        gridSelectedBatchVariable.SelectedObject = null;

        try
        {
            lstBatchVariables.BeginUpdate();
            lstBatchVariables.Items.Clear();
            for (int i = 0; i < _variables.Count; i++)
            {
                var variable = _variables[i];
                AddBatchVariable(variable, selected.Contains(i));
            }
        }
        finally
        {
            lstBatchVariables.EndUpdate();
        }
    }

    private void AddBatchVariable(ICgtpBatchVariable variable, bool selected = false)
    {
        if (selected) lstBatchVariables.SelectedIndices.Clear();

        var item = lstBatchVariables.Items.Add(new ListViewItem(new[] { variable.Name, variable.StringValue?.ToString() }) { Tag = variable });
        item.Selected = selected;
    }

    private void lstBatchVariables_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        btnBatchDelete.Enabled = e.IsSelected;

        gridSelectedBatchVariable.SelectedObject = e.IsSelected ? e.Item?.Tag : null;
    }



    private void btnBatchDelete_Click(object sender, EventArgs e)
    {
        foreach (var item in lstBatchVariables.SelectedItems)
        {
            if (item is ListViewItem listViewItem && listViewItem.Tag is ICgtpBatchVariable variable)
            {
                _variables.Remove(variable);
                lstBatchVariables.Items.Remove(listViewItem);
            }
        }
    }

    private void btnReadBatchVariable_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.ReadBatchVariables(_variables);
        UpdateVariableList();
    }

    private void btnWriteBatchVariable_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.WriteBatchVariables(_variables);
        _robot.Cgtp.ReadBatchVariables(_variables);
        UpdateVariableList();
    }

    private void gridSelectedBatchVariable_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
    {
        // Walk up to the top-level property of the selected object
        var gridItem = e.ChangedItem;
        while (gridItem?.Parent != null
            && gridItem.Parent.GridItemType != GridItemType.Root
            && gridItem.Parent.GridItemType != GridItemType.Category)
        {
            gridItem = gridItem.Parent;
        }

        // Explicitly re-set the property to trigger the setter (propagates changes to _stringValue for CgtpVariable)
        var selectedObj = gridSelectedBatchVariable.SelectedObject;
        if (selectedObj != null && gridItem?.PropertyDescriptor != null)
        {
            gridItem.PropertyDescriptor.SetValue(selectedObj, gridItem.Value);
        }

        gridSelectedBatchVariable.Refresh(); // refresh to update displayed value

        var item = lstBatchVariables.Items.OfType<ListViewItem>().FirstOrDefault(i => i.Tag == (gridSelectedBatchVariable.SelectedObject));

        if (item is null) return;

        item.SubItems[1].Text = (gridSelectedBatchVariable.SelectedObject as ICgtpBatchVariable)?.StringValue?.ToString() ?? "";
    }

    private void btnBatchAddNumericRegister_Click(object sender, EventArgs e)
    {
        int nextIndex = 1 + (_variables.OfType<CgtpNumericRegister>().Max(r => (int?)r.Index) ?? 0);

        var added = _variables.AddNumericRegister(nextIndex);

        AddBatchVariable(added, true);
    }

    private void btnBatchAddStringRegister_Click(object sender, EventArgs e)
    {
        int nextIndex = 1 + (_variables.OfType<CgtpStringRegister>().Max(r => (int?)r.Index) ?? 0);

        var added = _variables.AddStringRegister(nextIndex);

        AddBatchVariable(added, true);
    }

    private void btnBatchPositionJoint_Click(object sender, EventArgs e)
    {
        int nextIndex = 1 + (_variables.OfType<CgtpPositionRegister>().Max(r => (int?)r.Index) ?? 0);

        var added = _variables.AddPositionRegisterAsCartesian(nextIndex, new CartesianPosition());

        AddBatchVariable(added, true);
    }

    private void btnBatchPositionCartesian_Click(object sender, EventArgs e)
    {
        int nextIndex = 1 + (_variables.OfType<CgtpPositionRegister>().Max(r => (int?)r.Index) ?? 0);

        var added = _variables.AddPositionRegisterAsJoint(nextIndex, new JointsPosition());

        AddBatchVariable(added, true);
    }

    private void btnAddBatchVariable_Click(object sender, EventArgs e)
    {
        var added = _variables.AddVariable(txtBatchVariableName.Text, txtBatchVariableProgram.Text);

        AddBatchVariable(added, true);
    }

    private void txtBatchVariableName_TextChanged(object sender, EventArgs e)
    {
        btnAddBatchVariable.Enabled = !string.IsNullOrEmpty(txtBatchVariableName.Text);
    }
    #endregion


    #region Registers
    private void btnReadNumericRegisters_Click(object sender, EventArgs e)
    {
        gridRegisterValues.SelectedObject = _robot.Cgtp.ReadNumericRegistersWithComment();
        gridRegisterValues.ExpandAllGridItems();
    }

    private void btnReadStringRegisters_Click(object sender, EventArgs e)
    {
        gridRegisterValues.SelectedObject = _robot.Cgtp.ReadStringRegistersWithComment();
        gridRegisterValues.ExpandAllGridItems();
    }

    private void btnReadPositionRegister_Click(object sender, EventArgs e)
    {
        gridRegisterValue.SelectedObject = _robot.Cgtp.ReadPositionRegisterWithComment((int)udRegisterIndex.Value, (int)udPositionRegisterGroup.Value);
        gridRegisterValue.ExpandAllGridItems();
    }

    private void btnReadNumericRegister_Click(object sender, EventArgs e)
    {
        NumericRegisterWithComment register = _robot.Cgtp.ReadNumericRegisterWithComment((int)udRegisterIndex.Value);

        txtNumericRegisterComment.Text = register.Comment;
        udNumericRegisterValue.Value = (decimal)register.RealValue;

        rdNumericRegisterInteger.Checked = register.IsInteger;
        rdNumericRegisterReal.Checked = !register.IsInteger;
    }

    private void btnWriteNumericRegister_Click(object sender, EventArgs e)
    {
        if (rdNumericRegisterInteger.Checked)
            _robot.Cgtp.WriteNumericRegisterAsInteger((int)udRegisterIndex.Value, (int)udNumericRegisterValue.Value);
        else
            _robot.Cgtp.WriteNumericRegisterAsDouble((int)udRegisterIndex.Value, (double)udNumericRegisterValue.Value);
    }

    private void rdNumericRegisterInteger_CheckedChanged(object sender, EventArgs e)
    {
        if (rdNumericRegisterInteger.Checked) udNumericRegisterValue.DecimalPlaces = 0;
    }

    private void rdNumericRegisterReal_CheckedChanged(object sender, EventArgs e)
    {
        if (rdNumericRegisterReal.Checked) udNumericRegisterValue.DecimalPlaces = 5;
    }

    private void btnWriteStringRegister_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.WriteStringRegister((int)udRegisterIndex.Value, txtStringRegisterValue.Text);
    }
    #endregion
}