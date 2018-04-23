Namespace WindowsFormsApplication1
    Partial Public Class Form_DocumentManager
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form_DocumentManager))
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.dtnShowReportPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.btnAddDocument = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.MdiParent = Me
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.tabbedView1})
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.dtnShowReportPreview, Me.btnAddDocument})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 3
            Me.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1198, 144)
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup2, Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.dtnShowReportPreview)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Reporting"
            ' 
            ' dtnShowReportPreview
            ' 
            Me.dtnShowReportPreview.Caption = "Show Report Preview"
            Me.dtnShowReportPreview.Glyph = (DirectCast(resources.GetObject("dtnShowReportPreview.Glyph"), System.Drawing.Image))
            Me.dtnShowReportPreview.Id = 1
            Me.dtnShowReportPreview.LargeGlyph = (DirectCast(resources.GetObject("dtnShowReportPreview.LargeGlyph"), System.Drawing.Image))
            Me.dtnShowReportPreview.Name = "dtnShowReportPreview"
            ' 
            ' btnAddDocument
            ' 
            Me.btnAddDocument.Caption = "Add document"
            Me.btnAddDocument.Glyph = (DirectCast(resources.GetObject("btnAddDocument.Glyph"), System.Drawing.Image))
            Me.btnAddDocument.Id = 2
            Me.btnAddDocument.LargeGlyph = (DirectCast(resources.GetObject("btnAddDocument.LargeGlyph"), System.Drawing.Image))
            Me.btnAddDocument.Name = "btnAddDocument"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.ItemLinks.Add(Me.btnAddDocument)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Documents"
            ' 
            ' Form_DocumentManager
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1198, 743)
            Me.Controls.Add(Me.ribbonControl1)
            Me.IsMdiContainer = True
            Me.Name = "Form_DocumentManager"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
        Private tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private formAssistant1 As DevExpress.XtraBars.FormAssistant
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents dtnShowReportPreview As DevExpress.XtraBars.BarButtonItem
        Private WithEvents btnAddDocument As DevExpress.XtraBars.BarButtonItem
        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    End Class
End Namespace