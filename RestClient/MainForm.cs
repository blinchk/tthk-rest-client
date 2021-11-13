using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CommandGoOnClick(object? sender, EventArgs e)
        {
            string endpoint = endpointURITextBox.Text;
            RestClient restClient = new RestClient();
            HttpWebRequest request = RestClient.BuildRequest(endpoint);
            string responseBody = restClient.SendRequest(request);
            DisplayResponseBody(responseBody);
        }

        private void DisplayResponseBody(string responseBody)
        {
            responseTextBox.Text = responseBody;
        }
    }
}
