namespace MVWDictionary
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.MVWToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboSearch = new System.Windows.Forms.ToolStripComboBox();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenu = new System.Windows.Forms.ToolStripButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addGlossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGlossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MVWToolStrip.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MVWToolStrip
            // 
            this.MVWToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboSearch,
            this.btnGo,
            this.toolStripSeparator1,
            this.btnMenu});
            this.MVWToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MVWToolStrip.Name = "MVWToolStrip";
            this.MVWToolStrip.Size = new System.Drawing.Size(289, 25);
            this.MVWToolStrip.TabIndex = 0;
            this.MVWToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Search : ";
            // 
            // cboSearch
            // 
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboSearch.Size = new System.Drawing.Size(121, 25);
            // 
            // btnGo
            // 
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGo.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(26, 22);
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMenu
            // 
            this.btnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 22);
            this.btnMenu.Text = "menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = true;
            this.txtResult.BackColor = System.Drawing.SystemColors.Info;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 25);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(289, 133);
            this.txtResult.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGlossToolStripMenuItem,
            this.removeGlossToolStripMenuItem,
            this.rightToLeftToolStripMenuItem,
            this.spellingToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.Size = new System.Drawing.Size(172, 114);
            // 
            // addGlossToolStripMenuItem
            // 
            this.addGlossToolStripMenuItem.Name = "addGlossToolStripMenuItem";
            this.addGlossToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addGlossToolStripMenuItem.Text = "Add Gloss...";
            this.addGlossToolStripMenuItem.Click += new System.EventHandler(this.addGlossToolStripMenuItem_Click);
            // 
            // removeGlossToolStripMenuItem
            // 
            this.removeGlossToolStripMenuItem.Name = "removeGlossToolStripMenuItem";
            this.removeGlossToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.removeGlossToolStripMenuItem.Text = "Remove Gloss...";
            this.removeGlossToolStripMenuItem.Click += new System.EventHandler(this.removeGlossToolStripMenuItem_Click);
            // 
            // rightToLeftToolStripMenuItem
            // 
            this.rightToLeftToolStripMenuItem.CheckOnClick = true;
            this.rightToLeftToolStripMenuItem.Name = "rightToLeftToolStripMenuItem";
            this.rightToLeftToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rightToLeftToolStripMenuItem.Text = "Right To Left";
            this.rightToLeftToolStripMenuItem.Click += new System.EventHandler(this.rightToLeftToolStripMenuItem_Click);
            // 
            // spellingToolStripMenuItem
            // 
            this.spellingToolStripMenuItem.Name = "spellingToolStripMenuItem";
            this.spellingToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.spellingToolStripMenuItem.Text = "Spelling Alternatives";
            this.spellingToolStripMenuItem.Click += new System.EventHandler(this.spellingToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 158);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.MVWToolStrip);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(297, 192);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVW Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MVWToolStrip.ResumeLayout(false);
            this.MVWToolStrip.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MVWToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboSearch;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMenu;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem addGlossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGlossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellingToolStripMenuItem;
    }
}

