using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCFacturas.Entities
{
    class Contacto
    {
        private int id_contacto;
        private string nombre;
        private string apellido;
        private string email;
        private int telefono;

        public int Id_contacto { get => id_contacto; set => id_contacto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
