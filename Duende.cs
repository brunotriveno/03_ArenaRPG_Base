using ArenaRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ArenaRPG_Base
{
    public class Duende : SerMitologico, IRecompensable

    {
        public Duende() {
            Nombre = "Duende Ladron";
            Vida = 50;
        }
        public override void Atacar() {
            Console.WriteLine("El duende lanza una piedra!");
    }
        public void SoltarBotin() {
            Console.WriteLine("El duende solto 15 monedas de oro.");
}
    }
}
