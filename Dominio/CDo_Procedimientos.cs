﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Datos;

namespace Dominio
{
    public class CDo_Procedimientos
    {
        CD_Procedimientos ObjProcedimientos = new CD_Procedimientos();

        public DataTable CargarDatos(string Tabla)
        {
            return ObjProcedimientos.CargarDatos(Tabla);
        }
        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            ObjProcedimientos.AlternarColorFilaDataGridView(Dgv);
        }
        public string GenerarCodigo(string Tabla)
        {
            return ObjProcedimientos.GenerarCodigo(Tabla);
        }
        public string GenerarCodigoId(string Tabla)
        {
            return ObjProcedimientos.GenerarCodigoId(Tabla);
        }
        public void FormatoMoneda(TextBox xTBox)
        {
            ObjProcedimientos.FormatoMoneda(xTBox);
        }
        public void LimpiarControles(Form xForm)
        {
            ObjProcedimientos.LimpiarControles(xForm);
        }
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCBox)
        {
            ObjProcedimientos.LlenarComboBox(Tabla, Nombre, xCBox);
        }
    }
}
