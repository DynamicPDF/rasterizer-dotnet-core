
using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class PdfToImageRasterizerExample
    {
        public static void Run()
        {
            SinglePagePdfToPng();
            PDFToBmp();
            PdfToGif();
            PdfToJpg();
            PdfToPng();
            PdfToTiffOne();
            PdfToTiffTwo();
            PdfToPngWithTransparency();
        }

        public static void SinglePagePdfToPng()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("single-page.pdf"));
            rasterizer.Draw(Program.GetOutputDocPath("single-page-pdf-to-png-output.png"), ImageFormat.Png, ImageSize.Dpi300);
        }

        public static void PDFToBmp()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw(Program.GetOutputDocPath("pdf-to-bmp-output.bmp"), ImageFormat.Bmp, ImageSize.Dpi96);
        }

        public static void PdfToGif()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw(Program.GetOutputDocPath("pdf-to-bmp-output.gif"), ImageFormat.Gif, ImageSize.Dpi150);
        }

        public static void PdfToJpg()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw(Program.GetOutputDocPath("pdf-to-jpg-output.jpg"), ImageFormat.Jpeg, ImageSize.Dpi72);
        }

        public static void PdfToPng()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw(Program.GetOutputDocPath("pdf-to-png-output.png"), ImageFormat.Png, ImageSize.Dpi300);
        }

        public static void PdfToPngWithTransparency()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("pdf-with-transparency.pdf"));
            PngImageFormat png = new PngImageFormat(PngColorFormat.RgbA);
            rasterizer.Draw(Program.GetOutputDocPath("pdf-to-png-transparent-output.png"),png, ImageSize.Dpi300);
        }

        public static void PdfToTiffOne()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw(Program.GetOutputDocPath("pdf-to-tiff-one-output.tif"), ImageFormat.TiffWithLzw, ImageSize.Dpi150);
        }

        public static void PdfToTiffTwo()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw(Program.GetOutputDocPath("pdf-to-tiff-two-output.tif"), ImageFormat.TiffWithCcitGroup4, ImageSize.Dpi150);
        }


    }
}
