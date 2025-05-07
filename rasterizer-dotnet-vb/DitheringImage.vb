Imports ceTe.DynamicPDF.Rasterizer

Class DitheringImage

    Friend Shared Sub Run()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("pdf-for-dithering.pdf"))
        Dim autoPalette As New AutoPalette(QuantizationAlgorithm.Octree, 256)
        Dim pngIndexedColorFormat As New PngIndexedColorFormat(autoPalette, 100, DitheringAlgorithm.FloydSteinberg)
        Dim png As New PngImageFormat(pngIndexedColorFormat)
        rasterizer.Draw(Program.GetOutputDocPath("ditheringImage-output.png"), png, ImageSize.Dpi72)
    End Sub

End Class

