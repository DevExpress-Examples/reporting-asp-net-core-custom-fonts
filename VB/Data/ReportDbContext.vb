Imports System.Linq
Imports Microsoft.EntityFrameworkCore

Namespace DocumentViewerApp.Data

    Public Class SqlDataConnectionDescription
        Inherits DataConnection

    End Class

    Public Class JsonDataConnectionDescription
        Inherits DataConnection

    End Class

    Public MustInherit Class DataConnection

        Public Property Id As Integer

        Public Property Name As String

        Public Property DisplayName As String

        Public Property ConnectionString As String
    End Class

    Public Class ReportItem

        Public Property Id As Integer

        Public Property Name As String

        Public Property DisplayName As String

        Public Property LayoutData As Byte()
    End Class

    Public Class ReportDbContext
        Inherits DbContext

        Public Property JsonDataConnections As DbSet(Of JsonDataConnectionDescription)

        Public Property SqlDataConnections As DbSet(Of SqlDataConnectionDescription)

        Public Property Reports As DbSet(Of ReportItem)

        Public Sub New(ByVal options As DbContextOptions(Of ReportDbContext))
            MyBase.New(options)
        End Sub

        Public Sub InitializeDatabase()
            Database.EnsureCreated()
            Dim nwindJsonDataConnectionName = "NWindProductsJson"
            If Not JsonDataConnections.Any(Function(x) x.Name Is nwindJsonDataConnectionName) Then
                Dim newData = New JsonDataConnectionDescription With {.Name = nwindJsonDataConnectionName, .DisplayName = "Northwind Products (JSON)", .ConnectionString = "Uri=Data/nwind.json"}
                JsonDataConnections.Add(newData)
            End If

            Dim nwindSqlDataConnectionName = "NWindConnectionString"
            If Not SqlDataConnections.Any(Function(x) x.Name Is nwindSqlDataConnectionName) Then
                Dim newData = New SqlDataConnectionDescription With {.Name = nwindSqlDataConnectionName, .DisplayName = "Northwind Data Connection", .ConnectionString = "XpoProvider=SQLite;Data Source=|DataDirectory|/Data/nwind.db"}
                SqlDataConnections.Add(newData)
            End If

            Dim reportsDataConnectionName = "ReportsDataSqlite"
            If Not SqlDataConnections.Any(Function(x) x.Name Is reportsDataConnectionName) Then
                Dim newData = New SqlDataConnectionDescription With {.Name = reportsDataConnectionName, .DisplayName = "Reports Data (Demo)", .ConnectionString = "XpoProvider=SQLite;Data Source=|DataDirectory|/Data/reportsData.db"}
                SqlDataConnections.Add(newData)
            End If

            SaveChanges()
        End Sub
    End Class
End Namespace
