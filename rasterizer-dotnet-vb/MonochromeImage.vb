Imports ceTe.DynamicPDF.Rasterizer

Public Class MonochromeImage
        Friend Shared Sub Run()
            Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
            Dim bmpMonochromeColorFormat As New BmpMonochromeColorFormat(DitheringAlgorithm.FloydSteinberg, 100)
            Dim bmpImageFormat As New BmpImageFormat(bmpMonochromeColorFormat)
            Dim fixedImageSize As New FixedImageSize(595, 841)
            rasterizer.Draw(Program.GetOutputDocPath("monochrom-image-output.bmp"), bmpImageFormat, fixedImageSize)
        End Sub
    End Class


