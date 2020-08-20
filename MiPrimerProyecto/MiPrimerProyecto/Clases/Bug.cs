using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Clases
{
    class Bug
    {
        private int id_bug;
        private string titulo;
        private string descripcion;
        private DateTime fecha_alta;
        private int id_usuario_responsable;
        private int id_usuario_asignado;
        private int id_producto;
        private int id_prioridad;
        private int id_criticidad;
        private int id_estado;
        private bool borrado;

        public Bug(int id_bug, string titulo, string descripcion, DateTime fecha_alta, int id_usuario_responsable, int id_usuario_asignado,
                   int id_producto, int id_prioridad, int id_criticidad, int id_estado, bool borrado)
        {
            this.Id_bug = id_bug;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Fecha_alta = fecha_alta;
            this.Id_usuario_responsable = id_usuario_responsable;
            this.Id_usuario_asignado = id_usuario_asignado;
            this.Id_producto = id_producto;
            this.Id_prioridad = id_prioridad;
            this.Id_criticidad = id_criticidad;
            this.Id_estado = id_estado;
            this.Borrado = borrado;
        }

        public int Id_bug { get => id_bug; set => id_bug = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public int Id_usuario_responsable { get => id_usuario_responsable; set => id_usuario_responsable = value; }
        public int Id_usuario_asignado { get => id_usuario_asignado; set => id_usuario_asignado = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Id_prioridad { get => id_prioridad; set => id_prioridad = value; }
        public int Id_criticidad { get => id_criticidad; set => id_criticidad = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
    }
}
