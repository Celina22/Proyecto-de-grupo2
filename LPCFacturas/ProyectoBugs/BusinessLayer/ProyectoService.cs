using LPCFacturas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;

namespace LPCFacturas.BusinessLayer
{
    class ProyectoService
    {
        private ProyectoDao oProyectoDao;
        public ProyectoService()
        {
            oProyectoDao = new ProyectoDao();
        }

        public IList<Proyecto> recuperarTodos()
        {
            return oProyectoDao.GetAll();
        }

        public Proyecto recuperarProyecto(string idProyecto)
        {
            return oProyectoDao.GetProyecto(idProyecto);
        }

        public void crearProyecto(Proyecto proyecto)
        {
            oProyectoDao.crearProyecto(proyecto);
        }

        public void actualizarProyecto(Proyecto proyecto)
        {
            oProyectoDao.actualizarProyecto(proyecto);
        }

        public void eliminarProyecto(Proyecto proyecto)
        {
            oProyectoDao.eliminarProyecto(proyecto);
        }
    }
}
