using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class RgbaImageCustomNaming
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));

            for (int i = 0; i < rasterizer.Pages.Count; i++)
            {
                rasterizer.Pages[i].Draw("Page" + i + "DocumentA.png", ImageFormat.Png, ImageSize.Dpi72);
            }
        }
    }
}