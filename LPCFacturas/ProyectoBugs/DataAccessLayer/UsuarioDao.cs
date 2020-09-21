﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using LPCFacturas.Entities;
using System.Data;

namespace LPCFacturas.DataAccessLayer
{
    public class UsuarioDao
    {
        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            var strSql = "SELECT id_usuario, usuario, email, estado from Usuarios where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuarios.Add(MappingUsuario(row));
            }

            return listadoUsuarios;
        }

        public Usuario GetUser(string pUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT id_usuario, usuario, email, estado, password ",
                                                "   FROM Usuarios ",
                                                "  WHERE borrado=0 and usuario =  '", pUsuario, "'");

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return MappingUsuario(resultado.Rows[0]);
            }

            return null;
        }

        private Usuario MappingUsuario(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                NombreUsuario = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Estado = row["estado"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null
            };

            return oUsuario;
        }

        public void eliminarUsuario(Usuario usuario)
        {
            string SQLUpdate = "UPDATE Usuarios SET borrado = 1 WHERE id_usuario = " + usuario.IdUsuario;

            DBHelper.GetDBHelper().EjecutarSQL(SQLUpdate);
        }

        public void crearUsuario(Usuario usuario)
        {
            string SQLInsert = " INSERT INTO Usuarios(id_perfil, usuario, password, email, estado, borrado) " +
                               "VALUES (" + usuario.Perfil.IdPerfil + ", '" + usuario.NombreUsuario + "', '"
                                            + usuario.Password + "','" + usuario.Email + "','" + usuario.Estado + "', 0) ";

            DBHelper.GetDBHelper().EjecutarSQL(SQLInsert);
        }

        public void actualizarUsuario(Usuario usuario)
        {
            string SQLUpdate = "UPDATE Usuarios SET id_perfil= " + usuario.Perfil.IdPerfil + ", " +
                                                     "usuario= '" + usuario.NombreUsuario + "', " +
                                                     "password= '" + usuario.Password + "', " +
                                                     "email= '" + usuario.Email + "', " +
                                                     "estado= '" + usuario.Estado +"'"+
                                                     " WHERE id_usuario= " + usuario.IdUsuario;

            DBHelper.GetDBHelper().EjecutarSQL(SQLUpdate);
        }
    }

}
