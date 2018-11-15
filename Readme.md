<!-- default file list -->
*Files to look at*:

* [Form_DocumentManager.cs](./CS/WindowsFormsApplication1/Form_DocumentManager.cs) (VB: [Form_DocumentManager.vb](./VB/WindowsFormsApplication1/Form_DocumentManager.vb))
* [Form_XtraTabbedMDIManager.cs](./CS/WindowsFormsApplication1/Form_XtraTabbedMDIManager.cs) (VB: [Form_XtraTabbedMDIManager.vb](./VB/WindowsFormsApplication1/Form_XtraTabbedMDIManager.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
* **[ReportPreviewHelper.cs](./CS/WindowsFormsApplication1/ReportPreviewHelper.cs) (VB: [ReportPreviewHelper.vb](./VB/WindowsFormsApplication1/ReportPreviewHelper.vb))**
* [WordProcessingForm.cs](./CS/WindowsFormsApplication1/WordProcessingForm.cs) (VB: [WordProcessingForm.vb](./VB/WindowsFormsApplication1/WordProcessingForm.vb))
* [XtraReport1.cs](./CS/WindowsFormsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsFormsApplication1/XtraReport1.vb))
<!-- default file list end -->
# How to display multiple Print Preview forms as tabs within a ribbon form


This example demonstrates how to show multiple report print preview forms within a single ribbon form. We create an MDI application by using <a href="https://documentation.devexpress.com/WindowsForms/clsDevExpressXtraBarsDocking2010DocumentManagertopic.aspx">DocumentManager</a> with the <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument11355.aspx">Tabbed View</a> applied and show Preview forms as MDI child elements. <br />Ribbon Control, which belongs to the MDI container (the ribbon form) has the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsRibbonRibbonControl_MdiMergeStyletopic">MdiMergeStyle property</a> set to <strong>Always</strong>, so a child RibbonControl is <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument3451">automatically merged with a parent RibbonControl</a>. <br /><br />See also:<br /><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument1199">Ribbon, Menu and Docking</a> <br /><br />

<br/>


