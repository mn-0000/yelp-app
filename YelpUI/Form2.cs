using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace YelpUI
{
    public partial class Form2 : Form
    {
<<<<<<< YelpUI/Form2.cs
=======
<<<<<<< HEAD

=======
>>>>>>> Refactored several elements in the code
>>>>>>> YelpUI/Form2.cs
        Form1 form1;

        public Form2(Form1 form1)
        {
<<<<<<< YelpUI/Form2.cs
=======
<<<<<<< HEAD

            this.form1 = form1;
            InitializeComponent();

        }

     

        private void txtTip_MouseClick(object sender, MouseEventArgs e)
        {
            txtTip.Text = "";
            
=======
>>>>>>> YelpUI/Form2.cs
            this.form1 = form1;
            InitializeComponent();
        }

        private void txtTip_MouseClick(object sender, MouseEventArgs e)
        {
            txtTip.Text = "";
<<<<<<< YelpUI/Form2.cs
=======
>>>>>>> Refactored several elements in the code
>>>>>>> YelpUI/Form2.cs
        }

        private void addTip(NpgsqlDataReader R)
        {
<<<<<<< YelpUI/Form2.cs
=======
<<<<<<< HEAD
            
            
=======
>>>>>>> Refactored several elements in the code
>>>>>>> YelpUI/Form2.cs
            Tip tip = new Tip()
            {
                Date = R.GetDateTime(0),
                UserName = R.GetString(1),
                NumLikes = R.GetInt32(2),
                TextReview = R.GetString(3),
            };
            var index = dgvTips.Rows.Add();
            dgvTips.Rows[index].Cells["clmnDate"].Value = tip.Date.ToString();
            dgvTips.Rows[index].Cells["clmnName"].Value = tip.UserName;
            dgvTips.Rows[index].Cells["clmnNumLikes"].Value = tip.NumLikes.ToString();
            dgvTips.Rows[index].Cells["clmnReview"].Value = tip.TextReview;
        }
<<<<<<< YelpUI/Form2.cs
=======
<<<<<<< HEAD
        
        private void btnLeaveTip_Click_1(object sender, EventArgs e)
        {
            dgvTips.Rows.Clear();
            
=======
>>>>>>> YelpUI/Form2.cs

        private void RefreshForm(NpgsqlDataReader R)
        {
            dgvTips.Refresh();
        }

        private void btnLeaveTip_Click(object sender, EventArgs e)
        {
            dgvTips.Rows.Clear();

<<<<<<< YelpUI/Form2.cs
=======
>>>>>>> Refactored several elements in the code
>>>>>>> YelpUI/Form2.cs
            string sqlstr = "INSERT INTO Tips(date, business_id, user_id, number_of_likes, text_review) " +
                "VALUES ('" + DateTime.Now.ToString() + "','" + form1.dgvSearchResults.CurrentRow.Cells["clmnBID"].Value.ToString() + "', 'FuTJWFYm4UKqewaosss1KA', 0, '"
                 + txtTip.Text + "');";

<<<<<<< YelpUI/Form2.cs
=======
<<<<<<< HEAD
            using (var connection = new NpgsqlConnection(form1.buildConnectionString()))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = sqlstr;
                    try
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            dgvTips.Refresh();
                        }
                    }
                    catch (NpgsqlException nex)
                    {
                        MessageBox.Show("SQL Error - " + nex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

         

            string strsql = "SELECT DISTINCT date, name, number_of_likes, text_review " +
                "FROM Tips, Business, Users " +
                "WHERE Business.business_id = '" + form1.dgvSearchResults.CurrentRow.Cells["clmnBID"].Value.ToString() + "' AND Business.business_id = Tips.business_id AND Users.user_id = Tips.user_id;";
            form1.executeQuery(strsql, addTip);
        }

     
=======
>>>>>>> YelpUI/Form2.cs
            SQLQueries.executeQuery(sqlstr, RefreshForm);
            string strsql = "SELECT DISTINCT date, name, number_of_likes, text_review " +
                "FROM Tips, Business, Users " +
                "WHERE Business.business_id = '" + form1.dgvSearchResults.CurrentRow.Cells["clmnBID"].Value.ToString() + "' AND Business.business_id = Tips.business_id AND Users.user_id = Tips.user_id;";
            SQLQueries.executeQuery(strsql, addTip);
        }
<<<<<<< YelpUI/Form2.cs
=======
>>>>>>> Refactored several elements in the code
>>>>>>> YelpUI/Form2.cs
    }
}
