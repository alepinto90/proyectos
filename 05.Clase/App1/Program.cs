
namespace App1
{

    class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto(01, "pañal", 3.45, 0, "Limpieza");

            if(producto.hayPrecioDeVenta())
            {
                Console.WriteLine("El producto esta a la venta");
            }
            else
            {
                Console.WriteLine("El producto no fue publicado aun");
            }
            //instancia ---> producto
        }
    }




}