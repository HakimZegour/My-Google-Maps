using System.Windows.Forms;

namespace LoginForm
{
    partial class frmLoggedin
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.buttonAddFavorites = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textboxZipCode = new System.Windows.Forms.TextBox();
            this.textboxState = new System.Windows.Forms.TextBox();
            this.textboxCity = new System.Windows.Forms.TextBox();
            this.textboxStreet = new System.Windows.Forms.TextBox();
            this.labelZipcode = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.tabPageFavorites = new System.Windows.Forms.TabPage();
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageFavorites.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonLogout);
            this.splitContainer1.Panel1.Controls.Add(this.labelWelcome);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Red;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(88, 51);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(74, 36);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(88, 25);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(74, 13);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "labelWelcome";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageFavorites);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.buttonAddFavorites);
            this.tabPageSearch.Controls.Add(this.buttonSearch);
            this.tabPageSearch.Controls.Add(this.textboxZipCode);
            this.tabPageSearch.Controls.Add(this.textboxState);
            this.tabPageSearch.Controls.Add(this.textboxCity);
            this.tabPageSearch.Controls.Add(this.textboxStreet);
            this.tabPageSearch.Controls.Add(this.labelZipcode);
            this.tabPageSearch.Controls.Add(this.labelState);
            this.tabPageSearch.Controls.Add(this.labelCity);
            this.tabPageSearch.Controls.Add(this.labelStreet);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(258, 323);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // buttonAddFavorites
            // 
            this.buttonAddFavorites.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddFavorites.ForeColor = System.Drawing.Color.White;
            this.buttonAddFavorites.Location = new System.Drawing.Point(99, 240);
            this.buttonAddFavorites.Name = "buttonAddFavorites";
            this.buttonAddFavorites.Size = new System.Drawing.Size(100, 43);
            this.buttonAddFavorites.TabIndex = 9;
            this.buttonAddFavorites.Text = "Add to favorites";
            this.buttonAddFavorites.UseVisualStyleBackColor = false;
            this.buttonAddFavorites.Click += new System.EventHandler(this.buttonAddFavorites_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(99, 200);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textboxZipCode
            // 
            this.textboxZipCode.Location = new System.Drawing.Point(99, 157);
            this.textboxZipCode.Name = "textboxZipCode";
            this.textboxZipCode.Size = new System.Drawing.Size(100, 20);
            this.textboxZipCode.TabIndex = 7;
            this.textboxZipCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // textboxState
            // 
            this.textboxState.Location = new System.Drawing.Point(99, 117);
            this.textboxState.Name = "textboxState";
            this.textboxState.Size = new System.Drawing.Size(100, 20);
            this.textboxState.TabIndex = 6;
            this.textboxState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // textboxCity
            // 
            this.textboxCity.Location = new System.Drawing.Point(99, 77);
            this.textboxCity.Name = "textboxCity";
            this.textboxCity.Size = new System.Drawing.Size(100, 20);
            this.textboxCity.TabIndex = 5;
            this.textboxCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // textboxStreet
            // 
            this.textboxStreet.Location = new System.Drawing.Point(99, 37);
            this.textboxStreet.Name = "textboxStreet";
            this.textboxStreet.Size = new System.Drawing.Size(100, 20);
            this.textboxStreet.TabIndex = 4;
            this.textboxStreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // labelZipcode
            // 
            this.labelZipcode.AutoSize = true;
            this.labelZipcode.Location = new System.Drawing.Point(35, 160);
            this.labelZipcode.Name = "labelZipcode";
            this.labelZipcode.Size = new System.Drawing.Size(50, 13);
            this.labelZipcode.TabIndex = 3;
            this.labelZipcode.Text = "Zip Code";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(35, 120);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(35, 80);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "City";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(35, 40);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(35, 13);
            this.labelStreet.TabIndex = 0;
            this.labelStreet.Text = "Street";
            // 
            // tabPageFavorites
            // 
            this.tabPageFavorites.Controls.Add(this.listBoxFavorites);
            this.tabPageFavorites.Location = new System.Drawing.Point(4, 22);
            this.tabPageFavorites.Name = "tabPageFavorites";
            this.tabPageFavorites.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFavorites.Size = new System.Drawing.Size(258, 323);
            this.tabPageFavorites.TabIndex = 1;
            this.tabPageFavorites.Text = "Favorites";
            this.tabPageFavorites.UseVisualStyleBackColor = true;
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.Items.AddRange(new object[] {
            "Marseille",
            "Toulouse"});
            this.listBoxFavorites.Location = new System.Drawing.Point(3, 3);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(252, 317);
            this.listBoxFavorites.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 323);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Items.AddRange(new object[] {
            "Paris",
            "Londres",
            "Berlin"});
            this.listBoxHistory.Location = new System.Drawing.Point(3, 3);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(252, 317);
            this.listBoxHistory.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(530, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // frmLoggedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLoggedin";
            this.Text = "frmLoggedin";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageFavorites.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageFavorites;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textboxZipCode;
        private System.Windows.Forms.TextBox textboxState;
        private System.Windows.Forms.TextBox textboxCity;
        private System.Windows.Forms.TextBox textboxStreet;
        private System.Windows.Forms.Label labelZipcode;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Button buttonAddFavorites;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxFavorites;
    }
}