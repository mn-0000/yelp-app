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
            // a e s t h e t i c color palette lul
            splitContainer.Panel2.BackColor = ColorTranslator.FromHtml("#FFDAF5");
            infoContainer.Panel1.BackColor = ColorTranslator.FromHtml("#B0E1FF");
            infoContainer.Panel2.BackColor = ColorTranslator.FromHtml("#E6C6FF");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder mapSite = new StringBuilder("https://google.com/maps");
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
            webView.Source = new Uri(mapSite.ToString());
        }
    }
}
