using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class PngBackgroundImageWithColorWithTransparency
    {
        public static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("pdf-with-transparency.pdf"));
            rasterizer.BackgroundColor = Color.FromArgb(150, 255, 0, 0);
            PngImageFormat pngImageFormat = new PngImageFormat(PngColorFormat.RgbA);
            DpiImageSize imagesize = new DpiImageSize(72.0f, 72.0f);
            rasterizer.Draw(Program.GetOutputDocPath("PngBackgroundImageWithColorWithTransparency.png"), pngImageFormat, ImageSize.Dpi72);
        }
    }
}
