Imports ceTe.DynamicPDF.Rasterizer

Class PngImageExample

    Public Shared Sub Run()
        DefaultName()
        ManualName()
    End Sub

    Public Shared Sub DefaultName()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        rasterizer.Draw(Program.GetOutputDocPath("png-output-example.png"), ImageFormat.Png, ImageSize.Dpi72)
    End Sub

    Public Shared Sub ManualName()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))

        For i As Integer = 0 To rasterizer.Pages.Count - 1
            rasterizer.Pages(i).Draw(Program.GetOutputDocPath("manual-output" & i & ".png"), ImageFormat.Png, ImageSize.Dpi72)
        Next
    End Sub
End Class
