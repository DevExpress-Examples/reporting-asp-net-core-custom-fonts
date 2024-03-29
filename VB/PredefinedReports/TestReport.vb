Imports DevExpress.Drawing
Imports DevExpress.XtraReports.UI

Namespace DocumentViewerApp.PredefinedReports

    Public Partial Class TestReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Dim itemFont As DXFont = New DXFont("Raleway", 12)
            Dim titleFont As DXFont = New DXFont("Fredericka the Great", 22)
            label1.Font = titleFont
            For Each style As XRControlStyle In StyleSheet
                style.Font = itemFont
            Next
        End Sub
    End Class
End Namespace
