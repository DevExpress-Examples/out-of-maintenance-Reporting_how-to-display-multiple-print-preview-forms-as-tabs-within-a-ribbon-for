Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace WindowsFormsApplication1
    Partial Public Class Form_XtraTabbedMDIManager
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
            ReportPreviewHelper.ShowReport(Me)
        End Sub
    End Class
End Namespace
