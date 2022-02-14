using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carte_MagoIT.Reports;
using Carte_MagoIT.Classes;
using DevExpress.XtraReports.UI;

namespace Carte_MagoIT.Forms
{
    public partial class frmReport : Form
    {
        glossaire glos = new glossaire();
        public frmReport()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                enregistrement j = new enregistrement();
                j.DataSource = glossaire.Instance.sortiEnregistrement();
                ReportPrintTool printTool = new ReportPrintTool(j);
                printTool.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            glos.GetDatas(gridControl1, "*", "conducteurs");
        }
    }
}
