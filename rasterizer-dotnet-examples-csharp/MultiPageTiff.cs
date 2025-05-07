using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class MultiPageTiff
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            rasterizer.DrawToMultiPageTiff(Program.GetOutputDocPath("output-multipage-tiff.tif"), ImageFormat.TiffWithLzw, fixedImageSize);
        }
    }
}