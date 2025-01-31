﻿using System;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc.Ftp;

public partial class SelectVariablesForm : Form
{
    public SelectVariablesForm(FtpListItem[] items)
    {
        InitializeComponent();

        lst.Items.Clear();

        var CheckedVariableFiles = Config.Current.CheckedVariableFiles ?? new string[0];

        foreach (var item in items)
        {
            lst.Items.Add(item.Name, CheckedVariableFiles.Contains(item.Name));
        }
    }

    public string[] SelectedItems => lst.SelectedItems.OfType<string>().ToArray();

    private void btnOK_Click(object sender, EventArgs e)
    {
        Config.Current.CheckedVariableFiles = SelectedItems;
        Config.Save();
    }
}
