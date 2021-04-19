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
<<<<<<< HEAD

=======
>>>>>>> Refactored several elements in the code
        Form1 form1;

        public Form2(Form1 form1)
        {
<<<<<<< HEAD

            this.form1 = form1;
            InitializeComponent();

        }

     

        private void txtTip_MouseClick(object sender, MouseEventArgs e)
        {
            txtTip.Text = "";
            
=======
            this.form1 = form1;
            InitializeComponent();
        }

        private void txtTip_MouseClick(object sender, MouseEventArgs e)
        {
            txtTip.Text = "";
>>>>>>> Refactored several elements in the code
        }

        private void addTip(NpgsqlDataReader R)
        {
<<<<<<< HEAD
            
            
=======
>>>>>>> Refactored several elements in the code
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
<<<<<<< HEAD
        
        private void btnLeaveTip_Click_1(object sender, EventArgs e)
        {
            dgvTips.Rows.Clear();
            
=======

        private void RefreshForm(NpgsqlDataReader R)
        {
            dgvTips.Refresh();
        }

        private void btnLeaveTip_Click(object sender, EventArgs e)
        {
            dgvTips.Rows.Clear();

>>>>>>> Refactored several elements in the code
            string sqlstr = "INSERT INTO Tips(date, business_id, user_id, number_of_likes, text_review) " +
                "VALUES ('" + DateTime.Now.ToString() + "','" + form1.dgvSearchResults.CurrentRow.Cells["clmnBID"].Value.ToString() + "', 'FuTJWFYm4UKqewaosss1KA', 0, '"
                 + txtTip.Text + "');";

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
            SQLQueries.executeQuery(sqlstr, RefreshForm);
            string strsql = "SELECT DISTINCT date, name, number_of_likes, text_review " +
                "FROM Tips, Business, Users " +
                "WHERE Business.business_id = '" + form1.dgvSearchResults.CurrentRow.Cells["clmnBID"].Value.ToString() + "' AND Business.business_id = Tips.business_id AND Users.user_id = Tips.user_id;";
            SQLQueries.executeQuery(strsql, addTip);
        }
>>>>>>> Refactored several elements in the code
    }
}
