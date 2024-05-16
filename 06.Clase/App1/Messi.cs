using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Messi : Jugador, IJugador
    {
        public Messi(int velocidad, int tiro, int regate, int defenza, int pase, int fisico) : base(velocidad, tiro, regate, defenza, pase, fisico)
        {
        }

        public void colocarPase()
        {
            Console.WriteLine("Messi coloco pase con {0} de propiedad", this.Pase);
        }

        public void correr()
        {
            Console.WriteLine("Messi corrio con {0} de propiedad", this.Velocidad);
        }

        public void defender()
        {
            Console.WriteLine("Messi defendio con {0} de propiedad", this.Defenza);
        }

        public void regatear()
        {
            Console.WriteLine("Messi regateo con {0} de propiedad", this.Regate);
        }

        public void rematar()
        {
            Console.WriteLine("Messi remato con {0} de propiedad", this.Tiro);
        }

        public void soportarEmbate()
        {
            Console.WriteLine("Messi soporto el embate con {0} de propiedad", this.Fisico);
        }
    }
}
