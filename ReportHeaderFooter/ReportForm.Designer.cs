namespace ReportHeaderFooter
{
    partial class ReportForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lstDoneFiles = new ListBox();
            lstErrorFiles = new ListBox();
            lstReadyFiles = new ListBox();
            lstOutputFiles = new ListBox();
            btnStart = new Button();
            btnBrowseReadyFolder = new Button();
            txtReadyFolder = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnSaveSettings = new Button();
            btnBrowseDefaultFolder = new Button();
            txtDefaultReadyFolder = new TextBox();
            label4 = new Label();
            btnBrowseFooterImage = new Button();
            txtFooterImageFile = new TextBox();
            label3 = new Label();
            btnBrowseHeaderImage = new Button();
            txtHeaderImageFile = new TextBox();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 561);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnStart);
            tabPage1.Controls.Add(btnBrowseReadyFolder);
            tabPage1.Controls.Add(txtReadyFolder);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(975, 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Process";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lstReadyFiles);
            groupBox1.Controls.Add(lstOutputFiles);
            groupBox1.Location = new Point(8, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 447);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Processing";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDoneFiles);
            groupBox2.Controls.Add(lstErrorFiles);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(757, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 425);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Originals";
            // 
            // lstDoneFiles
            // 
            lstDoneFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstDoneFiles.BackColor = Color.Gainsboro;
            lstDoneFiles.FormattingEnabled = true;
            lstDoneFiles.ItemHeight = 15;
            lstDoneFiles.Location = new Point(3, 19);
            lstDoneFiles.Name = "lstDoneFiles";
            lstDoneFiles.Size = new Size(194, 214);
            lstDoneFiles.TabIndex = 6;
            // 
            // lstErrorFiles
            // 
            lstErrorFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstErrorFiles.BackColor = Color.FromArgb(255, 192, 192);
            lstErrorFiles.FormattingEnabled = true;
            lstErrorFiles.ItemHeight = 15;
            lstErrorFiles.Location = new Point(3, 253);
            lstErrorFiles.Name = "lstErrorFiles";
            lstErrorFiles.Size = new Size(194, 169);
            lstErrorFiles.TabIndex = 7;
            // 
            // lstReadyFiles
            // 
            lstReadyFiles.Dock = DockStyle.Left;
            lstReadyFiles.FormattingEnabled = true;
            lstReadyFiles.ItemHeight = 15;
            lstReadyFiles.Location = new Point(3, 19);
            lstReadyFiles.Name = "lstReadyFiles";
            lstReadyFiles.Size = new Size(229, 425);
            lstReadyFiles.TabIndex = 4;
            // 
            // lstOutputFiles
            // 
            lstOutputFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstOutputFiles.BackColor = Color.FromArgb(192, 255, 192);
            lstOutputFiles.FormattingEnabled = true;
            lstOutputFiles.ItemHeight = 15;
            lstOutputFiles.Location = new Point(238, 19);
            lstOutputFiles.Name = "lstOutputFiles";
            lstOutputFiles.Size = new Size(516, 424);
            lstOutputFiles.TabIndex = 5;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.MenuHighlight;
            btnStart.ForeColor = SystemColors.ButtonHighlight;
            btnStart.Location = new Point(92, 35);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(167, 39);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += ButtonStart_Click;
            // 
            // btnBrowseReadyFolder
            // 
            btnBrowseReadyFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseReadyFolder.Location = new Point(893, 6);
            btnBrowseReadyFolder.Name = "btnBrowseReadyFolder";
            btnBrowseReadyFolder.Size = new Size(75, 23);
            btnBrowseReadyFolder.TabIndex = 2;
            btnBrowseReadyFolder.Text = "Browse";
            btnBrowseReadyFolder.UseVisualStyleBackColor = true;
            btnBrowseReadyFolder.Click += ButtonBrowseReayFolder_Click;
            // 
            // txtReadyFolder
            // 
            txtReadyFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReadyFolder.Location = new Point(92, 6);
            txtReadyFolder.Name = "txtReadyFolder";
            txtReadyFolder.Size = new Size(790, 23);
            txtReadyFolder.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Ready Folder:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSaveSettings);
            tabPage2.Controls.Add(btnBrowseDefaultFolder);
            tabPage2.Controls.Add(txtDefaultReadyFolder);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(btnBrowseFooterImage);
            tabPage2.Controls.Add(txtFooterImageFile);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnBrowseHeaderImage);
            tabPage2.Controls.Add(txtHeaderImageFile);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(875, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = SystemColors.MenuHighlight;
            btnSaveSettings.ForeColor = SystemColors.HighlightText;
            btnSaveSettings.Location = new Point(117, 93);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(167, 39);
            btnSaveSettings.TabIndex = 9;
            btnSaveSettings.Text = "Save";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += ButtonSaveSettings_Click;
            // 
            // btnBrowseDefaultFolder
            // 
            btnBrowseDefaultFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseDefaultFolder.Location = new Point(793, 64);
            btnBrowseDefaultFolder.Name = "btnBrowseDefaultFolder";
            btnBrowseDefaultFolder.Size = new Size(75, 23);
            btnBrowseDefaultFolder.TabIndex = 8;
            btnBrowseDefaultFolder.Text = "Browse";
            btnBrowseDefaultFolder.UseVisualStyleBackColor = true;
            btnBrowseDefaultFolder.Click += btnBrowseDefaultFolder_Click;
            // 
            // txtDefaultReadyFolder
            // 
            txtDefaultReadyFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDefaultReadyFolder.Location = new Point(117, 64);
            txtDefaultReadyFolder.Name = "txtDefaultReadyFolder";
            txtDefaultReadyFolder.Size = new Size(670, 23);
            txtDefaultReadyFolder.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 68);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Default Folder:";
            // 
            // btnBrowseFooterImage
            // 
            btnBrowseFooterImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseFooterImage.Location = new Point(793, 35);
            btnBrowseFooterImage.Name = "btnBrowseFooterImage";
            btnBrowseFooterImage.Size = new Size(75, 23);
            btnBrowseFooterImage.TabIndex = 5;
            btnBrowseFooterImage.Text = "Browse";
            btnBrowseFooterImage.UseVisualStyleBackColor = true;
            btnBrowseFooterImage.Click += btnBrowseFooterImage_Click;
            // 
            // txtFooterImageFile
            // 
            txtFooterImageFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFooterImageFile.Location = new Point(117, 35);
            txtFooterImageFile.Name = "txtFooterImageFile";
            txtFooterImageFile.Size = new Size(670, 23);
            txtFooterImageFile.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 38);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 3;
            label3.Text = "Footer Image File:";
            // 
            // btnBrowseHeaderImage
            // 
            btnBrowseHeaderImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseHeaderImage.Location = new Point(793, 6);
            btnBrowseHeaderImage.Name = "btnBrowseHeaderImage";
            btnBrowseHeaderImage.Size = new Size(75, 23);
            btnBrowseHeaderImage.TabIndex = 2;
            btnBrowseHeaderImage.Text = "Browse";
            btnBrowseHeaderImage.UseVisualStyleBackColor = true;
            btnBrowseHeaderImage.Click += btnBrowseHeaderImage_Click;
            // 
            // txtHeaderImageFile
            // 
            txtHeaderImageFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHeaderImageFile.Location = new Point(117, 6);
            txtHeaderImageFile.Name = "txtHeaderImageFile";
            txtHeaderImageFile.Size = new Size(670, 23);
            txtHeaderImageFile.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 10);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 0;
            label2.Text = "Header Image File:";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tabControl1);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report - Header and Footer";
            Load += ReportForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnBrowseReadyFolder;
        private TextBox txtReadyFolder;
        private Label label1;
        private Button btnBrowseFooterImage;
        private TextBox txtFooterImageFile;
        private Label label3;
        private Button btnBrowseHeaderImage;
        private TextBox txtHeaderImageFile;
        private Label label2;
        private Button btnBrowseDefaultFolder;
        private TextBox txtDefaultReadyFolder;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnSaveSettings;
        private Button btnStart;
        private ListBox lstReadyFiles;
        private ListBox lstDoneFiles;
        private ListBox lstOutputFiles;
        private ListBox lstErrorFiles;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
