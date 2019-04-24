using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace GlobalEmail_NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String RESTRequest = "";
            String Options = "";

            // *************************************************************************************
            // Set the License String in the Request
            // *************************************************************************************
            RESTRequest += @"&id=" + Uri.EscapeDataString(txtLicense.Text);

            // *************************************************************************************
            // Set the Options in the Request
            // *************************************************************************************
            if (!optDomainCorrection.Checked)
                Options += "DomainCorrection:False,";

            if (optVerificationType.SelectedIndex.Equals(1))
                Options += "VerifyMailbox:Premium,";

            if (!optTimeToWait.SelectedIndex.Equals(1))
                Options += "TimeToWait:2,";
            else
                Options += "TimeToWait:" + optTimeToWait.SelectedText+",";

            if (!cmbWhoIs.SelectedIndex.Equals(1))
                Options += "WhoISLookup:Off";
            else
                Options += "WhoIsLookup:On";


            RESTRequest += @"&opt=" + Options;
       
            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&email=" + Uri.EscapeDataString(txtEmailIn.Text);

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"https://globalemail.melissadata.net/V4/WEB/GlobalEmail" + @"/doGlobalEmail?t=" + RESTRequest;

            // Output the REST Query
            txtRESTRequest.Text = RESTRequest;

            // *************************************************************************************
            // Submit to the Web Service. 
            // Make sure to set a retry block in case of any timeouts
            // *************************************************************************************
            Boolean Success = false;
            Int16 RetryCounter = 0;
            Stream ResponseReaderFile = null;
            do
            {
                try
                {
                    HttpWebRequest WebRequestObject = (HttpWebRequest)HttpWebRequest.Create(RESTRequest);
                    WebResponse Response = WebRequestObject.GetResponse();
                    ResponseReaderFile = Response.GetResponseStream();
                    Success = true;
                }
                catch (Exception ex)
                {
                    RetryCounter++;
                    MessageBox.Show("Exception: " + ex.Message);
                    return;
                }
            } while ((Success != true) && (RetryCounter < 5));

            // *************************************************************************************
            // Output Formatted JSON String
            // *************************************************************************************
            StreamReader Reader = new StreamReader(ResponseReaderFile, Encoding.UTF8);
            String ResponseString = Reader.ReadToEnd();

            txtResponse.Text = JValue.Parse(ResponseString).ToString(Newtonsoft.Json.Formatting.Indented);
        }

        // *************************************************************************************
        // Clear all
        // *************************************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            // inputs
            txtEmailIn.Text = string.Empty;

            // options
            optDomainCorrection.Checked = true;
            optVerificationType.SelectedIndex = 0;
            optTimeToWait.SelectedIndex = 1;

            // request and response
            txtRESTRequest.Text = string.Empty;
            txtResponse.Text = string.Empty;
        }

        // *************************************************************************************
        // Wiki Link
        // *************************************************************************************
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wiki.melissadata.com/index.php?title=Global_Email_V4");
        }
    }
}
