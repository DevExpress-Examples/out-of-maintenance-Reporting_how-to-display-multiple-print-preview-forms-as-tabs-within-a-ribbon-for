using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form_DocumentManager : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form_DocumentManager() {
            InitializeComponent();
        }

        private void Form_DocumentManager_Load(object sender, EventArgs e) {
            AddDocument();
        }
        private void AddDocument() {
            DevExpress.XtraBars.Docking2010.Views.BaseDocument document = tabbedView1.AddDocument(new WordProcessingForm());
            document.Caption = string.Format("Word Processing Doc # {0}", tabbedView1.Documents.Count);
        }
        private void btnAddDocument_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddDocument();
        }

        private void dtnShowReportPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ReportPreviewHelper.ShowReport(this);
        }
    }
}
