using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    public class GifWithWebPalette
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            GifImageFormat GifImageFormat = new GifImageFormat();
            GifImageFormat.DitheringAlgorithm = DitheringAlgorithm.FloydSteinberg;
            GifImageFormat.DitheringPercent = 100;
            GifImageFormat.ColorPalette = Palette.WebPalette;
            GifImageFormat.AntiAliasing = true;
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            rasterizer.Draw(Program.GetOutputDocPath("gif-web-palette-output.gif"), GifImageFormat, fixedImageSize);
        }
    }
}