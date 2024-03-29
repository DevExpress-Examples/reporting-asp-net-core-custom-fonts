Imports DevExpress.Data.Extensions
Imports DevExpress.Drawing
Imports DevExpress.XtraReports.UI
Imports Newtonsoft.Json
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net.Http
Imports System.Threading.Tasks

Namespace DocumentViewerApp.Services

    Public Class FontCollectorService

        Private apiKey As String = "your-api-key"

        Private fontApiUrl As String = "https://www.googleapis.com/webfonts/v1/webfonts/?family="

        Private Async Function LoadFontFromGoogle(ByVal fontName As String) As Task(Of Byte())
            Dim fontUrl As String = $"{fontApiUrl} {fontName}&key={apiKey}"
            Using client As HttpClient = New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(fontUrl)
                If Not response.IsSuccessStatusCode Then
                    Console.WriteLine(response.StatusCode)
                    Return Nothing
                End If

                Dim content As String = Await response.Content.ReadAsStringAsync()
                Dim webfontList As MyFontList = JsonConvert.DeserializeObject(Of MyFontList)(content)
                Return Await LoadFontFile(webfontList.Items(0).Files.regular)
            End Using
        End Function

        Private Async Function LoadFontFile(ByVal fontUrl As String) As Task(Of Byte())
            Using client As HttpClient = New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(fontUrl)
                If Not response.IsSuccessStatusCode Then
                    Console.WriteLine(response.StatusCode)
                    Return Nothing
                End If

                Using fileStream As MemoryStream = New MemoryStream()
                    Await response.Content.CopyToAsync(fileStream)
                    'byte[] result = new byte[fileStream.Length];
                    'fileStream.ToArray();
                    'fileStream.Write(result, 0, (int)fileStream.Length);
                    Return fileStream.ToArray()
                End Using
            End Using
        End Function

        Private Async Function SaveFontToDXFontRepository(ByVal fontName As String) As Task
            Dim fontData As Byte() = Await Me.LoadFontFromGoogle(fontName)
            Dim isDuplicate As Boolean = Me.CheckFontsForDuplicates(fontName)
            If fontData IsNot Nothing AndAlso fontData.Length IsNot 0 AndAlso isDuplicate Is False Then DXFontRepository.Instance.AddFont(fontData)
        End Function

        Private Function CheckFontsForDuplicates(ByVal fontName As String) As Boolean
            Dim fonts = DXFontRepository.Instance.GetFonts()
            Return fonts.FindIndex(Function(font) font.Name Is fontName) IsNot -1
        End Function

        Public Async Function ProcessReport(ByVal report As XtraReport) As Task
            For Each style As XRControlStyle In report.StyleSheet
                Await SaveFontToDXFontRepository(style.Font.Name)
            Next

            For Each reportControl As XRControl In report.AllControls(Of XRControl)()
                Await SaveFontToDXFontRepository(reportControl.Font.Name)
            Next
        End Function
    End Class

    Friend Class MyFont

        Public Property Family As String

        Public Property Menu As String

        Public Property Files As Files
    End Class

    Friend Class MyFontList

        Public Property Items As List(Of MyFont)
    End Class

    Friend Class Files

        Public Property regular As String
    End Class
End Namespace
