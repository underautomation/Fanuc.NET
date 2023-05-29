using System;
using System.Windows.Forms;

public partial class LoadVariableProgressForm : Form
{
    public LoadVariableProgressForm()
    {
        InitializeComponent();
    }

    private bool _canceled = false;
    public void OnProgress(double progress)
    {
        if (_canceled) throw new Exception("Download canceled");
        progressBar.Value = (int)progress;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        _canceled = true;
        this.Close();
    }

    private void LoadVariableProgress_FormClosing(object sender, FormClosingEventArgs e)
    {
        _canceled = true;
    }
}
