Imports ceTe.DynamicPDF.Rasterizer

Class JpegImage
        Friend Shared Sub Run()
            Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
            Dim jpegImageFormat As New JpegImageFormat(100)
            Dim fixedImageSize As New FixedImageSize(595, 841)
            rasterizer.Draw(Program.GetOutputDocPath("JpegImage.jpg"), jpegImageFormat, fixedImageSize)
        End Sub
    End Class


