using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCFacturas.Entities
{
    class Proyecto
    {
        private int id_proyecto;
        private string nombreProducto;
        private string descripcion;
        private string version;
        private string alcance;
        private string nombreResponsable;


        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Version { get => version; set => version = value; }
        public string Alcance { get => alcance; set => alcance = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string NombreResponsable { get => nombreResponsable; set => nombreResponsable = value; }
    }
}
