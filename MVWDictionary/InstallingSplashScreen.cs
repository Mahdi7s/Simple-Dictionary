namespace MVWDictionary
{
    public partial class InstallingSplashScreen : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form m_AddGlossForm = 
            new System.Windows.Forms.Form();
        //----------------------------------------------------
        public InstallingSplashScreen()
        {
            InitializeComponent();
        }

        public void Show(System.Windows.Forms.Form GlossDialog,int LenthSecond)
        {
            m_AddGlossForm = GlossDialog;
            MyTimer.Interval = LenthSecond;
            this.Show();
            MyTimer.Enabled = true;
        }

        private void MyTimer_Tick(object sender, System.EventArgs e)
        {
            MyTimer.Enabled = false; this.Close();
            m_AddGlossForm.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
