﻿
using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class PdfToImageRasterizerExample
    {
        public static void Run()
        {
            PDFToBmp();
            PdfToGif();
            PdfToJpg();
            PdfToPng();
            PdfToTiffOne();
            PdfToTiffTwo();
        }

        public static void PDFToBmp()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));

            rasterizer.Draw("pdf-to-bmp-output.bmp", ImageFormat.Bmp, ImageSize.Dpi96);
        }

        public static void PdfToGif()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw("pdf-to-bmp-output.gif", ImageFormat.Gif, ImageSize.Dpi150);
        }

        public static void PdfToJpg()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw("pdf-to-jpg-output.gif", ImageFormat.Jpeg, ImageSize.Dpi72);
        }

        public static void PdfToPng()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw("pdf-to-png-output.gif", ImageFormat.Png, ImageSize.Dpi300);
        }

        public static void PdfToTiffOne()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw("pdf-to-tiff-one-output.gif", ImageFormat.TiffWithLzw, ImageSize.Dpi150);
        }

        public static void PdfToTiffTwo()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));
            rasterizer.Draw("pdf-to-tiff-two-output.gif", ImageFormat.TiffWithCcitGroup4, ImageSize.Dpi150);
        }


    }
}
