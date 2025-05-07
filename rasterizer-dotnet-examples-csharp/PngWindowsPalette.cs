
using ceTe.DynamicPDF.Rasterizer;
using rasterizer_dotnet_csharp;

namespace rasterizer_dotnet_csharp
{
    public class PngWindowsPalette
    {
        public static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            PngIndexedColorFormat pngIndexedColorFormat = new PngIndexedColorFormat(Palette.WindowsPalette);
            PngImageFormat pngIndexed = new PngImageFormat(pngIndexedColorFormat);
            rasterizer.Draw(Program.GetOutputDocPath("png-windows-color-palette-output.png"), pngIndexed, ImageSize.Dpi72);
        }


    }
}
