using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable1
{
    Public class ProductoVendido   ///Id, IdProducto, Stock, IdVenta
    {
        protected int Id { get; set; }
        protected int IdProducto { get; set; }
        protected bool Stock { get; set; }
        protected int IdVenta { get; set; }
    }
}