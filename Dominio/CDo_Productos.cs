using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidad;
using System.Windows.Forms;


namespace Dominio
{
    public class CDo_Productos
    {
        CD_Productos ObjProductos = new CD_Productos();

        // Metodo que permite agregar/editar/eliminar un producto a/en la db
        public void AgregarProducto(CE_Productos Productos)
        {
            ObjProductos.AgregarProducto(Productos);
        }
        public void EditarProducto(CE_Productos Productos)
        {
            ObjProductos.EditarProducto(Productos);
        }
        public void EliminarProducto(CE_Productos Productos)
        {
            ObjProductos.EliminarProducto(Productos);
        }

        // Método que permite buscar producto por codigo/nombre/descripcion
        public DataTable Buscar_Producto_Codigo(CE_Productos Productos)
        {
            return ObjProductos.Buscar_Producto_Codigo(Productos);
        }
        public DataTable Buscar_Producto_Nombre(CE_Productos Productos)
        {
            return ObjProductos.Buscar_Producto_Nombre(Productos);
        }
        public DataTable Buscar_Producto_Descripcion(CE_Productos Productos)
        {
            return ObjProductos.Buscar_Producto_Descripcion(Productos);
        }
        public void Buscar_Producto_Codigo_Barra(string Nombre, TextBox Control, string xTBox)
        {
            ObjProductos.Buscar_Producto_Codigo_Barra(Nombre,Control,xTBox);
        }
    }
}
