using System;
using System.Threading;
using System.Windows.Forms;
using ApiLibrary;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
        }

        private async void uptimeButton_Click(object sender, EventArgs e)
        {
            if (!Uri.TryCreate(baseUriTextBox.Text, UriKind.Absolute, out Uri baseUri))
            {
                uptimeLabel.Text = "Invalid base URI";
                return;
            }

            var api = new Api(baseUri);

            cts = new CancellationTokenSource();
            var statusTask = api.GetStatusAsync(cts.Token);

            uptimeLabel.Text = "Getting uptime...";
            cancelButton.Enabled = true;
            uptimeButton.Enabled = false;

            try
            {
                var status = await statusTask;
                uptimeLabel.Text = $"Uptime is {status.Uptime}";
            }
            catch (OperationCanceledException)
            {
                uptimeLabel.Text = $"Cancelled.";
            }

            cancelButton.Enabled = false;
            uptimeButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (cts is null) return;
            cts.Cancel();
        }
    }
}
