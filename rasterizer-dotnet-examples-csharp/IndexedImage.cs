using ceTe.DynamicPDF.Rasterizer;

namespace rasterizer_dotnet_csharp
{
    class IndexedImage
    {
        internal static void Run()
        {
            // Create a PdfRasterizer object
            PdfRasterizer rasterizer = new PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"));

            // Create the GifImageFormat object.
            GifImageFormat gifImageFormat = new GifImageFormat();

            // Set the dithering algorithm to FloydSteinberg
            gifImageFormat.DitheringAlgorithm = DitheringAlgorithm.FloydSteinberg;

            // Set the dithering percentage
            gifImageFormat.DitheringPercent = 100;

            // Create a image size tha is a fixed size
            FixedImageSize fixedImageSize = new FixedImageSize(595, 841);

            // Save the image
            rasterizer.Draw(Program.GetOutputDocPath("IndexedImage.Gif"), gifImageFormat, fixedImageSize);
        }
    }
}