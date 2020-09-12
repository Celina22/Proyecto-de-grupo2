using LPCFacturas.DataAccessLayer;
using LPCFacturas.Entities;
using ProyectoBugs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
