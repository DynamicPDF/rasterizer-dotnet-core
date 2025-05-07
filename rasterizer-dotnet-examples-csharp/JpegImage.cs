using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class JpegImage
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            JpegImageFormat jpegImageFormat = new JpegImageFormat(100);
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            rasterizer.Draw(Program.GetOutputDocPath("JpegImage.jpg"), jpegImageFormat, fixedImageSize);
        }
    }
}
