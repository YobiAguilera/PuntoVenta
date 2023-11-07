using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Entidad;

namespace Presentación
{
    public partial class FrmAgregarVenta : FormBase
    {
        public FrmAgregarVenta(FrmVentas Ventas)
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Productos Productos = new CDo_Productos();
        CDo_Ventas Ventas = new CDo_Ventas();
        CE_Ventas Venta = new CE_Ventas();
        CDo_Detalle_Ventas DetalleVentas = new CDo_Detalle_Ventas();
        CE_Detalle_Ventas DetalleVenta = new CE_Detalle_Ventas();
        
       

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }


        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {
            GenerarCorrelativos();
        }
        private void GenerarCorrelativos()
        {
            tbxNoFactura.Text = "FACT" + Procedimientos.GenerarCodigo("Ventas");
            tbxIdVenta.Text = Procedimientos.GenerarCodigoId("Ventas");
        }
        private void LlenarCampos()
        {
            try
            {
                Productos.Buscar_Producto_Codigo_Barra("Id_Producto", tbxIdProducto, tbxCodigoBarra.Text);
                Productos.Buscar_Producto_Codigo_Barra("Codigo", tbxCodigoProducto, tbxCodigoBarra.Text);
                Productos.Buscar_Producto_Codigo_Barra("Nombre", tbxNombreProducto, tbxCodigoBarra.Text);
                Productos.Buscar_Producto_Codigo_Barra("Tipo_Cargo", tbxTipoCargo, tbxCodigoBarra.Text);
                tbxCantidad.Text = "1";
                tbxDescuento.Text = "0.00";
                Productos.Buscar_Producto_Codigo_Barra("Cantidad", tbxStockActual, tbxCodigoBarra.Text);
                Productos.Buscar_Producto_Codigo_Barra("Precio_Venta", tbxPrecioVenta, tbxCodigoBarra.Text);
                Productos.Buscar_Producto_Codigo_Barra("Presentacion", tbxPresentacion, tbxCodigoBarra.Text);
                CalcularIVA();
                AgregarDetalle();
                LimpiarDetalle();
                tbxCodigoBarra.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue agregado", "Agregar producto con lector", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        public static double Importe1 = 0, ImporteNeto = 0, Descuento1 = 0, IVA1 = 0, Monto_Total = 0, Porcentaje = 0;

        private void tbxDescuento_Leave(object sender, EventArgs e)
        {
            if(tbxDescuento.Text == string.Empty)
            {
                return;
            }
            else
            {
                CalcularIVA();
            }
        }
        

        private void dgvAgregarVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        public static int ContFila = 0;
        public static decimal Total1 = 0, Total2 = 0, Total3 = 0, Total4 = 0, Total5 = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public override bool Guardar()
        {
            try
            {
                if(tbxNoFactura.Text == string.Empty)
                {
                    MessageBox.Show("Completar datos", "Agregar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Venta.No_Factura = tbxNoFactura.Text;
                    Venta.Fecha_Venta = Convert.ToDateTime(dtpFechaFactura.Text);
                    Venta.Fecha_Validez = Convert.ToDateTime(dtpFechaValidez.Text);
                    Venta.Sub_Total = Convert.ToDecimal(tbxSubTotal.Text);
                    Venta.Descuento= Convert.ToDecimal(tbxDescuento.Text);
                    Venta.IVA = Convert.ToDecimal(tbxIva.Text);
                    Venta.Monto_Total = Convert.ToDecimal(tbxMontoTotal.Text);

                

                    foreach (DataGridViewRow row in dgvAgregarVenta.Rows)
                    {
                        DetalleVenta.Id_Venta = Convert.ToInt32(tbxIdVenta.Text);
                        DetalleVenta.Id_Producto = Convert.ToInt32(row.Cells[0].Value.ToString());
                        DetalleVenta.Presentacion = Convert.ToString(row.Cells[2].Value.ToString());
                        DetalleVenta.Cantidad = Convert.ToInt32(row.Cells[3].Value.ToString());
                        DetalleVenta.Precio_Venta = Convert.ToDecimal(row.Cells[4].Value.ToString());
                        DetalleVenta.Sub_Total = Convert.ToDecimal(row.Cells[5].Value.ToString());
                        DetalleVenta.Descuento = Convert.ToDecimal(row.Cells[6].Value.ToString());
                        DetalleVenta.IVA = Convert.ToDecimal(row.Cells[7].Value.ToString());
                        DetalleVenta.Monto_Total= Convert.ToDecimal(row.Cells[8].Value.ToString());

                        DetalleVenta.AgregarDetalleVenta(DetalleVenta);
                    }
                }
                Ventas.AgregarVenta(Venta);
                MessageBox.Show("Venta generada exitosamente", "Generar venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Procedimientos.LimpiarControles(this);
                tbxSubTotal.Text = "0.00";
                tbxDescuento.Text = "0.00";
                tbxIva.Text = "0.00";
                tbxMontoTotal.Text = "0.00";
                Agregar();
                LimpiarDetalle();
                LimpiarCampos();
                GenerarCorrelativos();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se realizó la venta correctamente por: " + ex.Message, "Generar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
           
        }

        private void cbLectorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if(cbLectorCodigo.Checked == true)
            {
                btnBuscarProductoAv.Enabled = false;
                tbxCodigoProducto.Enabled = false;
                tbxNombreProducto.Enabled = false;
                tbxTipoCargo.Enabled = false;
                tbxCantidad.Enabled = false;
                tbxStockActual.Enabled = false;
                tbxIva.Enabled = false;
                tbxPrecioVenta.Enabled = false;
                tbxDescuento.Enabled = false;
                tbxPresentacion.Enabled = false;
                btnAgregarProducto.Enabled = false;
                tbxCodigoBarra.Focus();
            }
            else
            {
                btnBuscarProductoAv.Enabled = true;
                tbxCantidad.Enabled = true;
                btnAgregarProducto.Enabled = true;
                tbxCodigoBarra.Enabled = true;
            }
        }

        private void tbxCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnEliminarProductoAv.Focus();
                e.Handled = true;
            }
        }

        private void tbxCodigoBarra_Leave(object sender, EventArgs e)
        {
            if(tbxCodigoBarra.Text == string.Empty)
            {
                return;
            }
            else
            {
                LlenarCampos();
            }
        }

        private void btnEliminarProductoAv_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContFila > 0)
                {
                    Total5 = Total5 - Convert.ToDecimal(dgvAgregarVenta.Rows[dgvAgregarVenta.CurrentRow.Index].Cells[0].Value);


                    dgvAgregarVenta.Rows.RemoveAt(dgvAgregarVenta.CurrentRow.Index);
                    ContFila--;
                }
                Total1 = 0;
                Total2 = 0;
                Total3 = 0;
                Total4 = 0;

                foreach (DataGridViewRow row1 in dgvAgregarVenta.Rows)
                {
                    Total1 += Convert.ToDecimal(row1.Cells[5].Value);
                    Total2 += Convert.ToDecimal(row1.Cells[6].Value);
                    Total3 += Convert.ToDecimal(row1.Cells[7].Value);
                    Total4 += Convert.ToDecimal(row1.Cells[8].Value);
                }

                tbxSubTotal.Text = Total1.ToString("N2");
                tbxDescuento2.Text = Total2.ToString("N2");
                tbxIva2.Text = Total3.ToString("N2");
                tbxMontoTotal.Text = Total4.ToString("N2");

            }
            catch (Exception ex)
            {

                MessageBox.Show("No hay filas para eliminar", "Eliminar fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AgregarDetalle()
        {
            try
            {
                if(Convert.ToInt32(tbxCantidad.Text) == 0)
                {
                    MessageBox.Show("No hay existencia de este producto", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (tbxIdProducto.Text == string.Empty || tbxCodigoBarra.Text == string.Empty ||
                        tbxCodigoProducto.Text == string.Empty || tbxNombreProducto.Text == string.Empty ||
                        tbxTipoCargo.Text == string.Empty || tbxCantidad.Text == string.Empty ||
                        tbxStockActual.Text == string.Empty || tbxPrecioVenta.Text == string.Empty ||
                        tbxDescuento.Text == string.Empty || tbxIva.Text == string.Empty || tbxPresentacion.Text == string.Empty)
                    {
                        MessageBox.Show("Debe completar todos los campos", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        bool Existe = false;
                        int NoFila = 0;

                        if(ContFila == 0)
                        {
                            dgvAgregarVenta.Rows.Add(tbxIdProducto.Text, tbxNombreProducto.Text, tbxPresentacion.Text,
                                tbxCantidad.Text, tbxPrecioVenta.Text, ImporteNeto.ToString("N2"), Descuento1.ToString("N2"),
                                tbxIva.Text, Monto_Total.ToString("N2"));
                            dgvAgregarVenta.ClearSelection();
                            LimpiarDetalle();
                            btnBuscarProductoAv.Focus();

                            ContFila++;
                        }
                        else
                        {
                            foreach (DataGridViewRow row in dgvAgregarVenta.Rows)
                            {
                                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == tbxIdProducto.Text)//if (row.Cells[0].Value.ToString() == tbxIdProducto.Text)
                                {
                                    Existe = true;
                                    NoFila = row.Index;
                                    break;
                                }
                            }

                            if (Existe == true)
                            {
                                dgvAgregarVenta.Rows[NoFila].Cells[3].Value = Convert.ToDouble(tbxCantidad.Text) + Convert.ToDouble(dgvAgregarVenta.Rows[NoFila].Cells[3].Value);
                                dgvAgregarVenta.Rows[NoFila].Cells[5].Value = (ImporteNeto + Convert.ToDouble(dgvAgregarVenta.Rows[NoFila].Cells[5].Value)).ToString("N2");
                                dgvAgregarVenta.Rows[NoFila].Cells[6].Value = (Descuento1 + Convert.ToDouble(dgvAgregarVenta.Rows[NoFila].Cells[6].Value)).ToString("N2");
                                dgvAgregarVenta.Rows[NoFila].Cells[7].Value = (Convert.ToDouble(tbxIva.Text) + Convert.ToDouble(dgvAgregarVenta.Rows[NoFila].Cells[7].Value)).ToString("N2");
                                dgvAgregarVenta.Rows[NoFila].Cells[8].Value = (Monto_Total + Convert.ToDouble(dgvAgregarVenta.Rows[NoFila].Cells[8].Value)).ToString("N2");
                                LimpiarDetalle();
                            }
                            else
                            {
                                dgvAgregarVenta.Rows.Add(tbxIdProducto.Text, tbxNombreProducto.Text, tbxPresentacion.Text,
                                tbxCantidad.Text, tbxPrecioVenta.Text, ImporteNeto.ToString("N2"), Descuento1.ToString("N2"),
                                tbxIva.Text, Monto_Total.ToString("N2"));
                                dgvAgregarVenta.ClearSelection();
                                LimpiarDetalle();
                                btnBuscarProductoAv.Focus();

                                ContFila++;
                            }
                        }
                        Total1 = 0;
                        Total2 = 0;
                        Total3 = 0;
                        Total4 = 0;

                        foreach (DataGridViewRow row1 in dgvAgregarVenta.Rows)
                        {
                            Total1 += Convert.ToDecimal(row1.Cells[5].Value);
                            Total2 += Convert.ToDecimal(row1.Cells[6].Value);
                            Total3 += Convert.ToDecimal(row1.Cells[7].Value);
                            Total4 += Convert.ToDecimal(row1.Cells[8].Value);
                        }

                        tbxSubTotal.Text = Total1.ToString("N2");
                        tbxDescuento2.Text = Total2.ToString("N2");
                        tbxIva2.Text = Total3.ToString("N2");
                        tbxMontoTotal.Text = Total4.ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el producto por: " + ex.Message, "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarDetalle()
        {
            tbxIdProducto.Text = string.Empty;
            tbxCodigoBarra.Text = string.Empty;
            tbxCodigoProducto.Text = string.Empty;
            tbxNombreProducto.Text = string.Empty;
            tbxTipoCargo.Text = string.Empty;
            tbxCantidad.Text = string.Empty;
            tbxStockActual.Text = string.Empty;
            tbxPrecioVenta.Text = string.Empty;
            tbxDescuento.Text = string.Empty;
            tbxIva.Text = string.Empty;
            tbxPresentacion.Text = string.Empty;
            btnBuscarProductoAv.Focus();
        }
        private void LimpiarCampos()
        {
            dgvAgregarVenta.Rows.Clear();
        }
        private void btnBuscarProductoAv_Click(object sender, EventArgs e)
        {
            FrmVistaProductoVenta VistaProductoVenta = new FrmVistaProductoVenta();
            VistaProductoVenta.ShowDialog();
            try
            {
                if (VistaProductoVenta.DialogResult == DialogResult.OK)
                {
                    tbxIdProducto.Text = VistaProductoVenta.dataGridView1.Rows[VistaProductoVenta.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    tbxCodigoBarra.Text = VistaProductoVenta.dataGridView1.Rows[VistaProductoVenta.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    tbxCodigoProducto.Text = VistaProductoVenta.dataGridView1.Rows[VistaProductoVenta.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    tbxNombreProducto.Text = VistaProductoVenta.dataGridView1.Rows[VistaProductoVenta.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    tbxTipoCargo.Text = VistaProductoVenta.dataGridView1.Rows[VistaProductoVenta.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                    tbxPrecioVenta.Text = VistaProductoVenta.dataGridView1.Rows[VistaProductoVenta.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                    tbxStockActual.Text = VistaProductoVenta.dataGridView1.Rows[VistaProductoVenta.dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                    tbxPresentacion.Text = VistaProductoVenta.dataGridView1.Rows[VistaProductoVenta.dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
                    tbxCantidad.Focus();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Debe seleccionar un producto de la lista", "Ver producto para la venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CalcularIVA()
        {
            try
            {
                if (tbxTipoCargo.Text == "IVA 19%" && tbxCantidad.Text != string.Empty)
                {
                    Importe1 = Convert.ToDouble(tbxPrecioVenta.Text) * Convert.ToDouble(tbxCantidad.Text);
                    Descuento1 = Importe1 * Convert.ToDouble(tbxDescuento.Text) / 100;
                    ImporteNeto = Importe1 - Convert.ToDouble(Descuento1.ToString("N2"));
                    IVA1 = ImporteNeto * 0.19;
                    tbxIva.Text = IVA1.ToString("N2");
                    Monto_Total = Convert.ToDouble(ImporteNeto + Convert.ToDouble(tbxIva.Text));
                    Porcentaje = Descuento1;
                }
                else if (tbxTipoCargo.Text == "IVA 16%" && tbxCantidad.Text != string.Empty)
                {
                    Importe1 = Convert.ToDouble(tbxPrecioVenta.Text) * Convert.ToDouble(tbxCantidad.Text);
                    Descuento1 = Importe1 * Convert.ToDouble(tbxDescuento.Text) / 100;
                    ImporteNeto = Importe1 - Convert.ToDouble(Descuento1.ToString("N2"));
                    IVA1 = ImporteNeto * 0.16;
                    tbxIva.Text = IVA1.ToString("N2");
                    Monto_Total = Convert.ToDouble(ImporteNeto + Convert.ToDouble(tbxIva.Text));
                    Porcentaje = Descuento1;
                }
                else if (tbxTipoCargo.Text == "Exento" && tbxCantidad.Text != string.Empty)
                {
                    Importe1 = Convert.ToDouble(tbxPrecioVenta.Text) * Convert.ToDouble(tbxCantidad.Text);
                    Descuento1 = Importe1 * Convert.ToDouble(tbxDescuento.Text) / 100;
                    ImporteNeto = Importe1 - Convert.ToDouble(Descuento1.ToString("N2"));
                    tbxIva.Text = "0.00";
                    Monto_Total = Convert.ToDouble(ImporteNeto);
                    Porcentaje = Descuento1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calular, por:" + ex.Message, "Calcular IVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
