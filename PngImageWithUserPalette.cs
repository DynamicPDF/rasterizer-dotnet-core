using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_core
{
    class PngImageWithUserPalette
    {
        internal static void Run()
        {
            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(Util.GetResourcePath("DocumentA.pdf"));


            // Create a color array using custom colors
            Color[] color = new Color[] { Color.FromArgb(255,0,0,0),
                                          Color.FromArgb(255,255,255,255),
                                          Color.FromArgb(255,255,0,0),
                                          Color.FromArgb(255,0,255,0),
                                          Color.FromArgb(255,0,0,255),
                                          Color.FromArgb(255,255,255,0),
                                          Color.FromArgb(255,0,255,255),
                                          Color.FromArgb(255,255,0,255) };

            // Create a UserPalette object using color array
            UserPalette userPalette = new UserPalette(color);

            // Create a PngIndexedColorFormat object using the palette
            PngIndexedColorFormat pngIndexedColorFormat = new PngIndexedColorFormat(userPalette, 100, DitheringAlgorithm.FloydSteinberg);

            // Create a PngImageFormat object using indexed color format object
            PngImageFormat pngImageFormat = new PngImageFormat(pngIndexedColorFormat);

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Save the image
            rasterizer.Draw("PngImageWithUserPalette.png", pngImageFormat, fixedImageSize);
        }
    }
}