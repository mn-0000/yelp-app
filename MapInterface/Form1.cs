using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapInterface
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            // Set the background color for the panels
            splitContainer.Panel2.BackColor = ColorTranslator.FromHtml("#FFDAF5");
            infoContainer.Panel1.BackColor = ColorTranslator.FromHtml("#B0E1FF");
            infoContainer.Panel2.BackColor = ColorTranslator.FromHtml("#E6C6FF");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // URL to the default Maps site, for appending purposes
            StringBuilder mapSite = new StringBuilder("https://google.com/maps"); 

            // Search for a certain location on the map. The different textbox contents
            // only get appended to the mapSite if it's not empty.
            mapSite.Append("?q=");
            if (txtCity.Text != String.Empty)
            {
                mapSite.Append(txtCity.Text + ",+");
            }
            if (txtState.Text != String.Empty)
            {
                mapSite.Append(txtState.Text + ",+");
            }
            if (txtCountry.Text != String.Empty)
            {
                mapSite.Append(txtCountry.Text);
            }

            // Initiate searching
            webView.Source = new Uri(mapSite.ToString());
        }
    }
}
