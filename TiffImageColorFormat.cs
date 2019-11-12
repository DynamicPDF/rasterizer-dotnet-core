using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class TiffImageColorFormat
    {
        internal static void Run()
        {
            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Create a TiffMonochromeColorFormat object with CCIT Group 3 compression.
            TiffMonochromeColorFormat tiffColorFormat = new TiffMonochromeColorFormat(TiffMonochromeCompressionType.CcitGroup3);

            // Create a TiffImageFormat object with monocrome color
            TiffImageFormat tiffImageFormat = new TiffImageFormat(tiffColorFormat);

            // Save the image
            rasterizer.Draw("TiffImageColorFormat.tif", tiffImageFormat, fixedImageSize);
        }
    }
}