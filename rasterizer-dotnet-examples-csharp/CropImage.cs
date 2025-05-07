using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class CropImage
    {
        public static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("pdf-for-cropping.pdf"));

            for (int i = 0; i < rasterizer.Pages.Count; i++)
            {
                RectangleF rectangle = new RectangleF(50, 50, 200, 200);
                rasterizer.Pages[i].Draw(Program.GetOutputDocPath("PngCropped.png"), ImageFormat.Png, ImageSize.Dpi72, rectangle);
            }
        }
    }
}
