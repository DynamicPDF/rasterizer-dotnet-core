
using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class PngImageExample
    {
        public static void Run()
        {
            DefaultName();
            ManualName();
        }

        public static void DefaultName()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw(Program.GetOutputDocPath("png-output-example.png"), ImageFormat.Png, ImageSize.Dpi72);
        }

        public static void ManualName()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));

            for (int i = 0; i < rasterizer.Pages.Count; i++)
            {
                rasterizer.Pages[i].Draw(Program.GetOutputDocPath("manual-output" + i + ".png"), ImageFormat.Png, ImageSize.Dpi72);
            }
        }

    }
}
