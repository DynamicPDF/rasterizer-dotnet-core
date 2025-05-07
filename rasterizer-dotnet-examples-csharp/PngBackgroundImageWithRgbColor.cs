using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class PngBackgroundImageWithRgbColor
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.BackgroundColor = Color.FromArgb(150, 255, 0, 0);
            PngImageFormat pngImageFormat = new PngImageFormat(PngColorFormat.RgbA);
            DpiImageSize imagesize = new DpiImageSize(72.0f, 72.0f);
            rasterizer.Draw(Program.GetOutputDocPath("PngBackgroundImageWithRgbColor.png"), pngImageFormat, ImageSize.Dpi72);
        }
    }
}
