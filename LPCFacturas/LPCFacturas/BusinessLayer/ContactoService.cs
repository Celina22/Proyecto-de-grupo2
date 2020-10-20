using LPCFacturas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPCFacturas.Entities;

namespace LPCFacturas.BusinessLayer
{
    class ContactoService
    {
        private ContactoDao oContactoDao;
        public ContactoService()
        {
            oContactoDao = new ContactoDao();
        }

        public Contacto recuperarContacto(string idContacto)
        {
            return oContactoDao.GetContacto(idContacto);
        }
        public IList<Contacto> recuperarTodos()
        {
            return oContactoDao.GetAll();
        }

        public void crearContacto(Contacto contacto)
        {
            oContactoDao.crearContacto(contacto);
        }
        public void actualizarContacto(Contacto contacto)
        {
            oContactoDao.actualizarContacto(contacto);
        }
        public void eliminarContacto(Contacto contacto)
        {
            oContactoDao.eliminarContacto(contacto);
        }
    }
}
