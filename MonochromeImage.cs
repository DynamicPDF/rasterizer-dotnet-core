using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class MonochromeImage
    {
        internal static void Run()
        {
            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));

            // Create a BmpMonochromeColorFormat object
            BmpMonochromeColorFormat bmpMonochromeColorFormat = new BmpMonochromeColorFormat(DitheringAlgorithm.FloydSteinberg, 100);

            // Create a BmpImageFormat object with the bmpMonochromeColorFormat
            BmpImageFormat bmpImageFormat = new BmpImageFormat(bmpMonochromeColorFormat);

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Save the image
            rasterizer.Draw("MonochromeImage.bmp", bmpImageFormat, fixedImageSize);
        }
    }
}