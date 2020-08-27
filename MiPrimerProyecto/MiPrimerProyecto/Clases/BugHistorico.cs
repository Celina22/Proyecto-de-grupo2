using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Clases
{
    class BugHistorico
    {
        Datos oBD = new Datos();
        
        private int id_bug_historico;
        private DateTime fecha_historico;
        private string titulo;
        private string descripcion;
        private int id_bug;
        private int id_usuario_responsable;
        private int id_usuario_asignado;
        private int id_producto;
        private int id_prioridad;
        private int id_criticidad;
        private int id_estado;
        private int borrado;

        public int Id_bug_historico { get => id_bug_historico; set => id_bug_historico = value; }
        public DateTime Fecha_historico { get => fecha_historico; set => fecha_historico = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id_bug { get => id_bug; set => id_bug = value; }
        public int Id_usuario_responsable { get => id_usuario_responsable; set => id_usuario_responsable = value; }
        public int Id_usuario_asignado { get => id_usuario_asignado; set => id_usuario_asignado = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Id_prioridad { get => id_prioridad; set => id_prioridad = value; }
        public int Id_criticidad { get => id_criticidad; set => id_criticidad = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        public int Borrado { get => borrado; set => borrado = value; }

        public DataTable recuperarHistorico(int idBug)
        {
            string query =  "SELECT h.fecha_historico, ur.usuario as Responsable, e.nombre as Estado, ua.usuario \"Asignado a\" " +
                            "FROM BugsHistorico h LEFT JOIN Usuarios ur ON h.id_usuario_responsable=ur.id_usuario " +
                            "LEFT JOIN Usuarios ua ON h.id_usuario_asignado=ua.id_usuario " +
                            "JOIN Estados e ON h.id_estado=e.id_estado " +
                            "WHERE id_bug=" + idBug + " " +
                            "ORDER BY h.fecha_historico DESC";
            return oBD.consultar(query);
        }
    }
}
