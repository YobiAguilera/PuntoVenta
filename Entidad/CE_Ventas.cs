using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CE_Ventas
    {
        private int _Id_Venta;
        private string _No_Factura;
        private DateTime _Fecha_Venta;
        private DateTime _Fecha_Validez;
        private decimal _Sub_Total;
        private decimal _Descuento;
        private decimal _IVA;
        private decimal _Monto_Total;
        private string _Estado;

        public int Id_Venta { get => _Id_Venta; set => _Id_Venta = value; }
        public string No_Factura { get => _No_Factura; set => _No_Factura = value; }
        public DateTime Fecha_Venta { get => _Fecha_Venta; set => _Fecha_Venta = value; }
        public DateTime Fecha_Validez { get => _Fecha_Validez; set => _Fecha_Validez = value; }
        public decimal Sub_Total { get => _Sub_Total; set => _Sub_Total = value; }
        public decimal Descuento { get => _Descuento; set => _Descuento = value; }
        public decimal IVA { get => _IVA; set => _IVA = value; }
        public decimal Monto_Total { get => _Monto_Total; set => _Monto_Total = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

    }
}
