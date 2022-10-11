using ceTe.DynamicPDF.Rasterizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rasterizer_dotnet_core
{
    class DitheringImage
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("pdf-with-transparency.pdf"));
            AutoPalette autoPalette = new AutoPalette(QuantizationAlgorithm.Octree, 256);
            PngIndexedColorFormat pngIndexedColorFormat = new PngIndexedColorFormat(autoPalette, 100, DitheringAlgorithm.FloydSteinberg);
            PngImageFormat png = new PngImageFormat(pngIndexedColorFormat);
            rasterizer.Draw("DitheringImage.png", png, ImageSize.Dpi72);
        }
    }
}
