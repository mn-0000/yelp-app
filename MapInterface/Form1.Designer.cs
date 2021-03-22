
namespace MapInterface
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.infoContainer = new System.Windows.Forms.SplitContainer();
            this.programLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoContainer)).BeginInit();
            this.infoContainer.Panel1.SuspendLayout();
            this.infoContainer.Panel2.SuspendLayout();
            this.infoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.infoContainer);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.webView);
            this.splitContainer.Size = new System.Drawing.Size(1022, 538);
            this.splitContainer.SplitterDistance = 236;
            this.splitContainer.TabIndex = 0;
            // 
            // infoContainer
            // 
            this.infoContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoContainer.Location = new System.Drawing.Point(0, 0);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // infoContainer.Panel1
            // 
            this.infoContainer.Panel1.Controls.Add(this.programLabel);
            // 
            // infoContainer.Panel2
            // 
            this.infoContainer.Panel2.Controls.Add(this.label3);
            this.infoContainer.Panel2.Controls.Add(this.txtCountry);
            this.infoContainer.Panel2.Controls.Add(this.btnSearch);
            this.infoContainer.Panel2.Controls.Add(this.label2);
            this.infoContainer.Panel2.Controls.Add(this.label1);
            this.infoContainer.Panel2.Controls.Add(this.txtState);
            this.infoContainer.Panel2.Controls.Add(this.txtCity);
            this.infoContainer.Size = new System.Drawing.Size(236, 538);
            this.infoContainer.SplitterDistance = 117;
            this.infoContainer.TabIndex = 0;
            // 
            // programLabel
            // 
            this.programLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.programLabel.AutoSize = true;
            this.programLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programLabel.Location = new System.Drawing.Point(12, 31);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(129, 40);
            this.programLabel.TabIndex = 0;
            this.programLabel.Text = "Welcome to\r\nMaps!";
            this.programLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(42, 237);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "State/Province";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "City";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(42, 127);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(139, 22);
            this.txtState.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(42, 67);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(139, 22);
            this.txtCity.TabIndex = 0;
            // 
            // webView
            // 
            this.webView.BackColor = System.Drawing.SystemColors.Window;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(780, 536);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(42, 187);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(139, 22);
            this.txtCountry.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 538);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.infoContainer.Panel1.ResumeLayout(false);
            this.infoContainer.Panel1.PerformLayout();
            this.infoContainer.Panel2.ResumeLayout(false);
            this.infoContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoContainer)).EndInit();
            this.infoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.SplitContainer infoContainer;
        private System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry;
    }
}

