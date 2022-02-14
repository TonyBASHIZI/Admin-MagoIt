using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Carte_MagoIT.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmHome ma = new frmHome();
            ma.MdiParent = this;
            ma.Show();

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReport ma = new frmReport();
            ma.MdiParent = this;
            ma.Show();
        }
    }
}