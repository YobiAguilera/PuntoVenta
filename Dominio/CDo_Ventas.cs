using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Dominio
{
    public class CDo_Ventas
    {
        CD_Ventas ObjVentas = new CD_Ventas();
        public void AgregarVenta(CE_Ventas Ventas)
        {
            ObjVentas.AgregarVenta(Ventas);
        }
        public void AnularVenta(CE_Ventas Ventas)
        {
            ObjVentas.AnularVenta(Ventas);

        }
        public DataTable MostrarVentas()
        {
           return ObjVentas.MostrarVentas();
        }
        public DataTable Mostrar_Productos_Ventas()
        {
            return ObjVentas.Mostrar_Productos_Ventas();
        }

    }
}
