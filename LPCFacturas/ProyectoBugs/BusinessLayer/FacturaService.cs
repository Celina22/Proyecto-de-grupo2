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

        public string CrearFactura(Factura oFactura)
        {
            return oFacturaDao.CrearFactura(oFactura);
        }

        public Factura GetFactura(string idFactura)
        {
            return oFacturaDao.GetFactura(idFactura);
        }

    }
}
