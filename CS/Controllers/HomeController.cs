using DevExpress.DataAccess.Sql;
using DevExpress.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.ReportDesigner.Services;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DocumentViewerApp.PredefinedReports;
using DocumentViewerApp.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace DocumentViewerApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Error()
        {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }

        public async Task<IActionResult> Designer(
            [FromServices] IReportDesignerModelBuilder reportDesignerModelBuilder,
            [FromQuery] string reportName)
        {
            // Create a SQL data source with the specified connection string.
            SqlDataSource ds = new SqlDataSource("NWindConnectionString");
            // Create a SQL query to access the Products data table.
            SelectQuery query = SelectQueryFluentBuilder.AddTable("Products").SelectAllColumnsFromTable().Build("Products");
            ds.Queries.Add(query);
            ds.RebuildResultSchema();

            reportName = string.IsNullOrEmpty(reportName) ? "TestReport" : reportName;
            var designerModel = await reportDesignerModelBuilder
                .Report(reportName)
                .DataSources(x =>
                {
                    x.Add("Northwind", ds);
                })
                .BuildModelAsync();
            return View(designerModel);
        }

        public async Task< IActionResult> Viewer(
            [FromServices] IWebDocumentViewerClientSideModelGenerator viewerModelGenerator,
            [FromQuery] string reportName)
        {
            reportName = string.IsNullOrEmpty(reportName) ? "TestReport" : reportName;
            var viewerModel = await viewerModelGenerator.GetModelAsync(reportName, CustomWebDocumentViewerController.DefaultUri);
            return View(viewerModel);
        }



        public async Task<ActionResult> CollectAndLoadFonts([FromServices] FontCollectorService fontCollectorService)
        {
            using var report = new TestReport();
            await fontCollectorService.ProcessReport(report);


            using var stream = new MemoryStream();
            await report.ExportToPdfAsync(stream);

            return File(stream.ToArray(), "application/pdf", "Report.pdf");
        }

    }

}