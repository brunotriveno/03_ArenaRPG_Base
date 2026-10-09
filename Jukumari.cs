using ArenaRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ArenaRPG_Base
{
    public class Jukumari : SerMitologico
    {
        public Jukumari() {
            Nombre = "Oso Jukumari";
            Vida = 200;

        }
        public override void Atacar()
        {
            Console.WriteLine("El Jukumari da un zarpazo brutal!");
        }
    }
}
