using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApplication1 {
    public partial class Form_XtraTabbedMDIManager : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form_XtraTabbedMDIManager() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ReportPreviewHelper.ShowReport(this);
        }
    }
}
