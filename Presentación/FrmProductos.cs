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
using Entidad;

namespace Presentación
{
    public partial class FrmProductos : FormBase
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Productos Productos = new CDo_Productos();
        CE_Productos Producto = new CE_Productos();

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//id producto
            dataGridView1.Columns[1].Width = 140;//codigo
            dataGridView1.Columns[2].Width = 260;//nombre
            dataGridView1.Columns[3].Width = 300;//descripcion
            dataGridView1.Columns[4].Width = 150;//presentación
            dataGridView1.Columns[5].Width = 140;//costo unitario
            dataGridView1.Columns[6].Width = 140;//precio venta
            dataGridView1.Columns[7].Width = 150;//Tipo de cargo

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Productos");
            dataGridView1.ClearSelection();
        }
        private void AgPro_UpdateEventHandler(object sender, FrmAgregarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void EdPro_UpdateEventHandler(object sender, FrmEditarProductos.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto AgregarProducto = new FrmAgregarProducto(this);
            AgregarProducto.UpdateEventHandler += AgPro_UpdateEventHandler;
            AgregarProducto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, complete los campos requeridos", "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        FrmEditarProductos EditarProductos = new FrmEditarProductos(this);
                        EditarProductos.UpdateEventHandler += EdPro_UpdateEventHandler;
                        EditarProductos.tbxIdProducto.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarProductos.tbxCodigoProducto.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarProductos.tbxNombreProducto.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarProductos.tbxDescripcion.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarProductos.tbxPresentacion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarProductos.tbxCostoUnitario.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        EditarProductos.tbxPrecioVenta.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        EditarProductos.cbxTipoCargo.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        EditarProductos.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un producto, por favor", "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public override void Eliminar()
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos para eliminar", "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("¿Estás seguro que deseas eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Producto.Id_Producto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            Productos.EliminarProducto(Producto);
                            CargarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debes seleccionar un producto", "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void tbxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        public override void Buscar()
        {
            try
            {
                if(cbxBuscarProducto.Text == "Código")
                {
                    Producto.Buscar = tbxBuscarProducto.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_Codigo(Producto);
                }
                else if(cbxBuscarProducto.Text == "Nombre")
                {
                    Producto.Buscar = tbxBuscarProducto.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_Nombre(Producto);
                }
                else if(cbxBuscarProducto.Text == "Descripción")
                {
                    Producto.Buscar = tbxBuscarProducto.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_Descripcion(Producto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue encontrado por: " + ex.Message, "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
