Imports ceTe.DynamicPDF.Rasterizer
Class MultiPageTiff

    Friend Shared Sub Run()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        Dim fixedImageSize As New FixedImageSize(595, 841)
        rasterizer.DrawToMultiPageTiff(Program.GetOutputDocPath("output-multipage-tiff.tif"), ImageFormat.TiffWithLzw, fixedImageSize)
    End Sub

End Class
