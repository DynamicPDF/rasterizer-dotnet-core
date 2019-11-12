namespace rasterizer_dotnet_core
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calls the Run method on all the example classes
            // The rasterized images will be saved in the applications bin folder by default
            GifWithWebPalette.Run();
            IndexedImage.Run();
            JpegImage.Run();
            MonochromeImage.Run();
            MultiPageTiff.Run();
            PdfPortfolio.Run();
            PngImageWithRgbColor.Run();
            PngImageWithUserPalette.Run();
            RgbaImage.Run();
            TiffImageColorFormat.Run();
        }
    }
}
