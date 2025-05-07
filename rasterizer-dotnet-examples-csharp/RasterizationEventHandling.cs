using ceTe.DynamicPDF.Rasterizer;
using System;


namespace rasterizer_dotnet_csharp
{
    class RasterizationEventHandling
    {
        public static void Run()
        {
            PngEventHandling();
            TiffEventHandling();
        }
        
        public static void PngEventHandling()
        {
            Console.WriteLine("----- processing PNG -------");
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.RasterizerProgress += new ProgressChangedEventHandler(RasterizerProgressing);
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            PngImageFormat oPngImageFormat = new PngImageFormat(PngColorFormat.RgbA);
            rasterizer.Draw(Program.GetOutputDocPath("eventHandlingExample.png"), oPngImageFormat, fixedImageSize);
            rasterizer.Dispose();
        }

        internal static void TiffEventHandling()
        {
            Console.WriteLine("------- processing MultiPage Tiff ------");
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            rasterizer.RasterizerProgress += new ProgressChangedEventHandler(RasterizerProgressing);

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Save the image
            rasterizer.DrawToMultiPageTiff(Program.GetOutputDocPath("eventHandlingMultiPageTiff.tif"), ImageFormat.TiffWithLzw, fixedImageSize);
        }

        static void RasterizerProgressing(object sender, RasterizerProgressChangedEventArgs e)
        {
            Console.WriteLine(e.PagesCompleted + " pages have been rasterized");
        }

    }
}
