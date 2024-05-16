using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable1
{
    public class Usuario   //propiedades: Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail
    {
        protected int Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string NombreUsuario { get; set; }
        protected int Contraseña { get; set; }
        protected string Mail { get; set; }
    }
}