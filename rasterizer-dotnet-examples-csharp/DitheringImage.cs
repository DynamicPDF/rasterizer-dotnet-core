using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class DitheringImage
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("pdf-for-dithering.pdf"));
            AutoPalette autoPalette = new AutoPalette(QuantizationAlgorithm.Octree, 256);
            PngIndexedColorFormat pngIndexedColorFormat = new PngIndexedColorFormat(autoPalette, 100, DitheringAlgorithm.FloydSteinberg);
            PngImageFormat png = new PngImageFormat(pngIndexedColorFormat);
            rasterizer.Draw(Program.GetOutputDocPath("ditheringImage-output.png"), png, ImageSize.Dpi72);
        }
    }
}
