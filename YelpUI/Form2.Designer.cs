﻿
namespace YelpUI
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTips = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnLeaveTip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTips);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(900, 562);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvTips
            // 
            this.dgvTips.AllowUserToAddRows = false;
            this.dgvTips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTips.Location = new System.Drawing.Point(0, 0);
            this.dgvTips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTips.Name = "dgvTips";
            this.dgvTips.RowHeadersWidth = 51;
            this.dgvTips.RowTemplate.Height = 24;
            this.dgvTips.Size = new System.Drawing.Size(900, 452);
            this.dgvTips.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtTip);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnLeaveTip);
            this.splitContainer2.Size = new System.Drawing.Size(900, 105);
            this.splitContainer2.SplitterDistance = 543;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtTip
            // 
            this.txtTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTip.Location = new System.Drawing.Point(0, 0);
            this.txtTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTip.Multiline = true;
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(543, 105);
            this.txtTip.TabIndex = 0;
            this.txtTip.Text = "Leave your tip here...";
            this.txtTip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTip_MouseClick);
            // 
            // btnLeaveTip
            // 
            this.btnLeaveTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeaveTip.Location = new System.Drawing.Point(0, 0);
            this.btnLeaveTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeaveTip.Name = "btnLeaveTip";
            this.btnLeaveTip.Size = new System.Drawing.Size(353, 105);
            this.btnLeaveTip.TabIndex = 0;
            this.btnLeaveTip.Text = "Leave Tip";
            this.btnLeaveTip.UseVisualStyleBackColor = true;
            this.btnLeaveTip.Click += new System.EventHandler(this.btnLeaveTip_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTips)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.DataGridView dgvTips;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnLeaveTip;
    }
}