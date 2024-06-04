using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable2.Models
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        public Producto() { }

        public Producto(string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }
        public override string ToString()
        {
            return $"ID = {this.Id} - Descripcion = {this.Descripcion} - Costo = {this.Costo} - PrecioVenta = {this.PrecioVenta} - Stock = {this.Stock} - IdUsuario = {this.IdUsuario}";
        }
    }
}
