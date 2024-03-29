Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports DevExpress.XtraReports.UI
Imports DocumentViewerApp.PredefinedReports
Imports DocumentViewerApp.Data
Imports System.Threading.Tasks

Namespace DocumentViewerApp.Services

    Public Class CustomReportStorageWebExtension
        Inherits DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension

        Private ReadOnly fontCollectorService As FontCollectorService

        Protected Property DbContext As ReportDbContext

        Public Sub New(ByVal dbContext As ReportDbContext, ByVal fontCollectorService As FontCollectorService)
            Me.DbContext = dbContext
            Me.fontCollectorService = fontCollectorService
        End Sub

        Public Overrides Function CanSetData(ByVal url As String) As Boolean
            ' Determines whether a report with the specified URL can be saved.
            ' Add custom logic that returns **false** for reports that should be read-only.
            ' Return **true** if no valdation is required.
            ' This method is called only for valid URLs (if the **IsValidUrl** method returns **true**).
            Return True
        End Function

        Public Overrides Function IsValidUrl(ByVal url As String) As Boolean
            ' Determines whether the URL passed to the current report storage is valid.
            ' Implement your own logic to prohibit URLs that contain spaces or other specific characters.
            ' Return **true** if no validation is required.
            Return True
        End Function

        Public Overrides Function GetData(ByVal url As String) As Byte()
            ' Uses a specified URL to return report layout data stored within a report storage medium.
            ' This method is called if the **IsValidUrl** method returns **true**.
            ' You can use the **GetData** method to process report parameters sent from the client
            ' if the parameters are included in the report URL's query string.
            Dim reportData = DbContext.Reports.FirstOrDefault(Function(x) x.Name Is url)
            If reportData IsNot Nothing Then Return reportData.LayoutData
            If ReportsFactory.Reports.ContainsKey(url) Then
                Dim ms = New MemoryStream()
                Dim report As XtraReport = ReportsFactory.Reports(url)()
                report.SaveLayoutToXml(ms)
                Return ms.ToArray()
            End If

            Throw New DevExpress.XtraReports.Web.ClientControls.FaultException(String.Format("Could not find report '{0}'.", url))
        End Function

        Public Overrides Function GetUrls() As Dictionary(Of String, String)
            ' Returns a dictionary that contains the report names (URLs) and display names. 
            ' The Report Designer uses this method to populate the Open Report and Save Report dialogs.
            Return DbContext.Reports.ToList().[Select](Function(x) x.Name).Union(ReportsFactory.Reports.[Select](Function(x) x.Key)).ToDictionary(Of String, String)(Function(x) x)
        End Function

        Public Overrides Sub SetData(ByVal report As XtraReport, ByVal url As String)
            ' Saves the specified report to the report storage with the specified name
            ' (saves existing reports only). 
            Dim stream = New MemoryStream()
            report.SaveLayoutToXml(stream)
            Dim reportData = DbContext.Reports.FirstOrDefault(Function(x) x.Name Is url)
            If reportData Is Nothing Then
                DbContext.Reports.Add(New ReportItem With {.Name = url, .LayoutData = stream.ToArray()})
            Else
                reportData.LayoutData = stream.ToArray()
            End If

            DbContext.SaveChanges()
        End Sub

        Public Overrides Function SetNewData(ByVal report As XtraReport, ByVal defaultUrl As String) As String
            ' Allows you to validate and correct the specified name (URL).
            ' This method also allows you to return the resulting name (URL),
            ' and to save your report to a storage. The method is called only for new reports.
            Me.SetData(report, defaultUrl)
            Return defaultUrl
        End Function

        Public Overrides Async Function AfterGetDataAsync(ByVal url As String, ByVal report As XtraReport) As Task
            Await fontCollectorService.ProcessReport(report)
            Await MyBase.AfterGetDataAsync(url, report)
        End Function
    End Class
End Namespace
