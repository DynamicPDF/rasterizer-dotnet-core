Imports ceTe.DynamicPDF.Rasterizer
Imports Color = ceTe.DynamicPDF.Rasterizer.Color

Class PngBackgroundImageWithColorWithTransparency

    Public Shared Sub Run()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("pdf-with-transparency.pdf"))
        rasterizer.BackgroundColor = Color.FromArgb(150, 255, 0, 0)
        Dim pngImageFormat As New PngImageFormat(PngColorFormat.RgbA)
        Dim imageSize As New DpiImageSize(72.0F, 72.0F)
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        rasterizer.Draw(Program.GetOutputDocPath("PngBackgroundImageWithColorWithTransparency.png"), pngImageFormat, imageSize.Dpi72)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

End Class
