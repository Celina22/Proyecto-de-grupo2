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

namespace LPCFacturas.DataAccessLayer
{
    class ProductoDao
    {

        public IList<Producto> GetAll()
        {
            List<Producto> listadoProductos = new List<Producto>();
            var strSql = "SELECT id_producto, nombre from Productos where borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoProductos.Add(MappingProducto(row));
            }

            return listadoProductos;
        }

        internal void actualizarProducto(Producto producto)
        {
            string SQLUpdate =  "UPDATE productos set nombre = '" + producto.Nombre + "'" +
                                                     " WHERE id_producto= " + producto.Id_producto;

            DataManager.GetInstance().EjecutarSQL(SQLUpdate);

        }

        internal void eliminarProducto(Producto producto)
        {
            string SQLUpdate = "UPDATE productos set borrado = 1 WHERE id_producto = " + producto.Id_producto;

            DataManager.GetInstance().EjecutarSQL(SQLUpdate);
        }


        internal void crearProducto(Producto producto)
        {
            string SQLInsert = " INSERT INTO Productos(nombre, borrado) " +
                               "VALUES ('" + producto.Nombre + "', 0) ";



            DataManager.GetInstance().EjecutarSQL(SQLInsert);
        }

        public Producto GetProducto(string idProducto)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT id_producto, nombre ",
                                                "   FROM Productos",
                                                "  WHERE borrado=0 and id_producto =  '", idProducto, "'");

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return MappingProducto(resultado.Rows[0]);
            }

            return null;
        }

        private Producto MappingProducto(DataRow row)
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
