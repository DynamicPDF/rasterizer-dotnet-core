using ceTe.DynamicPDF.Rasterizer;
using System;
using System.Collections.Generic;
using System.Text;


namespace rasterizer_dotnet_core
{
    class CropImage
    {
        public static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("pdf-with-transparency.pdf"));

            for (int i = 0; i < rasterizer.Pages.Count; i++)
            {
                RectangleF rectangle = new RectangleF(50, 50, 200, 200);
                rasterizer.Pages[i].Draw("PngCropped.png", ImageFormat.Png, ImageSize.Dpi72, rectangle);
            }
        }
    }
}
