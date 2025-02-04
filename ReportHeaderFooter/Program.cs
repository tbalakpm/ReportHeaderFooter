namespace ReportHeaderFooter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ReportForm());

            ////string inputPdfPath = "C:\\Users\\tbala\\source\\repos\\ReportHeaderFooter\\ReportHeaderFooter\\Sample_Report_1.pdf";
            ////string headerImagePath = "C:\\Users\\tbala\\source\\repos\\ReportHeaderFooter\\ReportHeaderFooter\\Header.jpg";
            ////string footerImagePath = "C:\\Users\\tbala\\source\\repos\\ReportHeaderFooter\\ReportHeaderFooter\\Footer.jpg";
            ////HeaderFooterImage.AddHeaderAndFooter(inputPdfPath, headerImagePath, footerImagePath);
        }
    }
}