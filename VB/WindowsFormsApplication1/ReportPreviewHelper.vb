Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1
    Friend NotInheritable Class ReportPreviewHelper

        Private Sub New()
        End Sub

        Public Shared Sub ShowReport(ByVal mdiContainer As Form)
            Dim report As New XtraReport1()
            Dim printTool As New ReportPrintTool(report)
            printTool.PreviewRibbonForm.MdiParent = mdiContainer
            printTool.PreviewRibbonForm.WindowState = FormWindowState.Maximized
            printTool.ShowRibbonPreview()
        End Sub
    End Class
End Namespace
