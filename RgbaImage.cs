using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class RgbaImage
    {
        internal static void Run()
        {
            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Create a PngImageFormat object with RGBA color
            PngImageFormat oPngImageFormat = new PngImageFormat(PngColorFormat.RgbA);

            // Save the image
            rasterizer.Draw("RgbaImage.png", oPngImageFormat, fixedImageSize);
        }
    }
}