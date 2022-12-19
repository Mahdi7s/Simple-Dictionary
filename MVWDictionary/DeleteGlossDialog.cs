namespace MVWDictionary
{
    public partial class DeleteGlossDialog : System.Windows.Forms.Form
    {
        private string m_GlossFolderPath = string.Empty;
        private string[] m_GlossPaths = null;
        private string[] m_ListItems = null;
        private bool m_DeletedSomeGloss = false;
        //-----------------------------------------------
        public DeleteGlossDialog()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            m_GlossFolderPath = System.Windows.Forms.Application.StartupPath + @"\Gloss\";
            Refresh();
        }

        private void SetGlossPathsAndListItems()
        {
            m_GlossPaths = System.IO.Directory.GetFiles(m_GlossFolderPath, "*.MVWD",
                System.IO.SearchOption.TopDirectoryOnly);

            m_ListItems = new string[m_GlossPaths.Length];
            int index = 0;
            foreach (string path in m_GlossPaths)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(path);
                m_ListItems[index++] = fInfo.Name.Substring(0, fInfo.Name.Length -
                    fInfo.Extension.Length);
            }
        }

        private void DeleteGloss(int GlossIndex)
        {
            try
            {
                System.IO.File.Delete(m_GlossPaths[GlossIndex]);
            }
            catch (System.Exception ex) { ShowError(ex.Message); return; }
            m_DeletedSomeGloss = true;
        }

        private void Refresh()
        {
            try
            {
                SetGlossPathsAndListItems();
                LstBoxForDeleting.Items.Clear();
                LstBoxForDeleting.Items.AddRange(m_ListItems);
            }
            catch (System.Exception ex) { ShowError(ex.Message); }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            DeleteGloss(LstBoxForDeleting.SelectedIndex);
            Refresh();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            Refresh();
        }

        private void ShowError(string error)
        {
            System.Windows.Forms.MessageBox.Show(error,"Error",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }

        private void btnDone_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void DeleteGlossDialog_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (m_DeletedSomeGloss)
                DialogResult = System.Windows.Forms.DialogResult.OK;
            else DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
