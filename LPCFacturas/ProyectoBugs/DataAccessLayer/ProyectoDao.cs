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
    class ProyectoDao
    {
        ProductoDao oProducto = new ProductoDao();
        UsuarioDao oUsuario = new UsuarioDao();

        public IList<Proyecto> GetAll()
        {
            List<Proyecto> listadoBugs = new List<Proyecto>();

            var strSql = " SELECT p.id_proyecto, p.id_producto, p.descripcion, p.version, p.alcance, u.usuario " +
                         " FROM Proyectos p JOIN usuarios u ON p.id_responsable = u.id_usuario WHERE p.borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;
        }

        public Proyecto GetProyecto(string idProyecto)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT p.id_proyecto, p.id_producto, p.descripcion, p.version, p.alcance, u.usuario ",
                                                " FROM Proyectos p JOIN usuarios u ON p.id_responsable = u.id_usuario" +
                                                " WHERE p.borrado=0 and p.id_proyecto =  '", idProyecto, "'");

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return MappingBug(resultado.Rows[0]);
            }

            return null;
        }

        private Proyecto MappingBug(DataRow row)
        {
            Proyecto oProyecto = new Proyecto
            {
                Id_proyecto = Convert.ToInt32(row["id_proyecto"].ToString()),
                Descripcion = row["descripcion"].ToString(),
                Version = row["estiado"].ToString(),
                Alcance = row["alcance"].ToString(),
                Responsable = oUsuario.GetUser(row["usuario"].ToString()),
                Producto = oProducto.GetProducto(row["id_producto"].ToString())
            };

            return oProyecto;
        }
    }
}
