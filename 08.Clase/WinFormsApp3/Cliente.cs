using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public long ID { get; set; }
        public short Edad { get; set; }
        public Cliente (string Nombre, string Direccion, long ID, short Edad)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Edad = Edad;
            this.ID = ID;
        }
        public override bool Equals(object obj)
        {
            Cliente cliente = (Cliente)obj;
            return this.ID.Equals(cliente.ID);
        }
    }
}
