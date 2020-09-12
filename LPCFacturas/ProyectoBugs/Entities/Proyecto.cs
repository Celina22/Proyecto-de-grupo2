using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPCFacturas.Entities;
using ProyectoBugs.Entities;

namespace LPCFacturas.Entities
{
    class Proyecto
    {
        private int id_proyecto;
        private Producto producto;
        private string descripcion;
        private string version;
        private string alcance;
        private Usuario responsable;


        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Version { get => version; set => version = value; }
        public string Alcance { get => alcance; set => alcance = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public Usuario Responsable { get => responsable; set => responsable = value; }
    }
}
