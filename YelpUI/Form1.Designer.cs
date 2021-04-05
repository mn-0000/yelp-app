﻿
namespace YelpUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstFilteringCategories = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstZipcode = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.lstState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.btnTip = new System.Windows.Forms.Button();
            this.btnSearchBusiness = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtboxlatitude = new System.Windows.Forms.TextBox();
            this.txtboxlongitude = new System.Windows.Forms.TextBox();
            this.txtBoxTipLikes = new System.Windows.Forms.TextBox();
            this.txtBoxTipCount = new System.Windows.Forms.TextBox();
            this.txtBoxUsefulVotes = new System.Windows.Forms.TextBox();
            this.txtBoxFunnyVotes = new System.Windows.Forms.TextBox();
            this.txtBoxCoolVotes = new System.Windows.Forms.TextBox();
            this.txtBoxYelpingSince = new System.Windows.Forms.TextBox();
            this.txtboxUserStars = new System.Windows.Forms.TextBox();
            this.txtboxUserName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.txtboxCurrentUser = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1330, 816);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1322, 783);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Business Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.splitContainer1.Size = new System.Drawing.Size(1316, 775);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstFilteringCategories);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lstCategories);
            this.groupBox2.Location = new System.Drawing.Point(14, 428);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(248, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Business Categories";
            // 
            // lstFilteringCategories
            // 
            this.lstFilteringCategories.FormattingEnabled = true;
            this.lstFilteringCategories.ItemHeight = 20;
            this.lstFilteringCategories.Location = new System.Drawing.Point(11, 242);
            this.lstFilteringCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstFilteringCategories.Name = "lstFilteringCategories";
            this.lstFilteringCategories.Size = new System.Drawing.Size(224, 84);
            this.lstFilteringCategories.TabIndex = 7;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(133, 205);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 29);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 205);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 20;
            this.lstCategories.Location = new System.Drawing.Point(11, 34);
            this.lstCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(224, 164);
            this.lstCategories.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lstZipcode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstCity);
            this.groupBox1.Controls.Add(this.lstState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(248, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Business Location";
            // 
            // lstZipcode
            // 
            this.lstZipcode.FormattingEnabled = true;
            this.lstZipcode.ItemHeight = 20;
            this.lstZipcode.Location = new System.Drawing.Point(11, 266);
            this.lstZipcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstZipcode.Name = "lstZipcode";
            this.lstZipcode.Size = new System.Drawing.Size(224, 124);
            this.lstZipcode.TabIndex = 5;
            this.lstZipcode.SelectedIndexChanged += new System.EventHandler(this.lstZipcode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zipcode:";
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 20;
            this.lstCity.Location = new System.Drawing.Point(11, 104);
            this.lstCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(224, 124);
            this.lstCity.TabIndex = 3;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // lstState
            // 
            this.lstState.FormattingEnabled = true;
            this.lstState.Location = new System.Drawing.Point(124, 32);
            this.lstState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(112, 28);
            this.lstState.TabIndex = 2;
            this.lstState.SelectedIndexChanged += new System.EventHandler(this.lstState_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "State:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvSearchResults);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnTip);
            this.splitContainer2.Panel2.Controls.Add(this.btnSearchBusiness);
            this.splitContainer2.Size = new System.Drawing.Size(1113, 775);
            this.splitContainer2.SplitterDistance = 731;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchResults.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.RowTemplate.Height = 24;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(1113, 731);
            this.dgvSearchResults.TabIndex = 0;
            this.dgvSearchResults.Click += new System.EventHandler(this.dgvSearchResults_Click);
            // 
            // btnTip
            // 
            this.btnTip.AutoSize = true;
            this.btnTip.Location = new System.Drawing.Point(178, 0);
            this.btnTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(171, 39);
            this.btnTip.TabIndex = 1;
            this.btnTip.Text = "Show Tips";
            this.btnTip.UseVisualStyleBackColor = true;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
            // 
            // btnSearchBusiness
            // 
            this.btnSearchBusiness.AutoSize = true;
            this.btnSearchBusiness.Location = new System.Drawing.Point(0, 0);
            this.btnSearchBusiness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBusiness.Name = "btnSearchBusiness";
            this.btnSearchBusiness.Size = new System.Drawing.Size(171, 39);
            this.btnSearchBusiness.TabIndex = 0;
            this.btnSearchBusiness.Text = "Search Business";
            this.btnSearchBusiness.UseVisualStyleBackColor = true;
            this.btnSearchBusiness.Click += new System.EventHandler(this.btnSearchBusiness_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1322, 783);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "User Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtboxlatitude);
            this.groupBox4.Controls.Add(this.txtboxlongitude);
            this.groupBox4.Controls.Add(this.txtBoxTipLikes);
            this.groupBox4.Controls.Add(this.txtBoxTipCount);
            this.groupBox4.Controls.Add(this.txtBoxUsefulVotes);
            this.groupBox4.Controls.Add(this.txtBoxFunnyVotes);
            this.groupBox4.Controls.Add(this.txtBoxCoolVotes);
            this.groupBox4.Controls.Add(this.txtBoxYelpingSince);
            this.groupBox4.Controls.Add(this.txtboxUserStars);
            this.groupBox4.Controls.Add(this.txtboxUserName);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(233, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 380);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User Information";
            // 
            // txtboxlatitude
            // 
            this.txtboxlatitude.Location = new System.Drawing.Point(151, 342);
            this.txtboxlatitude.Name = "txtboxlatitude";
            this.txtboxlatitude.Size = new System.Drawing.Size(174, 26);
            this.txtboxlatitude.TabIndex = 21;
            // 
            // txtboxlongitude
            // 
            this.txtboxlongitude.Location = new System.Drawing.Point(151, 313);
            this.txtboxlongitude.Name = "txtboxlongitude";
            this.txtboxlongitude.Size = new System.Drawing.Size(174, 26);
            this.txtboxlongitude.TabIndex = 20;
            // 
            // txtBoxTipLikes
            // 
            this.txtBoxTipLikes.Location = new System.Drawing.Point(151, 242);
            this.txtBoxTipLikes.Name = "txtBoxTipLikes";
            this.txtBoxTipLikes.Size = new System.Drawing.Size(58, 26);
            this.txtBoxTipLikes.TabIndex = 19;
            // 
            // txtBoxTipCount
            // 
            this.txtBoxTipCount.Location = new System.Drawing.Point(118, 207);
            this.txtBoxTipCount.Name = "txtBoxTipCount";
            this.txtBoxTipCount.Size = new System.Drawing.Size(54, 26);
            this.txtBoxTipCount.TabIndex = 18;
            // 
            // txtBoxUsefulVotes
            // 
            this.txtBoxUsefulVotes.Location = new System.Drawing.Point(228, 175);
            this.txtBoxUsefulVotes.Name = "txtBoxUsefulVotes";
            this.txtBoxUsefulVotes.Size = new System.Drawing.Size(36, 26);
            this.txtBoxUsefulVotes.TabIndex = 17;
            // 
            // txtBoxFunnyVotes
            // 
            this.txtBoxFunnyVotes.Location = new System.Drawing.Point(173, 175);
            this.txtBoxFunnyVotes.Name = "txtBoxFunnyVotes";
            this.txtBoxFunnyVotes.Size = new System.Drawing.Size(36, 26);
            this.txtBoxFunnyVotes.TabIndex = 16;
            // 
            // txtBoxCoolVotes
            // 
            this.txtBoxCoolVotes.Location = new System.Drawing.Point(120, 175);
            this.txtBoxCoolVotes.Name = "txtBoxCoolVotes";
            this.txtBoxCoolVotes.Size = new System.Drawing.Size(36, 26);
            this.txtBoxCoolVotes.TabIndex = 15;
            // 
            // txtBoxYelpingSince
            // 
            this.txtBoxYelpingSince.Location = new System.Drawing.Point(139, 112);
            this.txtBoxYelpingSince.Name = "txtBoxYelpingSince";
            this.txtBoxYelpingSince.Size = new System.Drawing.Size(186, 26);
            this.txtBoxYelpingSince.TabIndex = 14;
            // 
            // txtboxUserStars
            // 
            this.txtboxUserStars.Location = new System.Drawing.Point(88, 69);
            this.txtboxUserStars.Name = "txtboxUserStars";
            this.txtboxUserStars.Size = new System.Drawing.Size(100, 26);
            this.txtboxUserStars.TabIndex = 13;
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.Location = new System.Drawing.Point(88, 37);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.Size = new System.Drawing.Size(100, 26);
            this.txtboxUserName.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "longitude";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "latitude";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Location:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Total Tip Likes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tip Count:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "useful:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "cool:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "funny:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Votes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Yelping Since: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stars";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstUsers);
            this.groupBox3.Controls.Add(this.txtboxCurrentUser);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 349);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Current User";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(6, 67);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(185, 264);
            this.lstUsers.TabIndex = 23;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // txtboxCurrentUser
            // 
            this.txtboxCurrentUser.Location = new System.Drawing.Point(0, 25);
            this.txtboxCurrentUser.Name = "txtboxCurrentUser";
            this.txtboxCurrentUser.Size = new System.Drawing.Size(191, 26);
            this.txtboxCurrentUser.TabIndex = 22;
            this.txtboxCurrentUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxCurrentUser_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.webBrowser1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1322, 783);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Map";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1322, 783);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 816);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.ComboBox lstState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstZipcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSearchBusiness;
        private System.Windows.Forms.ListBox lstFilteringCategories;
        private System.Windows.Forms.Button btnTip;
        internal System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxUsefulVotes;
        private System.Windows.Forms.TextBox txtBoxFunnyVotes;
        private System.Windows.Forms.TextBox txtBoxCoolVotes;
        private System.Windows.Forms.TextBox txtBoxYelpingSince;
        private System.Windows.Forms.TextBox txtboxUserStars;
        private System.Windows.Forms.TextBox txtboxUserName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtboxlatitude;
        private System.Windows.Forms.TextBox txtboxlongitude;
        private System.Windows.Forms.TextBox txtBoxTipLikes;
        private System.Windows.Forms.TextBox txtBoxTipCount;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtboxCurrentUser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

