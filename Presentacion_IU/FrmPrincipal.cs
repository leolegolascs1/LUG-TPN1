using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_IU
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonal  oFrmPersonal = new FrmPersonal();
            oFrmPersonal.MdiParent = this;
            oFrmPersonal.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor ofrmProveedor = new FrmProveedor();
            ofrmProveedor.MdiParent = this;
            ofrmProveedor.Show();
        }

        private void articulosMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticuloMateriaPrima oFrmMateriaPrima = new FrmArticuloMateriaPrima();
            oFrmMateriaPrima.MdiParent = this;
            oFrmMateriaPrima.Show();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarOrdenCompra oFrmOrdenCompra = new FrmGenerarOrdenCompra();
            oFrmOrdenCompra.MdiParent = this;
            oFrmOrdenCompra.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformesGenerales oFrmInformes = new FrmInformesGenerales();
            oFrmInformes.MdiParent = this;
            oFrmInformes.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
