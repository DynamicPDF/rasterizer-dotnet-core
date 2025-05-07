using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class PngImageWithUserPalette
    {
        internal static void Run()
        {
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));
            Color[] color = new Color[] { Color.FromArgb(255,0,0,0),
                                          Color.FromArgb(255,255,255,255),
                                          Color.FromArgb(255,255,0,0),
                                          Color.FromArgb(255,0,255,0),
                                          Color.FromArgb(255,0,0,255),
                                          Color.FromArgb(255,255,255,0),
                                          Color.FromArgb(255,0,255,255),
                                          Color.FromArgb(255,255,0,255) };

            UserPalette userPalette = new UserPalette(color);
            PngIndexedColorFormat pngIndexedColorFormat = new PngIndexedColorFormat(userPalette, 100, DitheringAlgorithm.FloydSteinberg);
            PngImageFormat pngImageFormat = new PngImageFormat(pngIndexedColorFormat);
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);
            rasterizer.Draw(Program.GetOutputDocPath("PngImageWithUserPalette.png"), pngImageFormat, fixedImageSize);
        }
    }
}