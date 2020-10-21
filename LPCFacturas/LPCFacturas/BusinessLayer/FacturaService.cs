using LPCFacturas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;
using System.Data;

namespace LPCFacturas.BusinessLayer
{
    class FacturaService
    {
        FacturaDao oFacturaDao = new FacturaDao();

        public string CrearFactura(Factura oFactura)
        {
            return oFacturaDao.CrearFactura(oFactura);
        }

        public Factura GetFactura(string numeroFactura)
        {
            return oFacturaDao.GetFactura(numeroFactura);
        }

        public DataTable recuperarFacturas(DateTime fechaDesde, DateTime fechaHasta, string cliente, string monto)
        {
            return oFacturaDao.recuperarFacturas(fechaDesde, fechaHasta, cliente, monto);
        }

        public DataTable recuperarTodas()
        {
            return oFacturaDao.recuperarTodas();
        }

        public DataTable recuperarTodasPorMes()
        {
            return oFacturaDao.recuperarTodasPorMes();
        }

        public DataTable recuperarTodasTotal()
        {
            return oFacturaDao.recuperarTodasTotal();
        }
    }
}
