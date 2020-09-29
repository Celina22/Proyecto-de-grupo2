using LPCFacturas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;


namespace LPCFacturas.BusinessLayer
{
    class FacturaService
    {
        FacturaDao oFacturaDao = new FacturaDao();

        public void CrearFactura(Factura oFactura)
        {
            oFacturaDao.CrearFactura(oFactura);
        }
    }
}
