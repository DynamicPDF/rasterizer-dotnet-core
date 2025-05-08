Imports ceTe.DynamicPDF.Rasterizer

Public Class PngWindowsPalette
    Public Shared Sub Run()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        Dim pngIndexedColorFormat As New PngIndexedColorFormat(Palette.WindowsPalette)
        Dim pngIndexed As New PngImageFormat(pngIndexedColorFormat)
        rasterizer.Draw(Program.GetOutputDocPath("png-windows-color-palette-output.png"), pngIndexed, ImageSize.Dpi72)
    End Sub
End Class

