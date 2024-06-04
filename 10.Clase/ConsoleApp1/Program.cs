using ConsoleApp1.Database;
using System.Data.SqlClient;

namespace ConsoleApp1.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();  

            try
            {
                //if (gestorBaseDeDatos.DeleteUser(2))
                //{
                //    Console.WriteLine("Usuario eliminado");
                //}

                Usuario newUser = new Usuario("Carlos", "Perez", "peres32", "1234123", "calo@mail.com");
                // if (gestorBaseDeDatos.CreateUser(newUser))
                // {
                //     Console.WriteLine("Usuario creado!");
                // }
                Usuario editUser = new Usuario("Cs", "Pz", "pe32", "13", "call.com");
                {
                    Console.WriteLine("Usuario actualizado");
                }

                if (gestorBaseDeDatos.UpdateUser(3, editUser)) ;

            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}