using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public partial class ContactControl : UserControl, IUserControl
{

    public ContactControl()
    {
        InitializeComponent();

        setEmailAnimation();
    }

    #region IUserControl
    public string Title => "Need help ?";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { setEmailAnimation(); }


    #endregion

    public void SetMessage(string message)
    {
        txtMessage.Text = message;
    }

    private async void btnSend_Click(object sender, System.EventArgs e)
    {
        var payloadObject = new
        {
            email = txtEmail.Text,
            subject = $"Fanuc Desktop showcase - {DateTime.UtcNow.ToString("yyMMddHHmmss")}",
            message = txtMessage.Text
        };

        string payload = JsonSerializer.Serialize(payloadObject);
        var content = new StringContent(payload, Encoding.UTF8, "application/json");

        try
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync("https://formspree.io/f/mleawvqb", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Message sent! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show($"Request error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void txtEmail_TextChanged(object sender, System.EventArgs e)
    {
        setEmailAnimation();
    }

    private void setEmailAnimation()
    {
        if (chkAnonymous.Checked || (txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".")))
        {
            emailErrorProvider.Clear();
            btnSend.Enabled = true;
        }
        else
        {
            emailErrorProvider.SetError(txtEmail, "please provide an email to get an answer");
            btnSend.Enabled = false;
        }
    }

    private void chkAnonymous_CheckedChanged(object sender, System.EventArgs e)
    {
        if (chkAnonymous.Checked) txtEmail.Text = "";
        txtEmail.Enabled = !chkAnonymous.Checked;
        setEmailAnimation();
    }
}
