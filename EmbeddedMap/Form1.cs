using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnSearchAddress_Click(object sender, EventArgs e)
        {
            StringBuilder webURL = new StringBuilder();
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string postal = txtPostal.Text;

            string[] address = { street, city, state, postal };

            webURL.Append("http://google.com/maps?q=");

            for (int i = 0; i < address.Count(); i++)
            {
                if (address[i] != string.Empty)
                {
                    webURL.Append(address[i] + "," + "+");
                }
            }

            webBrowser1.Navigate(webURL.ToString());

        }
    }
}
