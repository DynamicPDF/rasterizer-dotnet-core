Imports ceTe.DynamicPDF.Rasterizer
Imports System

Class RasterizationEventHandling

    Public Shared Sub Run()
        PngEventHandling()
        TiffEventHandling()
    End Sub

    Public Shared Sub PngEventHandling()
        Console.WriteLine("----- processing PNG -------")
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        AddHandler rasterizer.RasterizerProgress, AddressOf RasterizerProgressing

        Dim fixedImageSize As New FixedImageSize(595, 841)
        Dim oPngImageFormat As New PngImageFormat(PngColorFormat.RgbA)
        rasterizer.Draw(Program.GetOutputDocPath("eventHandlingExample.png"), oPngImageFormat, fixedImageSize)
        rasterizer.Dispose()
    End Sub

    Friend Shared Sub TiffEventHandling()
        Console.WriteLine("------- processing MultiPage Tiff ------")
        Dim rasterizer As New PdfRasterizer(Program.GetResourcePath("DocumentA.pdf"))
        AddHandler rasterizer.RasterizerProgress, AddressOf RasterizerProgressing

        Dim fixedImageSize As New FixedImageSize(595, 841)
        rasterizer.DrawToMultiPageTiff(Program.GetOutputDocPath("eventHandlingMultiPageTiff.tif"), ImageFormat.TiffWithLzw, fixedImageSize)
    End Sub

    Private Shared Sub RasterizerProgressing(sender As Object, e As RasterizerProgressChangedEventArgs)
        Console.WriteLine($"{e.PagesCompleted} pages have been rasterized")
    End Sub

End Class

