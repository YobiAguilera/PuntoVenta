using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Entidad;

namespace Presentación
{
    public partial class FrmVentas : FormBase
    {
        public FrmVentas()
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Ventas Ventas = new CDo_Ventas();
        CE_Ventas Venta = new CE_Ventas();

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = true;//nro factura

            dataGridView1.Columns[1].Width = 150;//fecha venta
            dataGridView1.Columns[2].Width = 150;//fecha validez
            dataGridView1.Columns[3].Width = 150;//subtotal
            dataGridView1.Columns[4].Width = 150;//descuento
            dataGridView1.Columns[5].Width = 150;//iva
            dataGridView1.Columns[6].Width = 150;//monto total
           

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = Ventas.MostrarVentas();
            dataGridView1.ClearSelection();
        }
        private void AgVen_UpdateEventHandler(object sender, FrmAgregarVenta.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            FrmAgregarVenta AgregarVentas = new FrmAgregarVenta(this);
            AgregarVentas.UpdateEventHandler += AgVen_UpdateEventHandler;
            AgregarVentas.ShowDialog();
        }
    }
}
