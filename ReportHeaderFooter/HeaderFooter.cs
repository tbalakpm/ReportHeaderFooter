using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;

namespace ReportHeaderFooter
{
    internal class FileListEvemtArgs : EventArgs
    {
        public string[] Files { get; set; }

        public FileListEvemtArgs(string[] files)
        {
            Files = files;
        }
    }

    internal class ProcessEventArgs : EventArgs
    {
        public string PdfFileName { get; set; }
        public string Status { get; set; }

        public ProcessEventArgs(string pdfFileName, string status)
        {
            this.PdfFileName = pdfFileName;
            this.Status = status;
        }
    }

    internal class HeaderFooterImage
    {
        private readonly string _readyFolder;
        private readonly string _headerImagePath;
        private readonly string _footerImagePath;

        private readonly string _outputFolder;
        private readonly string _doneFolder;
        private readonly string _errorFolder;

        #region Events

        public delegate void ListFilesHandler(object sender, FileListEvemtArgs e);

        public event ListFilesHandler? ListFiles;

        public delegate void ProcessingHandler(object sender, ProcessEventArgs e);

        public event ProcessingHandler? Processing;

        public delegate void ProcessedHandler(object sender, ProcessEventArgs e);

        public event ProcessedHandler? Processed;

        protected virtual void OnFileListing(string[] files)
        {
            FileListEvemtArgs e = new FileListEvemtArgs(files);
            ListFiles?.Invoke(this, e);
        }

        protected virtual void OnProcessing(string pdfFileName)
        {
            ProcessEventArgs e = new ProcessEventArgs(pdfFileName, "Processing");
            Processing?.Invoke(this, e);
        }

        protected virtual void OnProcessed(string pdfFileName, string status)
        {
            ProcessEventArgs e = new ProcessEventArgs(pdfFileName, status);
            Processed?.Invoke(this, e);
        }

        #endregion Events

        public HeaderFooterImage(string readyFolder, string headerImagePath, string footerImagePath)
        {
            _readyFolder = readyFolder;
            _headerImagePath = headerImagePath;
            _footerImagePath = footerImagePath;

            string baseFolder = GetBaseFolder(readyFolder);

            _outputFolder = Path.Combine(baseFolder, "Output");
            _doneFolder = Path.Combine(baseFolder, "Done");
            _errorFolder = Path.Combine(baseFolder, "Error");

            Directory.CreateDirectory(_outputFolder);
            Directory.CreateDirectory(_doneFolder);
            Directory.CreateDirectory(_errorFolder);
        }

        public void StartProcess()
        {
            string[] readyFiles = Directory.GetFiles(_readyFolder, "*.pdf");
            OnFileListing(readyFiles);
            foreach (string inputPdfFile in readyFiles)
            {
                string inputFileName = Path.GetFileName(inputPdfFile);
                string outputFileName = GetOutFileName(_doneFolder, inputFileName);

                string outputFilePath = Path.Combine(_outputFolder, outputFileName);
                string doneFilePath = Path.Combine(_doneFolder, outputFileName);
                string errorFilePath = Path.Combine(_errorFolder, outputFileName);
                try
                {
                    OnProcessing(inputPdfFile);
                    AddImageToPdf(inputPdfFile, outputFilePath, _headerImagePath, _footerImagePath, 0, 0, 595, 50);
                    File.Move(inputPdfFile, doneFilePath, false);
                    OnProcessed(inputPdfFile, "Done");
                }
                catch (Exception)
                {
                    File.Move(inputPdfFile, errorFilePath, true);   // overwrite file exists, if error
                    OnProcessed(inputPdfFile, "Error");
                }
            }
        }

        private static string GetBaseFolder(string readyPath)
        {
            return Path.GetDirectoryName(readyPath)!;
        }

        private static string GetOutFileName(string path, string fileName)
        {
            string baseFilename = Path.GetFileNameWithoutExtension(fileName);
            var files = Directory.GetFiles(path, $"{baseFilename}*.pdf");
            return files.Length == 0 ? fileName : $"{baseFilename}_{files.Length}.pdf";
        }

        private static void AddImageToPdf(string existingPdfPath, string outputPdfPath,
            string headerImagePath, string footerImagePath,
            double x, double y, double width, double height)
        {
            // Open the existing PDF
            PdfDocument document = PdfReader.Open(existingPdfPath, PdfDocumentOpenMode.Modify);

            // Load the header image
            XImage headerImage = XImage.FromFile(headerImagePath);
            // Load the footer image
            XImage footerImage = XImage.FromFile(footerImagePath);

            // Iterate through all pages
            foreach (PdfPage page in document.Pages)
            {
                // Create a graphics object for drawing
                using (XGraphics gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Append))
                {
                    // Header
                    gfx.DrawImage(headerImage, x, y, width, height);

                    // Footer - Draw the image at (x, y) with specified size
                    gfx.DrawImage(footerImage, x, page.Height.Point - y - height, width - 80, height);
                }
            }
            // Save the modified document
            //string outputFolder = Path.GetDirectoryName(outputPdfPath)!;
            //string outputFileName = Path.GetFileName(outputPdfPath);
            document.Save(outputPdfPath);    // GetOutFileName(outputFolder, outputFileName)
        }
    }
}