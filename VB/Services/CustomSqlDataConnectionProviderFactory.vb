Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Data.Entity
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Native
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Web
Imports DevExpress.DataAccess.Wizard.Services
Imports DocumentViewerApp.Data

Namespace DocumentViewerApp.Services

    Public Class CustomSqlDataConnectionProviderFactory
        Inherits IConnectionProviderFactory

        Private ReadOnly reportDbContext As ReportDbContext

        Public Sub New(ByVal reportDbContext As ReportDbContext)
            Me.reportDbContext = reportDbContext
        End Sub

        Public Function Create() As IConnectionProviderService
            Return New CustomSqlConnectionProviderService(reportDbContext.SqlDataConnections.ToList())
        End Function
    End Class

    Public Class CustomSqlConnectionProviderService
        Inherits IConnectionProviderService

        Private ReadOnly sqlDataConnections As IEnumerable(Of DataConnection)

        Public Sub New(ByVal sqlDataConnections As IEnumerable(Of DataConnection))
            Me.sqlDataConnections = sqlDataConnections
        End Sub

        Public Function LoadConnection(ByVal connectionName As String) As SqlDataConnection
            Dim sqlDataConnectionData = sqlDataConnections.FirstOrDefault(Function(x) x.Name Is connectionName)
            If sqlDataConnectionData Is Nothing Then Throw New InvalidOperationException()
            If String.IsNullOrEmpty(sqlDataConnectionData.ConnectionString) Then Throw New KeyNotFoundException($"Connection string '{connectionName}' not found.")
            Dim connectionParameters = New CustomStringConnectionParameters(sqlDataConnectionData.ConnectionString)
            Return New SqlDataConnection(connectionName, connectionParameters)
        End Function
    End Class
End Namespace
