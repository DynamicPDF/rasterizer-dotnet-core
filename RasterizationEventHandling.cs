using ceTe.DynamicPDF.Rasterizer;
using System;
using System.Collections.Generic;
using System.Text;

namespace rasterizer_dotnet_core
{
    class RasterizationEventHandling
    {
        public static void Run()
        {
            Console.WriteLine("----- processing PNG -------");
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            rasterizer.RasterizerProgress += new ProgressChangedEventHandler(RasterizerProgressing);
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            PngImageFormat oPngImageFormat = new PngImageFormat(PngColorFormat.RgbA);
            rasterizer.Draw("eventHandlingExample.png", oPngImageFormat, fixedImageSize);
            rasterizer.Dispose();
        }

        internal static void Run2()
        {
            Console.WriteLine("------- processing MultiPage Tiff ------");
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            rasterizer.RasterizerProgress += new ProgressChangedEventHandler(RasterizerProgressing);

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Save the image
            rasterizer.DrawToMultiPageTiff("eventHandlingMultiPageTiff.tif", ImageFormat.TiffWithLzw, fixedImageSize);
        }

        static void RasterizerProgressing(object sender, RasterizerProgressChangedEventArgs e)
        {
            Console.WriteLine(e.PagesCompleted + " pages have been rasterized");
        }

    }
}
