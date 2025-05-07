using ceTe.DynamicPDF.Rasterizer;


namespace rasterizer_dotnet_csharp
{
    class PngRgbaTransparency
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("pdf-with-transparency.pdf"));
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            PngImageFormat oPngImageFormat = new PngImageFormat(PngColorFormat.RgbA);
            rasterizer.Draw(Program.GetOutputDocPath("RgbaTransparency-png-output.png"), oPngImageFormat, fixedImageSize);
        }
    }
}