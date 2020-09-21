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

        public Contacto recuperarContacto(int idContacto)
        {
            return oContactoDao.GetContacto(idContacto);
        }
    }
}
