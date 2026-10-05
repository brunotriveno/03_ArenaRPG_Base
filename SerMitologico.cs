using System;

namespace ArenaRPG
{
    // CLASE ABSTRACTA: El molde base para todo personaje en el juego.
    // No se puede instanciar directamente con 'new SerMitologico()'.
    public abstract class SerMitologico
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }

        // MÉTODO NORMAL (Heredado): Todos los hijos lo tienen idéntico y listo para usar.
        public void RecibirDanio(int cantidad)
        {
            Vida -= cantidad;
            Console.WriteLine($"{Nombre} recibió {cantidad} de daño. Vida restante: {Vida}");
        }

        // MÉTODO ABSTRACTO: Obliga a cada clase hija a definir CÓMO ataca.
        // (El contrato de la herencia).
        public abstract void Atacar();
    }
}
