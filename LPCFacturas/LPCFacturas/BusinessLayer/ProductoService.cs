using LPCFacturas.DataAccessLayer;
using LPCFacturas.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LPCFacturas.BusinessLayer
{
    class ProductoService
    {
        private ProductoDao oProductoDao = new ProductoDao();

        public IList<Producto> recuperarTodos()
        {
            return oProductoDao.GetAll();
        }

        public Producto recuperarProducto(string idProducto)
        {
            return oProductoDao.GetProducto(idProducto);
        }

        internal void crearProducto(Producto oProducto)
        {
            oProductoDao.crearProducto(oProducto);
        }
        internal void actualizarProducto(Producto oProducto)
        {
            oProductoDao.actualizarProducto(oProducto);
        }
        internal void eliminarProducto(Producto oProducto)
        {
            oProductoDao.eliminarProducto(oProducto);
        }

        public DataTable recuperarProductos(DateTime fechaDesde, DateTime fechaHasta, string nombre)
        {
            return oProductoDao.recuperarProductos(fechaDesde, fechaHasta, nombre);
        }

        public DataTable recuperarProductosEstadisticas()
        {
            return oProductoDao.recuperarProductosEstadisticas();
        }

        public DataTable recuperarProcutosEstadisticasImporte()
        {
            return oProductoDao.recuperarProductosEstadisticasImporte();
        }

        internal IList<Producto> recuperarProductoNombre(string nomProducto)
        {
            return oProductoDao.recuperarProductoNombre(nomProducto);
        }
    }   
}
