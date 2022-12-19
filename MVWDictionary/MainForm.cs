namespace MVWDictionary
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private System.Collections.Generic.Dictionary<string, string>[] m_Dictionaries = null;
        private DoWorks m_DoWorks = new DoWorks();
        //--------------------------------------------------------------------------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            try
            {
                m_Dictionaries = m_DoWorks.GetDictionaries();
                string[] SearchedStrings = m_DoWorks.GetSearchedWords();
                if (SearchedStrings != null)
                {
                    cboSearch.Items.AddRange(SearchedStrings);
                }
            }
            catch (System.Exception ex) { this.ShowError(ex.Message); }
        }

        private void MainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            { this.btnGo_Click(null, null); }
        }

        private void btnGo_Click(object sender, System.EventArgs e)
        {
            try
            {
                if ((!cboSearch.Items.Contains(cboSearch.Text)))
                    cboSearch.Items.Add(cboSearch.Text);
                string SearchString = cboSearch.Text;
                if (SearchString == string.Empty) return;
                string[] SearchRes = m_DoWorks.Search(m_Dictionaries, SearchString);
                SetResult(SearchRes);
            }
            catch (System.Exception ex) { this.ShowError(ex.Message); }
        }

        private void SetResult(string[] SearchRes)
        {
            txtResult.Text = string.Empty;
            foreach (string s in SearchRes)
            {
                txtResult.Text += "," + s;
            }
        }

        private void btnMenu_Click(object sender, System.EventArgs e)
        {
            Menu.Show(this, 210, 20);
        }

        private void rightToLeftToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (rightToLeftToolStripMenuItem.Checked)
            {
                txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else
                txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
        }

        private void spellingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                string ResStr = m_DoWorks.AlternativesSearchAllString(cboSearch.Text);
                if (ResStr == null) txtResult.Text = "کلمه پیدا نشد";
                else
                    txtResult.Text = ResStr;
            }
            catch (System.Exception ex) { this.ShowError(ex.Message); }
        }

        private void addGlossToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                AddGlossDlg AddGlossD = new AddGlossDlg();
                if (AddGlossD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    m_Dictionaries = m_DoWorks.GetDictionaries();
                }
            }
            catch (System.Exception ex) { this.ShowError(ex.Message); }
        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            try
            {
                System.Collections.Generic.List<string> SearchedStrings = new
                    System.Collections.Generic.List<string>();
                foreach (object o in cboSearch.Items)
                {
                    SearchedStrings.Add((string)o);
                }
                m_DoWorks.SaveSearchedWords(SearchedStrings.ToArray());
            }
            catch (System.Exception ex) { this.ShowError(ex.Message); }
        }

        private void removeGlossToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                DeleteGlossDialog DeleteDialog = new DeleteGlossDialog();
                if (DeleteDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    m_Dictionaries = m_DoWorks.GetDictionaries();
                }
            }
            catch (System.Exception ex) { this.ShowError(ex.Message); }
        }

        private void ShowError(string ExceptionMessage)
        {
            System.Windows.Forms.MessageBox.Show(ExceptionMessage, "Error",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
}
