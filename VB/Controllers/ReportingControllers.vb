Imports DevExpress.AspNetCore.Reporting.QueryBuilder
Imports DevExpress.AspNetCore.Reporting.QueryBuilder.Native.Services
Imports DevExpress.AspNetCore.Reporting.ReportDesigner
Imports DevExpress.AspNetCore.Reporting.ReportDesigner.Native.Services
Imports DevExpress.AspNetCore.Reporting.WebDocumentViewer
Imports DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services

Namespace DocumentViewerApp.Controllers

    Public Class CustomReportDesignerController
        Inherits ReportDesignerController

        Public Sub New(ByVal controllerService As IReportDesignerMvcControllerService)
            MyBase.New(controllerService)
        End Sub
    End Class

    Public Class CustomQueryBuilderController
        Inherits QueryBuilderController

        Public Sub New(ByVal controllerService As IQueryBuilderMvcControllerService)
            MyBase.New(controllerService)
        End Sub
    End Class

    Public Class CustomWebDocumentViewerController
        Inherits WebDocumentViewerController

        Public Sub New(ByVal controllerService As IWebDocumentViewerMvcControllerService)
            MyBase.New(controllerService)
        End Sub
    End Class
End Namespace
