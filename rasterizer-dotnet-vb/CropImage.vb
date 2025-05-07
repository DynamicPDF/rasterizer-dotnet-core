Imports ceTe.DynamicPDF.Rasterizer
Imports System.Drawing

Class CropImage

    Public Shared Sub Run()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("pdf-for-cropping.pdf"))

        For i As Integer = 0 To rasterizer.Pages.Count - 1
            Dim rectangle As New ceTe.DynamicPDF.Rasterizer.RectangleF(50, 50, 200, 200)
            rasterizer.Pages(i).Draw(Program.GetOutputDocPath("PngCropped.png"), ImageFormat.Png, ImageSize.Dpi72, rectangle)
        Next
    End Sub

End Class

