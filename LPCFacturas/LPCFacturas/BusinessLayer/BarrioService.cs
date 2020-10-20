using LPCFacturas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;

namespace LPCFacturas.BusinessLayer
{
    class BarrioService
    {
        private BarrioDao oBarrioDao;
        public BarrioService()
        {
            oBarrioDao = new BarrioDao();
        }

        public IList<Barrio> recuperarTodos()
        {
            return oBarrioDao.GetAll();
        }

        public Barrio recuperarBarrio(string idBarrio)
        {
            return oBarrioDao.GetBarrio(idBarrio);
        }

        public void crearBarrio(Barrio barrio)
        {
            oBarrioDao.crearBarrio(barrio);
        }

        public void actualizarBarrio(Barrio barrio)
        {
            oBarrioDao.actualizarBarrio(barrio);
        }

        public void eliminarBarrio(Barrio barrio)
        {
            oBarrioDao.eliminarBarrio(barrio);
        }
    }
}
