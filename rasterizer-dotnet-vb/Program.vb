Imports System
Imports System.IO
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())
        PdfPortfolio.Run()
        MonochromeImage.Run()
        PngImageExample.Run()
        PdfToImageRasterizerExample.Run()
        JpegImage.Run()
        GifWithWebPalette.Run()
        PngBackgroundImageWithRgbColor.Run()
        PngBackgroundImageWithColorWithTransparency.Run()
        PngImageWithUserPalette.Run()
        DitheringImage.Run()
        CropImage.Run()
        RasterizationEventHandling.Run()
    End Sub


    Public Function GetResourcePath(inputFileName As String) As String
        Dim exePath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim appPathMatcher As Regex = New Regex("(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)")
        Dim appRoot As String = appPathMatcher.Match(exePath).Value
        Return System.IO.Path.Combine(appRoot, "Resources", inputFileName)
    End Function


    Public Function GetOutputDocPath(outputfileName As String) As String
        Dim exePath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim appPathMatcher As Regex = New Regex("(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)")
        Dim appRoot As String = appPathMatcher.Match(exePath).Value
        If (Not Directory.Exists(Path.Combine(appRoot, "OutputFiles"))) Then
            Directory.CreateDirectory(System.IO.Path.Combine(appRoot, "OutputFiles"))
        End If

        Return System.IO.Path.Combine(appRoot, "OutputFiles", outputfileName)
    End Function

End Module
