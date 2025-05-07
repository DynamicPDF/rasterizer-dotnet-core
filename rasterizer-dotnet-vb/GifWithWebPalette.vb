Imports ceTe.DynamicPDF.Rasterizer

Public Class GifWithWebPalette
        Friend Shared Sub Run()
            Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
            Dim gifImageFormat As New GifImageFormat()
            gifImageFormat.DitheringAlgorithm = DitheringAlgorithm.FloydSteinberg
            gifImageFormat.DitheringPercent = 100
            gifImageFormat.ColorPalette = Palette.WebPalette
            gifImageFormat.AntiAliasing = True
            Dim fixedImageSize As New FixedImageSize(595, 841)
            rasterizer.Draw(Program.GetOutputDocPath("gif-web-palette-output.gif"), gifImageFormat, fixedImageSize)
        End Sub
    End Class


