using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Carte_MagoIT.Reports
{
    public partial class carte : DevExpress.XtraReports.UI.XtraReport
    {
        public carte()
        {
            InitializeComponent();
        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
