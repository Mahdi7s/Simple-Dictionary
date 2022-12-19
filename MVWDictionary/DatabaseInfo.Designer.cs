namespace MVWDictionary
{
    partial class DatabaseInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SqlPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabaseName_Sql = new System.Windows.Forms.TextBox();
            this.btnInstall_Sql = new System.Windows.Forms.Button();
            this.txtTableName_Sql = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName_Sql = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccessPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableName_Access = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnInstall_Access = new System.Windows.Forms.Button();
            this.txtDatabasePath_Access = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProvider_Access = new System.Windows.Forms.TextBox();
            this.SqlPanel.SuspendLayout();
            this.AccessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SqlPanel
            // 
            this.SqlPanel.Controls.Add(this.label3);
            this.SqlPanel.Controls.Add(this.txtDatabaseName_Sql);
            this.SqlPanel.Controls.Add(this.btnInstall_Sql);
            this.SqlPanel.Controls.Add(this.txtTableName_Sql);
            this.SqlPanel.Controls.Add(this.label2);
            this.SqlPanel.Controls.Add(this.txtServerName_Sql);
            this.SqlPanel.Controls.Add(this.label1);
            this.SqlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqlPanel.Location = new System.Drawing.Point(0, 0);
            this.SqlPanel.Name = "SqlPanel";
            this.SqlPanel.Size = new System.Drawing.Size(260, 148);
            this.SqlPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Database Name : ";
            // 
            // txtDatabaseName_Sql
            // 
            this.txtDatabaseName_Sql.Location = new System.Drawing.Point(108, 52);
            this.txtDatabaseName_Sql.Name = "txtDatabaseName_Sql";
            this.txtDatabaseName_Sql.Size = new System.Drawing.Size(129, 20);
            this.txtDatabaseName_Sql.TabIndex = 5;
            // 
            // btnInstall_Sql
            // 
            this.btnInstall_Sql.Location = new System.Drawing.Point(88, 113);
            this.btnInstall_Sql.Name = "btnInstall_Sql";
            this.btnInstall_Sql.Size = new System.Drawing.Size(75, 23);
            this.btnInstall_Sql.TabIndex = 4;
            this.btnInstall_Sql.Text = "Install";
            this.btnInstall_Sql.UseVisualStyleBackColor = true;
            this.btnInstall_Sql.Click += new System.EventHandler(this.btnInstall_Sql_Click);
            // 
            // txtTableName_Sql
            // 
            this.txtTableName_Sql.Location = new System.Drawing.Point(108, 78);
            this.txtTableName_Sql.Name = "txtTableName_Sql";
            this.txtTableName_Sql.Size = new System.Drawing.Size(129, 20);
            this.txtTableName_Sql.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ditionary Table : ";
            // 
            // txtServerName_Sql
            // 
            this.txtServerName_Sql.Location = new System.Drawing.Point(108, 23);
            this.txtServerName_Sql.Name = "txtServerName_Sql";
            this.txtServerName_Sql.Size = new System.Drawing.Size(129, 20);
            this.txtServerName_Sql.TabIndex = 1;
            this.txtServerName_Sql.Text = "(local)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name : ";
            // 
            // AccessPanel
            // 
            this.AccessPanel.Controls.Add(this.label5);
            this.AccessPanel.Controls.Add(this.txtTableName_Access);
            this.AccessPanel.Controls.Add(this.btnBrowse);
            this.AccessPanel.Controls.Add(this.btnInstall_Access);
            this.AccessPanel.Controls.Add(this.txtDatabasePath_Access);
            this.AccessPanel.Controls.Add(this.label4);
            this.AccessPanel.Controls.Add(this.label6);
            this.AccessPanel.Controls.Add(this.txtProvider_Access);
            this.AccessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccessPanel.Location = new System.Drawing.Point(0, 0);
            this.AccessPanel.Name = "AccessPanel";
            this.AccessPanel.Size = new System.Drawing.Size(260, 148);
            this.AccessPanel.TabIndex = 12;
            this.AccessPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Table Name : ";
            // 
            // txtTableName_Access
            // 
            this.txtTableName_Access.Location = new System.Drawing.Point(88, 78);
            this.txtTableName_Access.Name = "txtTableName_Access";
            this.txtTableName_Access.Size = new System.Drawing.Size(142, 20);
            this.txtTableName_Access.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(233, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(24, 20);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnInstall_Access
            // 
            this.btnInstall_Access.Location = new System.Drawing.Point(88, 104);
            this.btnInstall_Access.Name = "btnInstall_Access";
            this.btnInstall_Access.Size = new System.Drawing.Size(75, 23);
            this.btnInstall_Access.TabIndex = 4;
            this.btnInstall_Access.Text = "Install";
            this.btnInstall_Access.UseVisualStyleBackColor = true;
            this.btnInstall_Access.Click += new System.EventHandler(this.btnInstall_Access_Click);
            // 
            // txtDatabasePath_Access
            // 
            this.txtDatabasePath_Access.Location = new System.Drawing.Point(88, 50);
            this.txtDatabasePath_Access.Name = "txtDatabasePath_Access";
            this.txtDatabasePath_Access.Size = new System.Drawing.Size(142, 20);
            this.txtDatabasePath_Access.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Path : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Provider : ";
            // 
            // txtProvider_Access
            // 
            this.txtProvider_Access.Location = new System.Drawing.Point(88, 20);
            this.txtProvider_Access.Name = "txtProvider_Access";
            this.txtProvider_Access.Size = new System.Drawing.Size(142, 20);
            this.txtProvider_Access.TabIndex = 0;
            this.txtProvider_Access.Text = "Microsoft.ACE.OLEDB.12.0";
            // 
            // DatabaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AccessPanel);
            this.Controls.Add(this.SqlPanel);
            this.Name = "DatabaseInfo";
            this.Size = new System.Drawing.Size(260, 148);
            this.SqlPanel.ResumeLayout(false);
            this.SqlPanel.PerformLayout();
            this.AccessPanel.ResumeLayout(false);
            this.AccessPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SqlPanel;
        private System.Windows.Forms.TextBox txtTableName_Sql;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerName_Sql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInstall_Sql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabaseName_Sql;
        private System.Windows.Forms.Panel AccessPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTableName_Access;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnInstall_Access;
        private System.Windows.Forms.TextBox txtDatabasePath_Access;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProvider_Access;
    }
}
