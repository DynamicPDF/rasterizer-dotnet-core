using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class GifWithWebPalette
    {
        internal static void Run()
        {
            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));

            // Create a GifImageFormat object
            GifImageFormat GifImageFormat = new GifImageFormat();

            // Set the dithering algorithm to FloydSteinberg
            GifImageFormat.DitheringAlgorithm = DitheringAlgorithm.FloydSteinberg;

            // Set the dithering percentage
            GifImageFormat.DitheringPercent = 100;

            // Set the palette type.
            GifImageFormat.ColorPalette = Palette.WebPalette;

            // Set the antialiasing to true
            GifImageFormat.AntiAliasing = true;

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Save the image
            rasterizer.Draw("GifWithWebPalette.Gif", GifImageFormat, fixedImageSize);
        }
    }
}