using ceTe.DynamicPDF.Rasterizer;
using System;
using System.Collections.Generic;
using System.Text;

namespace rasterizer_dotnet_core
{
    class PngBackgroundImageWithRgbColor
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            rasterizer.BackgroundColor = Color.FromArgb(150, 255, 0, 0);
            PngImageFormat pngImageFormat = new PngImageFormat(PngColorFormat.RgbA);
            DpiImageSize imagesize = new DpiImageSize(72.0f, 72.0f);
            rasterizer.Draw("PngBackgroundImageWithRgbColor.png", pngImageFormat, ImageSize.Dpi72);
        }
    }
}
