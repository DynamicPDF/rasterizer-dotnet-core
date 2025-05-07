Imports ceTe.DynamicPDF.Rasterizer

Class PdfPortfolio
    Friend Shared Sub Run()
        Dim pdfArray As Byte() = System.IO.File.ReadAllBytes(Program.GetResourcePath("PortFolio.pdf"))
        Dim inputPdf As New InputPdf(pdfArray)
        Dim files As Attachment() = inputPdf.Attachments
        Dim inputPdfFile As InputPdf = files(0).TryGetPdf()
        Dim rasterizer As New PdfRasterizer(inputPdfFile)
        rasterizer.Draw(Program.GetOutputDocPath("pdf-portfolio-output.png"), ImageFormat.Png, ImageSize.Dpi96)
    End Sub
End Class
