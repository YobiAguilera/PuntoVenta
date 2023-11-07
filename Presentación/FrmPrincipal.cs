using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentación
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos Productos = new FrmProductos();
            Productos.ShowDialog();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInventario Inventario = new frmInventario();
            Inventario.ShowDialog();
        }
        private void reportesDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas Ventas = new FrmVentas();
            Ventas.ShowDialog();
        }
    }
}
