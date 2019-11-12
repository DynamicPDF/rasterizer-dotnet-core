using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class PdfPortfolio
    {
        internal static void Run()
        {
            // Get a byte array containing the source PDF
            byte[] pdfArray = System.IO.File.ReadAllBytes(Util.GetResourcePath("PortFolio.pdf"));

            // Create an input PDF from the byte array
            InputPdf inputPdf = new InputPdf(pdfArray);

            // Get an array of the attachments in the input PDF
            Attachment[] files = inputPdf.Attachments;

            // Gets the first attachment as a PDF if it is a PDF file
            InputPdf inputPdfFile = files[0].TryGetPdf();

            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(inputPdfFile);

            // Save the image
            rasterizer.Draw("PdfPortfolio.png", ImageFormat.Png, ImageSize.Dpi96);
        }
    }
}