using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class RgbaTransparency
    {
        internal static void Run()
        {

            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("pdf-with-transparency.pdf"));
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            PngImageFormat oPngImageFormat = new PngImageFormat(PngColorFormat.RgbA);
            rasterizer.Draw("RgbaTransparency.png", oPngImageFormat, fixedImageSize);
        }
    }
}