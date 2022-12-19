namespace MVWDictionary
{
    partial class InstallingSplashScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.picInstalling = new System.Windows.Forms.PictureBox();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picInstalling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(8, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installing";
            // 
            // picInstalling
            // 
            this.picInstalling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInstalling.Cursor = System.Windows.Forms.Cursors.Default;
            this.picInstalling.Image = global::MVWDictionary.Properties.Resources.status_anim;
            this.picInstalling.InitialImage = null;
            this.picInstalling.Location = new System.Drawing.Point(5, 29);
            this.picInstalling.Name = "picInstalling";
            this.picInstalling.Size = new System.Drawing.Size(100, 21);
            this.picInstalling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInstalling.TabIndex = 1;
            this.picInstalling.TabStop = false;
            // 
            // MyTimer
            // 
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // InstallingSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(108, 53);
            this.Controls.Add(this.picInstalling);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallingSplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstallingSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picInstalling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picInstalling;
        private System.Windows.Forms.Timer MyTimer;
    }
}