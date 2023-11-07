using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;


namespace Presentación
{
    public partial class FrmVistaProductoVenta : FormBase
    {
        public FrmVistaProductoVenta()
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Ventas Ventas = new CDo_Ventas();
        private void FrmVistaProductoVenta_Load(object sender, EventArgs e)
        {
            Mostrar_Productos_Venta();

            dataGridView1.Columns[0].Visible = false;//id producto

            dataGridView1.Columns[1].Width = 150;//codigo barra
            dataGridView1.Columns[2].Width = 150;//codigo producto
            dataGridView1.Columns[3].Width = 290;//Nombre 
            dataGridView1.Columns[4].Width = 140;//tipo cargo
            dataGridView1.Columns[5].Width = 140;//stock actual
            dataGridView1.Columns[6].Width = 150;//precio de venta
            dataGridView1.Columns[7].Width = 150;//presentacion
         

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void Mostrar_Productos_Venta()
        {
            dataGridView1.DataSource = Ventas.Mostrar_Productos_Ventas();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
