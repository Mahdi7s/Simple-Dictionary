namespace MVWDictionary
{
    public partial class AddGlossDlg : System.Windows.Forms.Form
    {
        private DoWorks m_DoWorks = new DoWorks();
        private InstallingSplashScreen m_Wait = new InstallingSplashScreen();
        //--------------------------------------------------------------------
        public AddGlossDlg()
        {
            InitializeComponent();
        }

        private void databaseInfo1_SqlInstalling(object sender, System.EventArgs e)
        {
            m_Wait.Show(this, 10000);
            try
            {
                m_DoWorks.AddToGloss_SqlDb(databaseInfo1.SqlServerName,
                    databaseInfo1.SqlDatabaseName, databaseInfo1.SqlTableName,
                    databaseInfo1.SqlDatabaseName);
            }
            catch (System.Exception ex) { this.ShowErrorAndExit(ex.Message); }
        }

        private void databaseInfo1_AccessInstalling(object sender, System.EventArgs e)
        {
            m_Wait.Show(this,10000);
            try
            {
                System.IO.FileInfo finfo = new System.IO.FileInfo(databaseInfo1.AccessDbPath);
                string GlossName = finfo.Name.Substring(0,finfo.Name.Length - finfo.Extension.Length);
                m_DoWorks.AddToGloss_AccessDb(databaseInfo1.AccessProvider,
                    databaseInfo1.AccessDbPath, databaseInfo1.AccessTableName, GlossName);
                finfo = null;
            }
            catch (System.Exception ex) { this.ShowErrorAndExit(ex.Message); }
        }

        private void ShowErrorAndExit(string error)
        {
            m_Wait.Close();
            System.Windows.Forms.MessageBox.Show(error,"Error",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void rbSqlPage_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbSqlPage.Checked) databaseInfo1.SelectedPage = SELECTED_PAGE.SQL_PAGE;
            else databaseInfo1.SelectedPage = SELECTED_PAGE.ACCESS_PAGE;
        }
    }
}
