using ReportHeaderFooter.Properties;

using System.Configuration;

namespace ReportHeaderFooter
{
    public partial class ReportForm : Form
    {
        private HeaderFooterImage _headerFooterImage;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            RestoreSettings();
        }

        private void ButtonBrowseReayFolder_Click(object sender, EventArgs e)
        {
            txtReadyFolder.Text = GetFilePath();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            StartProcess();
        }

        private void StartProcess()
        {
            _headerFooterImage = new HeaderFooterImage(txtReadyFolder.Text, txtHeaderImageFile.Text, txtFooterImageFile.Text);
            _headerFooterImage.StartProcess();
        }

        #region Settings - Save

        private void btnBrowseHeaderImage_Click(object sender, EventArgs e)
        {
            txtHeaderImageFile.Text = GetFilePath();
        }

        private void btnBrowseFooterImage_Click(object sender, EventArgs e)
        {
            txtFooterImageFile.Text = GetFilePath();
        }

        private void btnBrowseDefaultFolder_Click(object sender, EventArgs e)
        {
            txtDefaultReadyFolder.Text = GetFolderPath();
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void RestoreSettings()
        {
            txtHeaderImageFile.Text = ConfigurationManager.AppSettings["HeaderImageFilePath"];
            txtFooterImageFile.Text = ConfigurationManager.AppSettings["FooterImageFilePath"];
            txtDefaultReadyFolder.Text = ConfigurationManager.AppSettings["DefaultReadyFolder"];

            txtReadyFolder.Text = txtDefaultReadyFolder.Text;
        }

        private void SaveSettings()
        {
            ////ConfigurationManager.AppSettings["HeaderImageFilePath"] = txtHeaderImageFile.Text;
            ////ConfigurationManager.AppSettings["FooterImageFilePath"] = txtFooterImageFile.Text;
            ////ConfigurationManager.AppSettings["DefaultReadyFolder"] = txtDefaultReadyFolder.Text;
            ////Settings.Default.HeaderImageFilePath = txtHeaderImageFile.Text;
            ////Settings.Default.FooterImageFilePath = txtFooterImageFile.Text;
            ////Settings.Default.DefaultReadyFolder = txtDefaultReadyFolder.Text;
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["HeaderImageFilePath"].Value = txtHeaderImageFile.Text;
            configuration.AppSettings.Settings["FooterImageFilePath"].Value = txtFooterImageFile.Text;
            configuration.AppSettings.Settings["DefaultReadyFolder"].Value = txtDefaultReadyFolder.Text;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        #endregion Settings - Save

        #region Browse - file dialog

        private string GetFilePath()
        {
            openFileDialog1.ShowDialog();
            return openFileDialog1.FileName;
        }

        private string GetFolderPath()
        {
            folderBrowserDialog1.ShowDialog();
            return folderBrowserDialog1.SelectedPath;
        }

        #endregion Browse - file dialog
    }
}