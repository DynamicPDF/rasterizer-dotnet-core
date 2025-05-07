Imports ceTe.DynamicPDF.Rasterizer

Class PdfToImageRasterizerExample

    Public Shared Sub Run()
        PDFToBmp()
        PdfToGif()
        PdfToJpg()
        PdfToPng()
        PdfToTiffOne()
        PdfToTiffTwo()
        PdfToPngWithTransparency()
    End Sub

    Public Shared Sub SinglePagePdfToPng()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("single-page.pdf"))
        rasterizer.Draw(Program.GetOutputDocPath("single-page-pdf-to-png-output.png"), ImageFormat.Png, ImageSize.Dpi300)
    End Sub

    Public Shared Sub PDFToBmp()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        rasterizer.Draw(Program.GetOutputDocPath("pdf-to-bmp-output.bmp"), ImageFormat.Bmp, ImageSize.Dpi96)
    End Sub

    Public Shared Sub PdfToGif()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        rasterizer.Draw(Program.GetOutputDocPath("pdf-to-bmp-output.gif"), ImageFormat.Gif, ImageSize.Dpi150)
    End Sub

    Public Shared Sub PdfToJpg()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        rasterizer.Draw(Program.GetOutputDocPath("pdf-to-jpg-output.gif"), ImageFormat.Jpeg, ImageSize.Dpi72)
    End Sub

    Public Shared Sub PdfToPng()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        rasterizer.Draw(Program.GetOutputDocPath("pdf-to-png-output.gif"), ImageFormat.Png, ImageSize.Dpi300)
    End Sub

    Public Shared Sub PdfToTiffOne()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        rasterizer.Draw(Program.GetOutputDocPath("pdf-to-tiff-one-output.gif"), ImageFormat.TiffWithLzw, ImageSize.Dpi150)
    End Sub

    Public Shared Sub PdfToTiffTwo()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        rasterizer.Draw(Program.GetOutputDocPath("pdf-to-tiff-two-output.gif"), ImageFormat.TiffWithCcitGroup4, ImageSize.Dpi150)
    End Sub

    Public Shared Sub PdfToPngWithTransparency()
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("pdf-with-transparency.pdf"))
        Dim png As New PngImageFormat(PngColorFormat.RgbA)
        rasterizer.Draw(Program.GetOutputDocPath("pdf-to-png-transparent-output.png"), png, ImageSize.Dpi300)
    End Sub


End Class
