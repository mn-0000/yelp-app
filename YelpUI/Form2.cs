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

        Form1 form1;

        public Form2(Form1 form1)
        {

            this.form1 = form1;
            InitializeComponent();
          
        }


        private void txtTip_MouseClick(object sender, MouseEventArgs e)
        {
            txtTip.Text = "";
            
        }

        private void addTip(NpgsqlDataReader R)
        {
            
            
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
        
        private void btnLeaveTip_Click_1(object sender, EventArgs e)
        {
            dgvTips.Rows.Clear();
            
            string sqlstr = "INSERT INTO Tips(date, business_id, user_id, number_of_likes, text_review) " +
                "VALUES ('" + DateTime.Now.ToString() + "','" + form1.dgvSearchResults.CurrentRow.Cells["clmnBID"].Value.ToString() + "', 'FuTJWFYm4UKqewaosss1KA', 0, '"
                 + txtTip.Text + "');";

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



        public void executeQuery(string sqlstr, Action<NpgsqlDataReader> myf)
        {
            using (var connection = new NpgsqlConnection(buildConnectionString()))
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
                            myf(reader);
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
        }

        public string buildConnectionString()
        {
            return "Host = localhost; Username = postgres; Database = Milestone2; password = Leagues69!";
        }


    }
}
