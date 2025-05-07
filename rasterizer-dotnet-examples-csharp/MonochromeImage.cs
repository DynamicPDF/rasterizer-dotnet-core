using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    public class MonochromeImage
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            BmpMonochromeColorFormat bmpMonochromeColorFormat = new BmpMonochromeColorFormat(DitheringAlgorithm.FloydSteinberg, 100);
            BmpImageFormat bmpImageFormat = new BmpImageFormat(bmpMonochromeColorFormat);
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            rasterizer.Draw(Program.GetOutputDocPath("monochrom-image-output.bmp"), bmpImageFormat, fixedImageSize);
        }
    }
}