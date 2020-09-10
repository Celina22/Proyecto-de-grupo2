using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MiPrimerProyecto.Clases
{
    class Usuario
    {   //Declaración de los atributos que contiene la clase
        Datos objetoDatos = new Datos();

        private int id_usuario;
        private string n_usuario;
        private string password;
        private string email;
        private int id_perfil;
        private string estado; 
        private int borrado;

        //Declaracion de propiedades para acceder a los getters y setters 
        public int Id_Usuario { get => id_usuario; set => id_usuario = value; }
        public string N_usuario { get => n_usuario; set => n_usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        public string Estado { get => estado; set => estado = value; }

        public int validarUsuario(string nombre, string clave)
        {
            string consultaSQL = "SELECT * FROM Usuarios WHERE usuario='" + nombre + "' AND password='" + clave + "'";
            DataTable tabla = new DataTable();

            
            tabla = objetoDatos.consultar(consultaSQL);

            if (tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }

        public DataTable recuperarUsuarios()
        {
            return objetoDatos.consultarTabla("Usuarios");
        }

        public DataTable recuperarUsuario(int idUsuario)
        {
            string query = "SELECT * FROM Usuarios WHERE id_usuario = " + idUsuario;
            return objetoDatos.consultar(query);
        }

        public bool validarDatosUsuario()
        {
            if (this.N_usuario == string.Empty)
            {
                MessageBox.Show("El campo \"nombre\" está vacío.", "Nombre vacío", MessageBoxButtons.OK);
                return false;
            }

            if (this.Password == string.Empty)
            {
                MessageBox.Show("El campo \"Password\" está vacío.", "Contraseña no válida", MessageBoxButtons.OK);
                return false;
            }

            if (this.Email == string.Empty)
            {
                MessageBox.Show("El campo \"Email\" está vacío.", "Email vacío", MessageBoxButtons.OK);
                return false;
            }

            if (this.Id_perfil == null)
            {
                MessageBox.Show("El campo \"Email\" está vacío.", "Email vacío", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public void grabarNuevoUsuario()
        {
            string InsertSQL = "INSERT INTO Usuarios (usuario, password, email, id_perfil, estado, borrado) " +
                                "VALUES ('" +
                                this.N_usuario + "','" +
                                this.Password + "','" +
                                this.Email + "'," +
                                this.Id_perfil + ",'" +
                                this.Estado + "'," +
                                this.Borrado + ")";
            objetoDatos.actualizar(InsertSQL);
        }

        public void actualizarUsuario()
        {
            string UpdateSQL = "UPDATE Usuarios SET usuario='" +
                                this.N_usuario + "', password='" +
                                this.Password + "', email='" +
                                this.Email + "', id_perfil=" +
                                this.Id_perfil + ", estado='" +
                                this.Estado + "', borrado=" +
                                this.Borrado + " " +
                                "WHERE id_usuario=" +
                                this.Id_Usuario;
            objetoDatos.actualizar(UpdateSQL);
        }

        public void eliminarUsuario()
        {
            string UpdateSQL = "UPDATE Usuarios SET borrado=1" +
                                this.Borrado + " " +
                                "WHERE id_usuario=" +
                                this.Id_Usuario;
            objetoDatos.actualizar(UpdateSQL);
        }
        public bool existe()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDatos.consultar("SELECT * FROM Usuarios WHERE usuario='" + this.n_usuario + "'");
            if (tabla.Rows.Count != 0)
                return true;
            else
                return false;
        }
    }
}
