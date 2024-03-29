Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.Logging

Namespace DocumentViewerApp

    Public Class Program

        Public Shared Sub Main(ByVal args As String())
            Call CreateWebHostBuilder(args).Build().Run()
        End Sub

        Public Shared Function CreateWebHostBuilder(ByVal args As String()) As IWebHostBuilder
            Return WebHost.CreateDefaultBuilder(args).UseStartup(Of Startup)()
        End Function
    End Class
End Namespace
