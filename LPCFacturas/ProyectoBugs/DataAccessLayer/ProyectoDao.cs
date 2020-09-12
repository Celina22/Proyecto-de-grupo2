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

            var strSql = " SELECT id_proyecto, id_producto, descripcion, version, alcance, id_responsable" +
                         " FROM proyectos WHERE borrado = 0";

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
            String consultaSql = string.Concat(" SELECT id_proyecto, id_producto, descripcion, version, alcance, id_responsable ",
                                                "   FROM Proyectos ",
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
                Id_producto = Convert.ToInt32(row["id_producto"].ToString()),                
                Descripcion = row["descripcion"].ToString(),
                Version = row["estiado"].ToString(),
                Alcance = row["alcance"].ToString(),
                Id_responsable = Convert.ToInt32(row["id_responsable"].ToString())
            };

            return oProyecto;
        }
    }
}
