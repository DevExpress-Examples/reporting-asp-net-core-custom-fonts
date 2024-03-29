Imports DevExpress.AspNetCore
Imports DevExpress.AspNetCore.Reporting
Imports DevExpress.Security.Resources
Imports DevExpress.XtraReports.Web.Extensions
Imports DocumentViewerApp.Data
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports Microsoft.Extensions.Logging
Imports System.IO

Namespace DocumentViewerApp

    Public Class Startup

        Public Sub New(ByVal configuration As IConfiguration, ByVal hostingEnvironment As IWebHostEnvironment)
            Me.Configuration = configuration
            Me.HostingEnvironment = hostingEnvironment
        End Sub

        Public ReadOnly Property Configuration As IConfiguration

        Public ReadOnly Property HostingEnvironment As IWebHostEnvironment

        ' This method gets called by the runtime. Use this method to add services to the container.
        Public Sub ConfigureServices(ByVal services As IServiceCollection)
            services.AddDevExpressControls()
            services.AddScoped(Of ReportStorageWebExtension, CustomReportStorageWebExtension)()
            services.AddScoped(Of FontCollectorService, FontCollectorService)()
            services.AddMvc().AddNewtonsoftJson()
            services.ConfigureReportingServices(Function(configurator)
                If HostingEnvironment.IsDevelopment() Then
                    configurator.UseDevelopmentMode()
                End If

                configurator.ConfigureReportDesigner(Function(designerConfigurator)
                    designerConfigurator.RegisterDataSourceWizardConnectionStringsProvider(Of CustomSqlDataSourceWizardConnectionStringsProvider)()
                End Function)
                configurator.ConfigureWebDocumentViewer(Function(viewerConfigurator)
                    viewerConfigurator.UseCachedReportSourceBuilder()
                    viewerConfigurator.RegisterConnectionProviderFactory(Of CustomSqlDataConnectionProviderFactory)()
                End Function)
                configurator.UseAsyncEngine()
            End Function)
            services.AddDbContext(Of ReportDbContext)(Function(options) options.UseSqlite(Configuration.GetConnectionString("ReportsDataConnectionString")))
        End Sub

        ' This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        Public Sub Configure(ByVal app As IApplicationBuilder, ByVal env As IWebHostEnvironment, ByVal loggerFactory As ILoggerFactory, ByVal db As ReportDbContext)
            db.InitializeDatabase()
            Dim contentDirectoryAllowRule = DirectoryAccessRule.Allow(New DirectoryInfo(Path.Combine(env.ContentRootPath, "..", "Content")).FullName)
            AccessSettings.ReportingSpecificResources.TrySetRules(contentDirectoryAllowRule, UrlAccessRule.Allow())
            DevExpress.XtraReports.Configuration.Settings.[Default].UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions
            app.UseDevExpressControls()
            System.Net.ServicePointManager.SecurityProtocol = System.Net.ServicePointManager.SecurityProtocol Or System.Net.SecurityProtocolType.Tls12
            If env.IsDevelopment() Then
                app.UseDeveloperExceptionPage()
            Else
                app.UseExceptionHandler("/Home/Error")
                ' The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts()
            End If

            app.UseHttpsRedirection()
            app.UseStaticFiles()
            app.UseRouting()
            app.UseAuthorization()
            app.UseEndpoints(Function(endpoints)
                endpoints.MapControllerRoute(name:="default", pattern:="{controller=Home}/{action=Viewer}/{id?}")
            End Function)
        End Sub
    End Class
End Namespace
