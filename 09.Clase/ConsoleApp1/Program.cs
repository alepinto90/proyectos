using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=. ; DataBase=SistemaGestion1 ; Trusted_Connection=True;";

           
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Usuario";
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    using (SqlDataReader datareader = comando.ExecuteReader())
                    {
                        if (datareader.HasRows)
                        {
                            while (datareader.Read()) 
                  
                            {
                                var dato = datareader.GetString(1);
                                Console.WriteLine(dato);
                            }
                                              
                        }
                    }
                }

                    
                
                connection.Close();
            }
        }
    }
}