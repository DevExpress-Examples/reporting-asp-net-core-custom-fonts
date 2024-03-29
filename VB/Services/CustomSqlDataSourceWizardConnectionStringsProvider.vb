Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Web
Imports DocumentViewerApp.Data

Namespace DocumentViewerApp.Services

    Public Class CustomSqlDataSourceWizardConnectionStringsProvider
        Inherits IDataSourceWizardConnectionStringsProvider

        Private ReadOnly reportDataContext As ReportDbContext

        Public Sub New(ByVal reportDataContext As ReportDbContext)
            Me.reportDataContext = reportDataContext
        End Sub

        Private Function GetConnectionDescriptions() As Dictionary(Of String, String)
            Return reportDataContext.SqlDataConnections.ToDictionary(Function(x) x.Name, Function(x) x.DisplayName)
        End Function

        Private Function GetDataConnectionParameters(ByVal name As String) As DataConnectionParametersBase
            Return Nothing
        End Function
    End Class
End Namespace
