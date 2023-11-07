using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class CD_Detalle_Ventas
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;

        public void AgregarDetalleVenta(CE_Detalle_Ventas Detalles)
        {
            Cmd = new SqlCommand("AgregarDetalleVenta", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Venta", Detalles.Id_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Detalles.Id_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Detalles.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Cantidad", Detalles.Cantidad));
            Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", Detalles.Precio_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Detalles.Sub_Total));
            Cmd.Parameters.Add(new SqlParameter("@Descuento", Detalles.Descuento));
            Cmd.Parameters.Add(new SqlParameter("@IVA", Detalles.IVA));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Detalles.Monto_Total));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
        public void AnularDetalleVenta(CE_Detalle_Ventas Detalles)
        {
            string Estado = string.Empty;

            Cmd = new SqlCommand("Select Estado From Ventas Where Id_Venta= " + Detalles.Id_Venta + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }
            Dr.Close();

            if (Estado == "Anulado")
            {
                return;
            }
            else
            {
                Cmd = new SqlCommand("AnularDetalleVenta", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Venta", Detalles.Id_Venta));
                Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Detalles.Id_Producto));
                Cmd.Parameters.Add(new SqlParameter("@Presentacion", Detalles.Presentacion));
                Cmd.Parameters.Add(new SqlParameter("@Cantidad", Detalles.Cantidad));
                Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", Detalles.Precio_Venta));
                Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Detalles.Sub_Total));
                Cmd.Parameters.Add(new SqlParameter("@Descuento", Detalles.Descuento));
                Cmd.Parameters.Add(new SqlParameter("@IVA", Detalles.IVA));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Detalles.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Id_Detalle", Detalles.Id_Detalle));
                Cmd.ExecuteNonQuery();

                MessageBox.Show("La venta ha sido anulada exitosamente", "Anular venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con.Cerrar();
            }

        }
        public DataTable MostrarDetalleVenta(int Id_Venta)
        {
            DataTable Dt = new DataTable("Detalle Venta");
            Cmd = new SqlCommand("Mostrar_Detalle_Venta", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("Id_Venta", Id_Venta));
            Cmd.ExecuteNonQuery();

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);


            Con.Cerrar();
            return Dt;
        }
    }
}

