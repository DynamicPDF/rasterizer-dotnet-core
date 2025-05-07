Imports ceTe.DynamicPDF.Rasterizer

Class PngBackgroundImageWithRgbColor

    Friend Shared Sub Run()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        rasterizer.BackgroundColor = ceTe.DynamicPDF.Rasterizer.Color.FromArgb(150, 255, 0, 0)
        Dim pngImageFormat As New PngImageFormat(PngColorFormat.RgbA)
        Dim imageSize As New DpiImageSize(72.0F, 72.0F)
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        rasterizer.Draw(Program.GetOutputDocPath("PngBackgroundImageWithRgbColor.png"), pngImageFormat, imageSize.Dpi72)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

End Class
