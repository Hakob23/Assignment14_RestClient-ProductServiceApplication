using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRESTClient
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            RESTClient client = new RESTClient(httpVerb.GET, Request.Text);

            string response = client.MakeRequest();

            debugOutput(response);
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                Response.Text = Response.Text + strDebugText + Environment.NewLine;
                Response.SelectionStart = Response.TextLength;
                Response.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
