using _00_ArenaRPG_Base;
using System;

namespace ArenaRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("=== BIENVENIDOS A LA ARENA DE MITOS Y LEYENDAS (UNIFRANZ) ===");
            Console.WriteLine("==========================================================\n");
            
            Console.WriteLine("Repositorio Original del Líder Técnico (Docente)");
            Console.WriteLine("Estado actual: Esperando la integración del equipo de desarrollo...\n");

            Console.WriteLine("--- INICIA LA BATALLA ---");



            // ------------------------------------------------------------------------
            // ZONA DE PRUEBAS (MERGE DE PULL REQUESTS)
            // ------------------------------------------------------------------------
            // Docente: Una vez que los estudiantes hagan sus Pull Requests y los apruebes, 
            // descomenta el código de abajo para demostrar que sus clases funcionan en conjunto.

            // Prueba del Estudiante 1: (Clase Jukumari)
            Jukumari oso = new Jukumari();
            // Console.WriteLine("Nombre: " + oso.Nombre);
            //Console.WriteLine("Vida: " + oso.Vida);
            oso.Atacar();

            // Prueba del Estudiante 2: (Clase Duende + Interfaz)
            Duende enemigo = new Duende();
            enemigo.Atacar();
            oso.RecibirDanio(20);
            enemigo.SoltarBotin(); // Proviene de IRecompensable
            /*
            // Prueba del Estudiante 3: (Clase Supay + Interfaces)
            Supay jefeMagico = new Supay();
            jefeMagico.LanzarHechizo(); // Proviene de IMagico
            
            // Prueba del Estudiante 4: (Interfaz Nueva + Clase)
            Sacerdote sanador = new Sacerdote();
            sanador.CurarAliado(); // Proviene de ICurador (creada por el estudiante 4)
            */

            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}
