using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class PdfPortfolio
    {
        internal static void Run()
        {
            byte[] pdfArray = System.IO.File.ReadAllBytes(Program.GetResourcePath("PortFolio.pdf"));
            InputPdf inputPdf = new InputPdf(pdfArray); 
            Attachment[] files = inputPdf.Attachments;
            InputPdf inputPdfFile = files[0].TryGetPdf();
            PdfRasterizer rasterizer = new PdfRasterizer(inputPdfFile);
            rasterizer.Draw(Program.GetOutputDocPath("pdf-portfolio-output.png"), ImageFormat.Png, ImageSize.Dpi96);
        }
    }
}