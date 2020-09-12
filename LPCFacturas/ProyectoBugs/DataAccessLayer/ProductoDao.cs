using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using LPCFacturas.Entities;
using System.Data;
using ProyectoBugs.Entities;

namespace LPCFacturas.DataAccessLayer
{
    class ProductoDao
    {

        public Producto GetProducto(string idProducto)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT id_producto, nombre ",
                                                "   FROM Prducto",
                                                "  WHERE borrado=0 and id_producto =  '", idProducto, "'");

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return MappingBug(resultado.Rows[0]);
            }

            return null;
        }

        private Producto MappingBug(DataRow row)
        {
            Producto oProducto = new Producto
            {
                Id_producto = Convert.ToInt32(row["id_producto"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oProducto;
        }
    }
}
