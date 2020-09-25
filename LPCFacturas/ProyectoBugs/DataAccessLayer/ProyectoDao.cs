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

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

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
            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

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
                Version = row["version"].ToString(),
                Alcance = row["alcance"].ToString(),
                Responsable = oUsuario.GetUser(row["usuario"].ToString()),
                Producto = oProducto.GetProducto(row["id_producto"].ToString())
            };

            return oProyecto;
        }

        public void crearProyecto(Proyecto proyecto)
        {
            string SQLInsert = " INSERT INTO Proyectos(id_producto, descripcion, version, alcance, id_responsable, borrado) " +
                               "VALUES (" + proyecto.Producto.Id_producto + ", '" + proyecto.Descripcion + "', '"
                                            + proyecto.Version + "','" + proyecto.Alcance + "'," + proyecto.Responsable.IdUsuario + ", 0) ";
                               


            DataManager.GetInstance().EjecutarSQL(SQLInsert);
        }

        public void actualizarProyecto(Proyecto proyecto)
        {
            string SQLUpdate =  "UPDATE proyectos set id_producto= " + proyecto.Producto.Id_producto + ", " +
                                                     "descripcion= '" + proyecto.Descripcion + "', " +
                                                     "version= '" + proyecto.Version + "', " +
                                                     "alcance= '" + proyecto.Alcance + "', " +
                                                     "id_responsable= " + proyecto.Responsable.IdUsuario +
                                                     " WHERE id_proyecto= " + proyecto.Id_proyecto;
            
            DataManager.GetInstance().EjecutarSQL(SQLUpdate);
        }

        public void eliminarProyecto(Proyecto proyecto)
        {
            string SQLUpdate = "UPDATE proyectos set borrado = 1 WHERE id_proyecto = " + proyecto.Id_proyecto;

            DataManager.GetInstance().EjecutarSQL(SQLUpdate);
        }
    }
}
