using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1 {
    static class ReportPreviewHelper {
        public static void ShowReport(Form mdiContainer) {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PreviewRibbonForm.MdiParent = mdiContainer;
            printTool.PreviewRibbonForm.WindowState = FormWindowState.Maximized;
            printTool.ShowRibbonPreview();
        }
    }
}
