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
        private int id_producto;
        private string descripcion;
        private string version;
        private string alcance;
        private int id_responsable;


        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Version { get => version; set => version = value; }
        public string Alcance { get => alcance; set => alcance = value; }
        public int Id_responsable { get => id_responsable; set => id_responsable = value; }


    }
}
