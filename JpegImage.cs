using ceTe.DynamicPDF.Rasterizer;
using System;
using System.Collections.Generic;
using System.Text;

namespace rasterizer_dotnet_core
{
    class JpegImage
    {
        internal static void Run()
        {
            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));

            // Create a JpegImageFormat object
            JpegImageFormat jpegImageFormat = new JpegImageFormat(100);

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Save the image
            rasterizer.Draw("JpegImage.jpg", jpegImageFormat, fixedImageSize);
        }
    }
}
