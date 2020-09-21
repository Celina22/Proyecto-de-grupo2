using LPCFacturas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;
using LPCFacturas.DataAccessLayer;

namespace LPCFacturas.BusinessLayer
{
    class PerfilService
    {
        private PerfilDao oPerfilDao;

        public PerfilService()
        {
            oPerfilDao = new PerfilDao();
        }

        public IList<Perfil> recuperarTodos()
        {
            return oPerfilDao.GetAll();
        }
        public Perfil recuperarPerfil(string idPerfil)
        {
            return oPerfilDao.GetPerfil(idPerfil);
        }
    }
}
