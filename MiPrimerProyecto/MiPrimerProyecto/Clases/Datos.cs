using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiPrimerProyecto.Clases
{
    class Datos
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private string cadenaConexion = @"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=BugsTracker;Persist Security Info=True;User ID=sa;Password=42258137Jnc";

        public string CadenaConexion 
        { 
            get => cadenaConexion; set => cadenaConexion = value; 
        }

        private void conectar()
        {
            this.conexion.ConnectionString = CadenaConexion;
            this.conexion.Open();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            this.conexion.Close();
        }
        
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            this.comando.CommandText = consultaSQL;
            tabla.Load(this.comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }
        public DataTable consultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            this.comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(this.comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }
    }
}
