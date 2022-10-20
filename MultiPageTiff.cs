using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class MultiPageTiff
    {
        internal static void Run()
        {
            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            
            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Save the image
            rasterizer.DrawToMultiPageTiff("MultiPageTiff.tif", ImageFormat.TiffWithLzw, fixedImageSize);
        }
    }
}