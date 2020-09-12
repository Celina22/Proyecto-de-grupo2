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
        public IList<Proyecto> GetAll()
        {
            List<Proyecto> listadoBugs = new List<Proyecto>();

            var strSql = " SELECT id_proyecto, pr.nombre nombreProducto, descripcion, version, alcance, u.usuario nombreResponsable "+
                         " FROM Proyectos p JOIN productos pr ON p.id_producto = pr.id_producto" +
                                          " JOIN usuarios u ON p.id_responsable = u.id_usuario "+
                         "  WHERE p.borrado=0";

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
            String consultaSql = string.Concat(" SELECT id_proyecto, pr.nombre nombreProducto, descripcion, version, alcance, u.usuario nombreResponsable ",
                                                "   FROM Proyectos p JOIN productos pr ON p.id_producto = pr.id_producto" +
                                                                   " JOIN usuarios u ON p.id_responsable = u.id_usuario ",
                                                "  WHERE borrado=0 and id_proyecto =  '", idProyecto, "'");

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
                NombreProducto = row["nombreProducto"].ToString(),                
                Descripcion = row["descripcion"].ToString(),
                Version = row["estiado"].ToString(),
                Alcance = row["alcance"].ToString(),
                NombreResponsable = row["nombreResponsable"].ToString()
            };

            return oProyecto;
        }
    }
}
