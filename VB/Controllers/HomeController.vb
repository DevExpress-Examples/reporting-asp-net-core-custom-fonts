Imports DevExpress.DataAccess.Sql
Imports DevExpress.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.ReportDesigner.Services
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports DocumentViewerApp.PredefinedReports
Imports DocumentViewerApp.Services
Imports Microsoft.AspNetCore.Mvc
Imports Newtonsoft.Json
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Net.Http
Imports System.Threading.Tasks

Namespace DocumentViewerApp.Controllers

    Public Class HomeController
        Inherits Controller

        Public Function Index() As IActionResult
            Return View()
        End Function

        Public Function [Error]() As IActionResult
            Dim model As Models.ErrorModel = New Models.ErrorModel()
            Return View(model)
        End Function

        Public Async Function Designer(<FromServices> ByVal reportDesignerModelBuilder As IReportDesignerModelBuilder, <FromQuery> ByVal reportName As String) As Task(Of IActionResult)
            ' Create a SQL data source with the specified connection string.
            Dim ds As SqlDataSource = New SqlDataSource("NWindConnectionString")
            ' Create a SQL query to access the Products data table.
            Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("Products").SelectAllColumnsFromTable().Build("Products")
            ds.Queries.Add(query)
            ds.RebuildResultSchema()
            reportName = If(String.IsNullOrEmpty(reportName), "TestReport", reportName)
            Dim designerModel = Await reportDesignerModelBuilder.Report(reportName).DataSources(Function(x)
                x.Add("Northwind", ds)
            End Function).BuildModelAsync()
            Return View(designerModel)
        End Function

        Public Async Function Viewer(<FromServices> ByVal viewerModelGenerator As IWebDocumentViewerClientSideModelGenerator, <FromQuery> ByVal reportName As String) As Task(Of IActionResult)
            reportName = If(String.IsNullOrEmpty(reportName), "TestReport", reportName)
            Dim viewerModel = Await viewerModelGenerator.GetModelAsync(reportName, CustomWebDocumentViewerController.DefaultUri)
            Return View(viewerModel)
        End Function

        Public Async Function CollectAndLoadFonts(<FromServices> ByVal fontCollectorService As FontCollectorService) As Task(Of ActionResult)
            Dim report = New TestReport()
            Await fontCollectorService.ProcessReport(report)
            Dim stream = New MemoryStream()
            Await report.ExportToPdfAsync(stream)
            Return File(stream.ToArray(), "application/pdf", "Report.pdf")
        End Function
    End Class
End Namespace
