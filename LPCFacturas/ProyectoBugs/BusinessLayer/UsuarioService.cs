using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.DataAccessLayer;
using LPCFacturas.Entities;

namespace LPCFacturas.BusinessLayer
{
    public class UsuarioService
    {
        private UsuarioDao oUsuarioDao;
        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }
        public IList<Usuario> recuperarTodos()
        {
            return oUsuarioDao.GetAll();
        }

        public Usuario ValidarUsuario(string usuario, string password)
        {
            Usuario usr = oUsuarioDao.GetUser(usuario);

            if (usr != null)
            { 
                if (usr.Password != null && usr.Password.Equals(password))
                {
                    return usr;
                }
            }
            return null;
        }

        public Usuario recuperarUsuario(string nombreUsuario)
        {
            return oUsuarioDao.GetUser(nombreUsuario);
        }
    }
}
