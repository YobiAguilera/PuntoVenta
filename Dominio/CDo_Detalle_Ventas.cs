using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Dominio
{
    public class CDo_Detalle_Ventas
    {
        CD_Detalle_Ventas ObjDetalleVentas = new CD_Detalle_Ventas();

        public void AgregarDetalleVenta(CE_Detalle_Ventas Detalles)
        {
            ObjDetalleVentas.AgregarDetalleVenta(Detalles);
        }
        public void AnularDetalleVenta(CE_Detalle_Ventas Detalles)
        {
            ObjDetalleVentas.AnularDetalleVenta(Detalles);
        }
        public DataTable MostrarDetalleVenta(int Id_Venta)
        {
            return ObjDetalleVentas.MostrarDetalleVenta(Id_Venta);
        }
    }
}
