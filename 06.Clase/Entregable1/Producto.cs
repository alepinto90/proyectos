using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable1
{
    internal class Producto   /// Id, Descripcion, Costo, PrecioVentas, Stock, IdUsuario
    {
        protected int Id { get; set; }
        protected string Descripcion { get; set; }
        protected int Costo { get; set; }
        protected int PrecioVentas { get; set; }
        protected bool Stock { get; set; }
        protected int IdUsuario { get; set; }
    }
}
