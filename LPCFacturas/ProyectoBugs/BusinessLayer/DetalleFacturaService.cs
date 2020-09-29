using LPCFacturas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;


namespace LPCFacturas.BusinessLayer
{
    class DetalleFacturaService
    {
        private DetalleFacturaDao oDetalleFacturaDao = new DetalleFacturaDao();

        public IList<DetalleFactura> recuperarTodos(string idFactura)
        {
            return oDetalleFacturaDao.GetAll(idFactura);
        }
    }

}
