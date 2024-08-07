﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class UsuarioData
    {

        public static bool DeleteUser(int id)
        {
            string connectionString = "Server=.;Database=SistemaGestion1;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                conn.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool CreateUser(Usuario usuario)
        {
            string connectionString = "Server=.;Database=SistemaGestion1;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuario(Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                    "VALUES(@nombre, @apellido, @nombreUsuario, @contraseña, @mail)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                command.Parameters.AddWithValue("@mail", usuario.Mail);
                conn.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static Usuario GetUserByID(int id)
        {
            string connectionString = "Server=.;Database=SistemaGestion1;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["Id"]);
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    string nombreUsuario = reader["NombreUsuario"].ToString();
                    string contraseña = reader["Contraseña"].ToString();
                    string mail = reader["Mail"].ToString();
                    Usuario usuario = new Usuario(userId, nombre, apellido, nombreUsuario, contraseña, mail);
                    return usuario;
                }
                throw new Exception("Id no encontrado");
            }
        }

        public static bool UpdateUser(Usuario usuario)
        {
            string connectionString = "Server=.;Database=SistemaGestion1;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuario SET Nombre = @nombre, Apellido = @apellido, NombreUsuario = @nombreUsuario, Contraseña = @contraseña, Mail = @mail WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                command.Parameters.AddWithValue("@mail", usuario.Mail);
                command.Parameters.AddWithValue("@id", usuario.Id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static List<Usuario> GetUsuario()
        {
            string connectionString = "Server=.;Database=SistemaGestion1;Trusted_Connection=True;";
            List<Usuario> listaUsuarios = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(reader["Id"]);
                            usuario.Nombre = reader["Nombre"].ToString();
                            usuario.Apellido = reader["Apellido"].ToString();
                            usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                            usuario.Contraseña = reader["Contraseña"].ToString();
                            usuario.Mail = reader["Mail"].ToString();
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
                return listaUsuarios;
            }
        }
    }
}
