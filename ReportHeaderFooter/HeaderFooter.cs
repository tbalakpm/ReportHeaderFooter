using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;

namespace ReportHeaderFooter
{
    internal class ProcessEventArgs : EventArgs
    {
        public string PdfFilename { get; set; }
        public string Status { get; set; }

        public ProcessEventArgs(string pdfFilename, string status)
        {
            this.PdfFilename = pdfFilename;
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

        public delegate void ProcessingHandler(object sender, ProcessEventArgs e);

        public event ProcessingHandler? Processing;

        public delegate void ProcessedHandler(object sender, ProcessEventArgs e);

        public event ProcessedHandler? Processed;

        protected virtual void OnProcessing(string pdfFilename)
        {
            ProcessEventArgs e = new ProcessEventArgs(pdfFilename, "Processing");
            Processing?.Invoke(this, e);
        }

        protected virtual void OnProcessed(string pdfFilename, string status)
        {
            ProcessEventArgs e = new ProcessEventArgs(pdfFilename, status);
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
            foreach (string inputPdfFile in readyFiles)
            {
                string outputFilename = Path.Combine(_outputFolder, Path.GetFileName(inputPdfFile));
                string doneFilename = Path.Combine(_doneFolder, Path.GetFileName(inputPdfFile));
                string errorFilename = Path.Combine(_errorFolder, Path.GetFileName(inputPdfFile));
                try
                {
                    OnProcessing(inputPdfFile);
                    AddImageToPdf(inputPdfFile, outputFilename, _headerImagePath, _footerImagePath, 0, 0, 595, 50);
                    File.Move(inputPdfFile, doneFilename, false);
                    OnProcessed(inputPdfFile, "Done");
                }
                catch (Exception)
                {
                    File.Move(inputPdfFile, errorFilename, false);
                    OnProcessed(inputPdfFile, "Error");
                }
            }
        }

        private static string GetBaseFolder(string readyPath)
        {
            return Path.GetDirectoryName(readyPath)!;
        }

        private static void AddImageToPdf(string existingPdfPath, string outputPdfPath,
            string headerImagePath, string footerImagePath,
            double x, double y, double width, double height)
        {
            // Open the existing PDF
            PdfDocument document = PdfReader.Open(existingPdfPath, PdfDocumentOpenMode.Modify);

            // Select the first page
            PdfPage page = document.Pages[0];

            // Create a graphics object for drawing
            using (XGraphics gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Append))
            {
                // Load the header image
                XImage headerImage = XImage.FromFile(headerImagePath);

                // Header
                gfx.DrawImage(headerImage, x, y, width, height);

                // Load the footer image
                XImage footerImage = XImage.FromFile(footerImagePath);
                // Draw the image at (x, y) with specified size
                gfx.DrawImage(footerImage, x, page.Height.Point - y - height, width - 70, height);
            }

            // Save the modified document
            document.Save(outputPdfPath);
        }
    }
}