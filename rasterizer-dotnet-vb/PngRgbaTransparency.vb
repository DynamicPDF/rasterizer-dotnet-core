Imports ceTe.DynamicPDF.Rasterizer

Class PngRgbaTransparency

    Friend Shared Sub Run()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("pdf-with-transparency.pdf"))
        Dim fixedImageSize As New FixedImageSize(595, 841)
        Dim oPngImageFormat As New PngImageFormat(PngColorFormat.RgbA)
        rasterizer.Draw(Program.GetOutputDocPath("RgbaTransparency-png-output.png"), oPngImageFormat, fixedImageSize)
    End Sub

End Class

