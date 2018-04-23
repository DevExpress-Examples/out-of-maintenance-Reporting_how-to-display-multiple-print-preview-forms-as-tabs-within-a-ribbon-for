Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
    Partial Public Class Form_DocumentManager
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form_DocumentManager_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            AddDocument()
        End Sub
        Private Sub AddDocument()
            Dim document As DevExpress.XtraBars.Docking2010.Views.BaseDocument = tabbedView1.AddDocument(New WordProcessingForm())
            document.Caption = String.Format("Word Processing Doc # {0}", tabbedView1.Documents.Count)
        End Sub
        Private Sub btnAddDocument_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddDocument.ItemClick
            AddDocument()
        End Sub

        Private Sub dtnShowReportPreview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles dtnShowReportPreview.ItemClick
            ReportPreviewHelper.ShowReport(Me)
        End Sub
    End Class
End Namespace
