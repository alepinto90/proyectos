using Entregable2.Database;
using Entregable2.Models;

namespace Entregable2
{
    public class Program
    {
        static void Main(string[] args)
        {
            productoData productoData = new productoData();
            ProductoVendidoData productoVendidoData = new ProductoVendidoData();
            UsuarioData usuarioData = new UsuarioData();
            VentaData ventaData = new VentaData();

            try
            {
                Producto productoNuevo = new Producto("Lapiz", 350.00, 250.00, 25, 4); //no logro entender porque no genera el dato, he buscado la solucion pero no la encuentro.
                if (productoData.CreateProduct(productoNuevo))
                {
                    Console.WriteLine("PRODUCTO CREADO");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Usuario nuevoUsuario = new Usuario("Alejandro", "Enrique", "Xtru", "123456", "alejandro@hotmail.com"); //se compila bien en la base de datos
                if (usuarioData.CreateUser(nuevoUsuario))
                {
                    Console.WriteLine("USUARIO CREADO");
                }
            }
            catch (Exception ex) { 
            }
        }
    }
}