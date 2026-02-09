using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.License;

public partial class LicenseControl : UserControl, IUserControl
{
    // Cache valid license info
    private bool _licenseValid;

    public LicenseControl()
    {
        InitializeComponent();

        // Set stored license information
        txtLicensee.Text = Config.Current.Licensee;
        txtKey.Text = Config.Current.Key;

        // Register license at startup
        FanucRobot.RegisterLicense(Config.Current.Licensee, Config.Current.Key);

        UpdateLicenseControls();
    }

    #region IUserControl
    public string Title => "License";

    public bool FeatureEnabled => _licenseValid;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen()
    {
    }
    #endregion

    private void UpdateLicenseControls()
    {
        // Display license data
        var info = FanucRobot.LicenseInfo;
        txtLicenseInfo.Text = info.ToString();
        gridLicense.SelectedObject = info;
        _licenseValid = info.State != LicenseState.Invalid && info.State != LicenseState.Expired;
    }

    private void btnSetLicense_Click(object sender, System.EventArgs e)
    {
        // Register license with provided information
        FanucRobot.RegisterLicense(txtLicensee.Text, txtKey.Text);

        UpdateLicenseControls();

        // Store license information
        Config.Current.Licensee = txtLicensee.Text;
        Config.Current.Key = txtKey.Text;
        Config.Save();
    }

    private void txtLicenseInfo_LinkClicked(object sender, LinkClickedEventArgs e)
    {
        MainForm.Instance.OpenUrl(e.LinkText);
    }

    private void lnkOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MainForm.Instance.OpenUrl($"{(sender as Control).Text}?sdk=fanuc");
    }
}
