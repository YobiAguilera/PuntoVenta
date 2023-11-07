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
    public partial class FrmEditarProductos : FormBase
    {
        public FrmEditarProductos(FrmProductos Productos)
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimiento = new CDo_Procedimientos();
        CDo_Productos Productos = new CDo_Productos();
        CE_Productos Producto = new CE_Productos();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmEditarProductos_Load(object sender, EventArgs e)
        {

        }
        private void tbxCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbxNombreProducto.Focus();
                e.Handled = true;
            }
        }

        private void tbxNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbxDescripcion.Focus();
                e.Handled = true;
            }
        }

        private void tbxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbxPresentacion.Focus();
                e.Handled = true;
            }
        }

        private void tbxPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbxCostoUnitario.Focus();
                e.Handled = true;
            }
        }

        private void tbxCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbxPrecioVenta.Focus();
                e.Handled = true;
            }
        }

        private void tbxCostoUnitario_Leave(object sender, EventArgs e)
        {
            Procedimiento.FormatoMoneda(tbxCostoUnitario);
        }

        private void tbxPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbxTipoCargo.Focus();
                e.Handled = true;
            }
        }

        private void tbxPrecioVenta_Leave(object sender, EventArgs e)
        {
            Procedimiento.FormatoMoneda(tbxPrecioVenta);
        }

        private void cbxTipoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnActualizar.Focus();
                e.Handled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        public override void Editar()
        {
            try
            {
                if (tbxCodigoBarra.Text == string.Empty || tbxCodigoProducto.Text == string.Empty || tbxNombreProducto.Text == string.Empty || tbxDescripcion.Text == string.Empty || tbxPresentacion.Text == string.Empty || tbxCostoUnitario.Text == string.Empty || tbxPrecioVenta.Text == string.Empty || cbxTipoCargo.Text == string.Empty)
                {
                    MessageBox.Show("Debe completar todos los cambios", "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Producto.Id_Producto = Convert.ToInt32(tbxIdProducto.Text.Trim());
                    Producto.Codigo_Barra = tbxCodigoBarra.Text.Trim();
                    Producto.Codigo = tbxCodigoProducto.Text.Trim();
                    Producto.Nombre = tbxNombreProducto.Text.Trim();
                    Producto.Descripcion = tbxDescripcion.Text.Trim();
                    Producto.Presentacion = tbxPresentacion.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(tbxCostoUnitario.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(tbxPrecioVenta.Text.Trim());
                    Producto.Tipo_Cargo = cbxTipoCargo.Text.Trim();

                    Productos.EditarProducto(Producto);
                    MessageBox.Show("¡Producto actualizado exitosamente!", "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Actualizar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue actualizado por: " + ex.Message, "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        
    }
}
