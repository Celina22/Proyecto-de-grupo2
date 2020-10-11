using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Clases
{
    class Bug
    {
        Datos oBD = new Datos();

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


        public Bug(int id_bug, string titulo, string descripcion, DateTime fecha_alta, int id_usuario_responsable, int id_usuario_asignado, int id_producto, int id_prioridad, int id_criticidad, int id_estado, bool borrado)
        {
            this.id_bug = id_bug;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.fecha_alta = fecha_alta;
            this.id_usuario_responsable = id_usuario_responsable;
            this.id_usuario_asignado = id_usuario_asignado;
            this.id_producto = id_producto;
            this.id_prioridad = id_prioridad;
            this.id_criticidad = id_criticidad;
            this.id_estado = id_estado;
            this.borrado = borrado;
        }

        public Bug()
        { 
            this.id_bug = 0;
            this.titulo = "";
            this.descripcion = "";
            this.fecha_alta = DateTime.Today;
            this.id_usuario_responsable = 0;
            this.id_usuario_asignado = 0;
            this.id_producto = 0;
            this.id_prioridad = 0;
            this.id_criticidad = 0;
            this.id_estado = 0;
            this.borrado = false;
        }

        public int Id_bug { get => id_bug; set => id_bug = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public int Id_usuario_responsable { get => id_usuario_responsable; set => id_usuario_responsable = value; }

        public DataTable filtrarBugs(string fecha_desde, string fecha_hasta, string estado, string prioridad, string producto, string asignadoA, string criticidad)
        {
            string query = "SELECT b.id_bug, b.titulo, p.nombre Producto, b.fecha_alta, e.nombre Estado, u.usuario \"Asignado a\", c.nombre Criticidad, pr.nombre Prioridad " +
                            "FROM Bugs b JOIN Productos p ON b.id_producto=p.id_producto " +
                            "JOIN Estados e ON b.id_estado=e.id_estado " +
                            "JOIN Usuarios u ON b.id_usuario_asignado=u.id_usuario " +
                            "JOIN Criticidades c ON b.id_criticidad=c.id_criticidad " +
                            "JOIN Prioridades pr ON b.id_prioridad=pr.id_prioridad " +
                            "WHERE b.fecha_alta BETWEEN CONVERT(date,'" + fecha_desde + "',103) AND CONVERT(date,'" + fecha_hasta + "',103) ";
            if (estado != "")
                query += "AND b.id_estado=" + estado + " ";
            if (prioridad != "")
                query += "AND b.id_prioridad=" + prioridad + " ";
            if (producto != "")
                query += "AND b.id_producto=" + producto + " ";
            if (asignadoA != "")
                query += "AND b.id_usuario_asignado=" + asignadoA + " ";
            if (criticidad != "")
                query += "AND b.id_criticidad=" + criticidad + " ";

            query = query + "ORDER BY b.fecha_alta DESC";
            return oBD.consultar(query);
        }

        public int Id_usuario_asignado { get => id_usuario_asignado; set => id_usuario_asignado = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Id_prioridad { get => id_prioridad; set => id_prioridad = value; }
        public int Id_criticidad { get => id_criticidad; set => id_criticidad = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public DataTable recuperarTodos()
        {
            string query =  "SELECT b.id_bug, b.titulo, p.nombre Producto, b.fecha_alta, e.nombre Estado, u.usuario \"Asignado a\", c.nombre Criticidad, pr.nombre Prioridad " +
                            "FROM Bugs b JOIN Productos p ON b.id_producto=p.id_producto " +
                            "JOIN Estados e ON b.id_estado=e.id_estado " +
                            "JOIN Usuarios u ON b.id_usuario_asignado=u.id_usuario " +
                            "JOIN Criticidades c ON b.id_criticidad=c.id_criticidad " +
                            "JOIN Prioridades pr ON b.id_prioridad=pr.id_prioridad " +
                            "ORDER BY b.fecha_alta DESC";
            return oBD.consultar(query);
        }

        public DataTable recuperarBug(int idBug)
        {
            string query =  "SELECT b.id_bug, b.titulo, p.nombre Producto, b.fecha_alta, b.descripcion, e.nombre Estado, u.usuario \"Asignado a\", c.nombre Criticidad, pr.nombre Prioridad " +
                            "FROM Bugs b JOIN Productos p ON b.id_producto=p.id_producto " +
                            "JOIN Estados e ON b.id_estado=e.id_estado " +
                            "JOIN Usuarios u ON b.id_usuario_asignado=u.id_usuario " +
                            "JOIN Criticidades c ON b.id_criticidad=c.id_criticidad " +
                            "JOIN Prioridades pr ON b.id_prioridad=pr.id_prioridad " +
                            "WHERE b.id_bug=" + idBug;
            return oBD.consultar(query);
        }
        /*public void crearBug()
        {
            string insertSQL = "INSERT INTO Bugs"
            DataManager.GetInstance().EjecutarSQL
        }*/
    }
}
