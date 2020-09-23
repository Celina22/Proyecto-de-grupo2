using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;
using System.Data;

namespace LPCFacturas.DataAccessLayer
{
    class ContactoDao
    {
        public IList<Contacto> GetAll()
        {
            List<Contacto> listadoContactos = new List<Contacto>();

            var SQLquery = "SELECT * FROM Contactos WHERE borrado=0";
            DataTable tabla = DBHelper.GetDBHelper().ConsultaSQL(SQLquery);
            
            foreach (DataRow row in tabla.Rows)
                listadoContactos.Add(MappingContacto(row));
            
            return listadoContactos;
        }

        public Contacto GetContacto(string idContacto)
        {
            Contacto contactoObtenido;

            string consulta = "SELECT * FROM Contactos WHERE borrado=0 and id_contacto=" + idContacto;
            DataTable tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);

            if (tabla.Rows.Count > 0)
            {
                contactoObtenido = MappingContacto(tabla.Rows[0]);
                return contactoObtenido;
            }
            return null;
        }
        public void actualizarContacto(Contacto contacto)
        {
            string SQLUpdate = "UPDATE Contactos SET nombre='" + contacto.Nombre + "', " +
                                                     "apellido='" + contacto.Apellido + "', " +
                                                     "email='" + contacto.Email + "', " +
                                                     "telefono=" + contacto.Telefono + " " +
                                                     "WHERE id_contacto=" + contacto.Id_contacto;

            DBHelper.GetDBHelper().EjecutarSQL(SQLUpdate);

        }
        public void eliminarContacto(Contacto contacto)
        {
            string SQLUpdate = "UPDATE Contactos SET borrado=1 WHERE id_contacto=" + contacto.Id_contacto;

            DBHelper.GetDBHelper().EjecutarSQL(SQLUpdate);
        }
        public void crearContacto(Contacto contacto)
        {
            string SQLInsert = string.Concat("INSERT INTO Contactos(nombre, apellido, email, telefono, borrado) VALUES('",
                                                contacto.Nombre, "','",
                                                contacto.Apellido, "','",
                                                contacto.Email, "',",
                                                contacto.Telefono, ",",
                                                0, ")");

            DBHelper.GetDBHelper().EjecutarSQL(SQLInsert);
        }
        private Contacto MappingContacto(DataRow row)
        {
            Contacto oProyecto = new Contacto
            {
                Id_contacto = Convert.ToInt32(row["id_contacto"].ToString()),
                Nombre = row["nombre"].ToString(),
                Apellido = row["apellido"].ToString(),
                Email = row["email"].ToString(),
                Telefono = Convert.ToInt32(row["telefono"].ToString())
            };

            return oProyecto;
        }
    }
}
