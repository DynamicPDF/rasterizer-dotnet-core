Imports ceTe.DynamicPDF.Rasterizer

Class PngImageWithUserPalette

    Friend Shared Sub Run()

        ' Create a PdfRasterizer object.
        Dim rasterizer As PdfRasterizer = New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))

        Dim pngIndexedColorFormat As PngIndexedColorFormat = New PngIndexedColorFormat(ImageFormat.DefaultColorPalette, 100, DitheringAlgorithm.FloydSteinberg)

        Dim color() As ceTe.DynamicPDF.Rasterizer.Color = New ceTe.DynamicPDF.Rasterizer.Color() {
                ceTe.DynamicPDF.Rasterizer.Color.FromArgb(255, 0, 0, 0),
                ceTe.DynamicPDF.Rasterizer.Color.FromArgb(255, 255, 255, 255),
                ceTe.DynamicPDF.Rasterizer.Color.FromArgb(255, 255, 0, 0),
                ceTe.DynamicPDF.Rasterizer.Color.FromArgb(255, 0, 255, 0),
                ceTe.DynamicPDF.Rasterizer.Color.FromArgb(255, 0, 0, 255),
                ceTe.DynamicPDF.Rasterizer.Color.FromArgb(255, 255, 255, 0),
                ceTe.DynamicPDF.Rasterizer.Color.FromArgb(255, 0, 255, 255)}
        Dim userpalette As UserPalette = New UserPalette(color)

        ' Set a user selected color palette.
        pngIndexedColorFormat.ColorPalette = userpalette

        Dim pngImageFormat As PngImageFormat = New PngImageFormat(pngIndexedColorFormat)

        rasterizer.Draw(Program.GetOutputDocPath("user-palette-output.png"), pngImageFormat, ImageSize.Dpi72)
    End Sub

End Class
