using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carte_MagoIT.Classes;

namespace Carte_MagoIT.Forms
{
    public partial class frmHome : Form
    {
        glossaire glos = new glossaire();
        
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            glos.GetDatas(gridConducteur, "*", "conducteurs");
        }

        private void gridConducteur_Click(object sender, EventArgs e)
        {

        }
    }
}
