using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;
using System.Data;

namespace LPCFacturas.DataAccessLayer
{
    class ClienteDao
    {
        BarrioDao oBarrioDao = new BarrioDao();
        ContactoDao oContactoDao = new ContactoDao();
        public IList<Cliente> GetAll()
        {
            List<Cliente> listadoClientes = new List<Cliente>();

            var SQLquery = "SELECT * FROM Clientes WHERE borrado=0";
            DataTable tabla = DataManager.GetInstance().ConsultaSQL(SQLquery);

            foreach (DataRow row in tabla.Rows)
                listadoClientes.Add(MappingCliente(row));

            return listadoClientes;
        }

        public DataTable recuperarCLientes()
        {
            var SQLquery = "SELECT * FROM Clientes WHERE borrado=0";
            DataTable tabla = DataManager.GetInstance().ConsultaSQL(SQLquery);
            return tabla;
        }

        public Cliente GetCliente(string idCliente)
        {
            Cliente clienteObtenido;

            string consulta = "SELECT * FROM Clientes WHERE borrado=0 and id_cliente=" + idCliente;
            DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);

            if (tabla.Rows.Count > 0)
            {
                clienteObtenido = MappingCliente(tabla.Rows[0]);
                return clienteObtenido;
            }
            return null;
        }

        public void actualizarCliente(Cliente cliente)
        {
            string SQLUpdate = "UPDATE Clientes SET cuit=" + cliente.Cuit + ", " +
                                                     "razon_social='" + cliente.Razon_social + "', " +
                                                     "calle='" + cliente.Calle + "', " +
                                                     "numero=" + cliente.Numero + ", " +
                                                     "fecha_alta=CONVERT(date,'" + cliente.Fecha_alta.ToShortDateString() + "',103), " +
                                                     "id_barrio=" + cliente.Barrio.Id_barrio + ", " + 
                                                     "id_contacto=" + cliente.Contacto.Id_contacto + " " +
                                                     "WHERE id_cliente=" + cliente.Id_cliente;

            DataManager.GetInstance().EjecutarSQL(SQLUpdate);
        }
        public void eliminarCliente(Cliente cliente)
        {
            string SQLUpdate = "UPDATE Clientes SET borrado=1 WHERE id_cliente=" + cliente.Id_cliente;

            DataManager.GetInstance().EjecutarSQL(SQLUpdate);
        }
        //Revisar cómo se registra la fecha en la base de datos.
        public void crearCliente(Cliente cliente)
        {
            string SQLInsert = string.Concat("INSERT INTO Clientes(cuit, razon_social, borrado, calle, numero, fecha_alta, id_barrio, id_contacto) VALUES(",
                                                cliente.Cuit, ",'",
                                                cliente.Razon_social, "',",
                                                0, ",'",
                                                cliente.Calle, "',",
                                                cliente.Numero, ",CONVERT(date,'",
                                                cliente.Fecha_alta.ToShortDateString(), "',103),",
                                                cliente.Barrio.Id_barrio, ",",
                                                cliente.Contacto.Id_contacto, ")");

            DataManager.GetInstance().EjecutarSQL(SQLInsert);
        }
        private Cliente MappingCliente(DataRow row)
        {
            Cliente oCliente = new Cliente
            {
                Id_cliente = Convert.ToInt32(row["id_cliente"].ToString()),
                Cuit = Convert.ToInt64(row["cuit"].ToString()),
                Razon_social = row["razon_social"].ToString(),
                Calle = row["calle"].ToString(),
                Numero = Convert.ToInt32(row["numero"].ToString()),
                Fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString()),
                Barrio = oBarrioDao.GetBarrio(row["id_barrio"].ToString()),
                Contacto = oContactoDao.GetContacto(row["id_contacto"].ToString())
            };

            return oCliente;
        }
    }
}
