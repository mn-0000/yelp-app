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
using System.Text.RegularExpressions;


namespace YelpUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            AddColumnsToGrid();
            AddState();
        }

        Form2 form2;

        public string buildConnectionString()
        {
            return "Host = localhost; Username = postgres; Database = Milestone2; password = Leagues69!";
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

        private void AddState()
        {
            using (var connection = new NpgsqlConnection(buildConnectionString()))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT DISTINCT state FROM business ORDER BY state";
                    try
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lstState.Items.Add(reader.GetString(0));
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

        private void addCity(NpgsqlDataReader R)
        {
            lstCity.Items.Add(R.GetString(0));
        }
        private void addZipcode(NpgsqlDataReader R)
        {
            lstZipcode.Items.Add(R.GetString(0));

        }

        private void addCategories(NpgsqlDataReader R)
        {
            lstCategories.Items.Add(R.GetString(0));
        }

        private void addUsers(NpgsqlDataReader R)
        {
            lstUsers.Items.Add(R.GetString(0));
        }

        private void addUserInfo(NpgsqlDataReader R)
        {

            //SELECT average_stars, name, number_of_cool_votes,
            //            number_of_funny_votes, number_of_useful_votes, tip_count, fan_count
            //				tip_likes, yelping_since
            //FROM users
            //WHERE name = 'John'

            User user = new User();

            user.avg_stars = R.GetDouble(0);
            user.name = R.GetString(1);
            user.coolVotes = R.GetInt32(2);
            user.funnyVotes = R.GetInt32(3);
            user.usefulVotes = R.GetInt32(4);
            user.tipCount = R.GetInt32(5);
            user.fans = R.GetInt32(6);
            user.totalLikes = R.GetInt32(7);
            user.yelping_since = R.GetString(8);

            txtboxUserStars.Text = user.avg_stars.ToString();
            txtboxUserName.Text = user.name;
            txtBoxCoolVotes.Text = user.coolVotes.ToString();
            txtBoxFunnyVotes.Text = user.funnyVotes.ToString();
            txtBoxUsefulVotes.Text = user.usefulVotes.ToString();
            txtBoxTipCount.Text = user.tipCount.ToString();
            txtBoxTipLikes.Text = user.totalLikes.ToString();
            txtBoxYelpingSince.Text = user.yelping_since;


        }

        private void lstState_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCity.Items.Clear();
            lstZipcode.Items.Clear();
            lstCategories.Items.Clear();
            lstFilteringCategories.Items.Clear();
            if (lstState.SelectedIndex > -1)
            {
                string sqlstr = "SELECT distinct city FROM business WHERE state = " + "'" + lstState.SelectedItem.ToString() + "'" + " ORDER BY city";
                executeQuery(sqlstr, addCity);
            }
        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstZipcode.Items.Clear();
            lstCategories.Items.Clear();
            if (lstCity.SelectedIndex > -1)
            {
                string sqlstr = "SELECT DISTINCT postal_code FROM business WHERE state = " + "'" + lstState.SelectedItem.ToString()
                    + "' AND CITY = '" + lstCity.SelectedItem.ToString() + "' ORDER BY postal_code";
                executeQuery(sqlstr, addZipcode);
            }
        }

        private void lstZipcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCategories.Items.Clear();
            if (lstZipcode.SelectedIndex > -1)
            {
                string sqlstr = "SELECT DISTINCT category_name " +
                                "FROM BusinessCategories bc, Business b " +
                                "WHERE bc.business_id = b.business_id AND b.state = '" +
                                lstState.SelectedItem.ToString() +
                                "' AND b.city = '" +
                                lstCity.SelectedItem.ToString() +
                                "' AND b.postal_code = '" +
                                lstZipcode.SelectedItem.ToString() +
                                "';";
                executeQuery(sqlstr, addCategories);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex > -1)
            {
                if (lstFilteringCategories.FindStringExact(lstCategories.SelectedItem.ToString()) == ListBox.NoMatches)
                    lstFilteringCategories.Items.Add(lstCategories.SelectedItem.ToString());
            }
        }

        private void btnSearchBusiness_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder();
            dgvSearchResults.Rows.Clear();
            dgvSearchResults.Refresh();
            if (lstState.SelectedIndex < 0 || lstCity.SelectedIndex < 0 || lstZipcode.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a state, city, and zipcode before performing your search.", "Error: Unselected Criteria");
            }
            else
            {
                string sqlstr = "SELECT DISTINCT business_name, address, city, state, total_number_of_tips, total_number_of_checkins, b.business_id " +
                                "FROM BusinessCategories bc, Business b " +
                                "WHERE bc.business_id = b.business_id AND b.state = '" +
                                lstState.SelectedItem.ToString() +
                                "' AND b.city = '" +
                                lstCity.SelectedItem.ToString() +
                                "' AND b.postal_code = '" +
                                lstZipcode.SelectedItem.ToString() + "'";
                query.Append(sqlstr);

                if (lstFilteringCategories.Items.Count > 0)
                {
                    query.Append(" AND category_name IN (");
                    int categoryCount = 0;
                    foreach (string item in lstFilteringCategories.Items)
                    {
                        if (categoryCount == lstFilteringCategories.Items.Count - 1)
                        {
                            query.Append("'" + item + "'");
                            categoryCount++;
                        }
                        else
                        {
                            query.Append("'" + item + "'" + ", ");
                            categoryCount++;
                        }
                    }
                    string endSqlstr = ") GROUP BY business_name, address, city, state, total_number_of_tips, total_number_of_checkins, b.business_id " +
                        "HAVING count(*) = " + categoryCount.ToString() + ";";

                    query.Append(endSqlstr);
                }
                else
                {
                    query.Append(";");
                }
                executeQuery(query.ToString(), addGridRow);
            }



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstFilteringCategories.SelectedIndex > -1)
            {
                lstFilteringCategories.Items.RemoveAt(lstFilteringCategories.SelectedIndex);
            }
        }

        private void AddColumnsToGrid()
        {
            dgvSearchResults.Columns.Add("clmnBName", "Business Name");
            dgvSearchResults.Columns.Add("clmnAddress", "Address");
            dgvSearchResults.Columns.Add("clmnCity", "City");
            dgvSearchResults.Columns.Add("clmnState", "State");
            dgvSearchResults.Columns.Add("clmnNumTips", "# of Tips");
            dgvSearchResults.Columns.Add("clmnNumCheckIns", "# of CheckIns");
            dgvSearchResults.Columns.Add("clmnBID", "BusinessID");

            //dgvSearchResults.Columns["clmnBName"].DataPropertyName = "business_name";
            //dgvSearchResults.Columns["clmnAddress"].DataPropertyName = "address";
            //dgvSearchResults.Columns["clmnCity"].DataPropertyName = "city";
            //dgvSearchResults.Columns["clmnState"].DataPropertyName = "state";
            //dgvSearchResults.Columns["clmnNumTips"].DataPropertyName = "total_number_of_tips";
            //dgvSearchResults.Columns["clmnNumCheckIns"].DataPropertyName = "total_number_of_checkins";

            dgvSearchResults.EnableHeadersVisualStyles = false;
            dgvSearchResults.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E6C6FF");
            foreach (DataGridViewColumn column in dgvSearchResults.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvSearchResults.Columns["clmnBName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchResults.Columns["clmnAddress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSearchResults.RowHeadersVisible = false;
            dgvSearchResults.Columns["clmnBID"].Visible = false;
        }

        private void addGridRow(NpgsqlDataReader R)
        {
            Business business = new Business()
            {
                Name = R.GetString(0),
                Address = R.GetString(1),
                City = R.GetString(2),
                State = R.GetString(3),
                NumTips = R.GetInt32(4),
                NumCheckIns = R.GetInt32(5),
                BusinessID = R.GetString(6)
            };
            var index = dgvSearchResults.Rows.Add();
            dgvSearchResults.Rows[index].Cells["clmnBName"].Value = business.Name;
            dgvSearchResults.Rows[index].Cells["clmnAddress"].Value = business.Address;
            dgvSearchResults.Rows[index].Cells["clmnCity"].Value = business.City;
            dgvSearchResults.Rows[index].Cells["clmnState"].Value = business.State;
            dgvSearchResults.Rows[index].Cells["clmnNumTips"].Value = business.NumTips;
            dgvSearchResults.Rows[index].Cells["clmnNumCheckIns"].Value = business.NumCheckIns;
            dgvSearchResults.Rows[index].Cells["clmnBID"].Value = business.BusinessID;
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
            var index = form2.dgvTips.Rows.Add();
            form2.dgvTips.Rows[index].Cells["clmnDate"].Value = tip.Date.ToString();
            form2.dgvTips.Rows[index].Cells["clmnName"].Value = tip.UserName;
            form2.dgvTips.Rows[index].Cells["clmnNumLikes"].Value = tip.NumLikes.ToString();
            form2.dgvTips.Rows[index].Cells["clmnReview"].Value = tip.TextReview;
        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            string businessID = dgvSearchResults.CurrentRow.Cells["clmnBID"].Value.ToString();
            string strsql = "SELECT DISTINCT date, name, number_of_likes, text_review " +
                "FROM Tips, Business, Users " +
                "WHERE Business.business_id = '" + businessID + "' AND Business.business_id = Tips.business_id AND Users.user_id = Tips.user_id;";
            form2 = new Form2(this);
            
            form2.Show();
           
            form2.dgvTips.Columns.Add("clmnDate", "Date");
            form2.dgvTips.Columns.Add("clmnName", "User Name");
            form2.dgvTips.Columns.Add("clmnNumLikes", "# of Likes");
            form2.dgvTips.Columns.Add("clmnReview", "Tip Content");

            form2.dgvTips.EnableHeadersVisualStyles = false;
            form2.dgvTips.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFDAF5");
            foreach (DataGridViewColumn column in form2.dgvTips.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            form2.dgvTips.Columns["clmnReview"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            

            form2.dgvTips.RowHeadersVisible = false;
            executeQuery(strsql, addTip);
        }

        private void txtboxCurrentUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                lstUsers.Items.Clear();
                string usersName = txtboxCurrentUser.Text;
                string strsql = "SELECT user_id" +
                    " FROM users " +
                    "WHERE name = '" + usersName + "'";
                executeQuery(strsql, addUsers);
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usersID = lstUsers.SelectedItem.ToString();

            string sqlstr = "SELECT average_stars, name, number_of_cool_votes,number_of_funny_votes, number_of_useful_votes, tip_count, fan_count,tip_likes, yelping_since " +
                "FROM users " +
                    "WHERE user_id = '" + usersID + "'";

            executeQuery(sqlstr, addUserInfo);
        }

        private void dgvSearchResults_Click(object sender, EventArgs e)
        {
            //string bid = dgvSearchResults.CurrentRow.Cells["clmnBID"].Value.ToString();
            StringBuilder mapSite = new StringBuilder("https://bing.com/maps");
            mapSite.Append("?q=");
          
            string address = dgvSearchResults.CurrentRow.Cells["clmnAddress"].Value.ToString();
            string businessName = dgvSearchResults.CurrentRow.Cells["clmnBName"].Value.ToString();

           
            if (businessName != String.Empty)
            {
                mapSite.Append(businessName + ",+");
            }
            if (address != String.Empty)
            {
                mapSite.Append(address);
            }

            webBrowser1.Navigate(mapSite.ToString());

        }


    }
}

