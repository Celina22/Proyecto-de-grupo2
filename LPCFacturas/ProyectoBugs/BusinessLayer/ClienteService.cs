using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.DataAccessLayer;
using LPCFacturas.Entities;

namespace LPCFacturas.BusinessLayer
{
    class ClienteService
    {
        private ClienteDao oClienteDao;
        public ClienteService()
        {
            oClienteDao = new ClienteDao();
        }

        public Cliente recuperarCliente(string idCliente)
        {
            return oClienteDao.GetCliente(idCliente);
        }
        public IList<Cliente> recuperarTodos()
        {
            return oClienteDao.GetAll();
        }

        public void crearCliente(Cliente cliente)
        {
            oClienteDao.crearCliente(cliente);
        }
        public void actualizarCliente(Cliente cliente)
        {
            oClienteDao.actualizarCliente(cliente);
        }
        public void eliminarCliente(Cliente cliente)
        {
            oClienteDao.eliminarCliente(cliente);
        }

        public DataTable recuperarClientes()
        {
            return oClienteDao.recuperarCLientes();
        }

        public DataTable recuperarClientes(DateTime fechaDesde, DateTime fechaHasta, string barrio)
        {
            return oClienteDao.recuperarCLientes(fechaDesde, fechaHasta, barrio);
        }
    }
}
