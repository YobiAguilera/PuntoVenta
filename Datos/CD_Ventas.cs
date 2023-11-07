using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Datos
{
    public class CD_Ventas
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;
        
        public void AgregarVenta(CE_Ventas Ventas)
        {
            Cmd = new SqlCommand("AgregarVentas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@No_Factura", Ventas.No_Factura));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", Ventas.Fecha_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Validez", Ventas.Fecha_Validez));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Ventas.Sub_Total));
            Cmd.Parameters.Add(new SqlParameter("@Descuento", Ventas.Descuento));
            Cmd.Parameters.Add(new SqlParameter("@IVA", Ventas.IVA));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ventas.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Ventas.Estado));
           
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
        public void AnularVenta(CE_Ventas Ventas)
        {
            string Estado = string.Empty;

            Cmd = new SqlCommand("Select Estado From Ventas Where Id_Venta= " + Ventas.Id_Venta + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if(Estado == "Anulado")
            {
                MessageBox.Show("La venta ya ha sido anulada, seleccione otra venta, por favor.", "Anular venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Cmd = new SqlCommand("AnularVentas", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                
                Cmd.Parameters.Add(new SqlParameter("@No_Factura", Ventas.No_Factura));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", Ventas.Fecha_Venta));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Validez", Ventas.Fecha_Validez));
                Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Ventas.Sub_Total));
                Cmd.Parameters.Add(new SqlParameter("@Descuento", Ventas.Descuento));
                Cmd.Parameters.Add(new SqlParameter("@IVA", Ventas.IVA));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ventas.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Estado", Ventas.Estado));
                Cmd.Parameters.Add(new SqlParameter("@Id_Venta", Ventas.Id_Venta));
                Cmd.ExecuteNonQuery();

                MessageBox.Show("La venta ha sido anulada exitosamente", "Anular venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con.Cerrar();
            }
            
        }
        public DataTable MostrarVentas()
        {
            DataTable Dt = new DataTable("Venta de productos");
            Cmd = new SqlCommand("MostrarVentas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();
            return Dt;
        }
        public DataTable Mostrar_Productos_Ventas()
        {
            DataTable Dt = new DataTable("Mostrar productos ventas");
            Cmd = new SqlCommand("Mostrar_Productos_Ventas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();
            return Dt;
        }

    }
}
