namespace MVWDictionary
{
    partial class AddGlossDlg
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
            this.rbAccessPage = new System.Windows.Forms.RadioButton();
            this.rbSqlPage = new System.Windows.Forms.RadioButton();
            this.databaseInfo1 = new MVWDictionary.DatabaseInfo();
            this.SuspendLayout();
            // 
            // rbAccessPage
            // 
            this.rbAccessPage.AutoSize = true;
            this.rbAccessPage.Location = new System.Drawing.Point(151, 152);
            this.rbAccessPage.Name = "rbAccessPage";
            this.rbAccessPage.Size = new System.Drawing.Size(87, 17);
            this.rbAccessPage.TabIndex = 1;
            this.rbAccessPage.Text = "Access page";
            this.rbAccessPage.UseVisualStyleBackColor = true;
            // 
            // rbSqlPage
            // 
            this.rbSqlPage.AutoSize = true;
            this.rbSqlPage.Checked = true;
            this.rbSqlPage.Location = new System.Drawing.Point(12, 152);
            this.rbSqlPage.Name = "rbSqlPage";
            this.rbSqlPage.Size = new System.Drawing.Size(67, 17);
            this.rbSqlPage.TabIndex = 2;
            this.rbSqlPage.TabStop = true;
            this.rbSqlPage.Text = "Sql page";
            this.rbSqlPage.UseVisualStyleBackColor = true;
            this.rbSqlPage.CheckedChanged += new System.EventHandler(this.rbSqlPage_CheckedChanged);
            // 
            // databaseInfo1
            // 
            this.databaseInfo1.Location = new System.Drawing.Point(-1, -2);
            this.databaseInfo1.Name = "databaseInfo1";
            this.databaseInfo1.SelectedPage = MVWDictionary.SELECTED_PAGE.SQL_PAGE;
            this.databaseInfo1.Size = new System.Drawing.Size(260, 148);
            this.databaseInfo1.TabIndex = 0;
            this.databaseInfo1.AccessInstalling += new MVWDictionary.DatabaseInfo.AccessInstallingHandler(this.databaseInfo1_AccessInstalling);
            this.databaseInfo1.SqlInstalling += new MVWDictionary.DatabaseInfo.SqlInsatallingHandler(this.databaseInfo1_SqlInstalling);
            // 
            // AddGlossDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 177);
            this.Controls.Add(this.rbSqlPage);
            this.Controls.Add(this.rbAccessPage);
            this.Controls.Add(this.databaseInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGlossDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Gloss Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseInfo databaseInfo1;
        private System.Windows.Forms.RadioButton rbAccessPage;
        private System.Windows.Forms.RadioButton rbSqlPage;


    }
}