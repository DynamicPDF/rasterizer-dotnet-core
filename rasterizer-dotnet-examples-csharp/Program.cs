using System.IO;
using System.Text.RegularExpressions;

namespace rasterizer_dotnet_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PngImageExample.Run();
            PdfPortfolio.Run();
            MonochromeImage.Run();
            PdfToImageRasterizerExample.Run();
            MultiPageTiff.Run();
            JpegImage.Run();
            GifWithWebPalette.Run();
            PngBackgroundImageWithColorWithTransparency.Run();
            PngBackgroundImageWithRgbColor.Run();
            PngRgbaTransparency.Run();
            PngWindowsPalette.Run();
            PngImageWithUserPalette.Run();
            DitheringImage.Run();
            CropImage.Run();
            RasterizationEventHandling.Run();
        }

        public static string GetResourcePath(string inputFileName)
        {
#pragma warning disable SYSLIB0012 // Type or member is obsolete
            var exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
#pragma warning restore SYSLIB0012 // Type or member is obsolete
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return System.IO.Path.Combine(appRoot, "Resources", inputFileName);
        }

        public static string GetOutputDocPath(string outputfileName)
        {
#pragma warning disable SYSLIB0012 // Type or member is obsolete
            var exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
#pragma warning restore SYSLIB0012 // Type or member is obsolete
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            if (!Directory.Exists(Path.Combine(appRoot, "OutputFiles")))
            {
                Directory.CreateDirectory(System.IO.Path.Combine(appRoot, "OutputFiles"));
            }

            return System.IO.Path.Combine(appRoot, "OutputFiles", outputfileName);
        }

    }
}
