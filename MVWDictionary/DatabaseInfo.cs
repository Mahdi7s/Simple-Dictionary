namespace MVWDictionary
{
    public enum SELECTED_PAGE { SQL_PAGE,ACCESS_PAGE}
    public partial class DatabaseInfo : System.Windows.Forms.UserControl
    {
        private SELECTED_PAGE m_SelectedPage = SELECTED_PAGE.SQL_PAGE;
        //--------------------------------------------------------------------
        public delegate void SqlInsatallingHandler(object sender, System.EventArgs e);
        public delegate void AccessInstallingHandler(object sender, System.EventArgs e);
        public event SqlInsatallingHandler SqlInstalling;
        public event AccessInstallingHandler AccessInstalling;
        //--------------------------------------------------------------------
        public DatabaseInfo()
        {
            InitializeComponent();
        }

        public string AccessProvider
        {
            get { return txtProvider_Access.Text; }
        }

        public string AccessDbPath
        {
            get { return txtDatabasePath_Access.Text; }
        }

        public string AccessTableName
        {
            get { return txtTableName_Access.Text; }
        }

        public string SqlServerName
        {
            get { return txtServerName_Sql.Text; }
        }

        public string SqlDatabaseName
        {
            get { return txtDatabaseName_Sql.Text; }
        }

        public string SqlTableName
        {
            get { return txtTableName_Sql.Text; }
        }

        public SELECTED_PAGE SelectedPage
        {
            get { return m_SelectedPage; }
            set
            {
                m_SelectedPage = value;
                if (m_SelectedPage == SELECTED_PAGE.SQL_PAGE)
                {
                    AccessPanel.Visible = false;
                    SqlPanel.Visible = true;
                }
                else
                {
                    SqlPanel.Visible = false;
                    AccessPanel.Visible = true;
                }
            }
        }

        private void btnInstall_Sql_Click(object sender, System.EventArgs e)
        {
            SqlInstalling(sender, e);
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OpenDlg = new
                System.Windows.Forms.OpenFileDialog();
            OpenDlg.RestoreDirectory = true;
            OpenDlg.Filter = "Access Files (*.mdb)|*.mdb|(*.accdb)|*.accdb|All Files (*.*)|*.*";
            if (OpenDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDatabasePath_Access.Text = OpenDlg.FileName;
            }
        }

        private void btnInstall_Access_Click(object sender, System.EventArgs e)
        {
            AccessInstalling(sender, e);
        }
    }
}
