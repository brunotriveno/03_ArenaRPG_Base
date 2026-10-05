using System;

namespace ArenaRPG
{
    // INTERFAZ: Un contrato para entidades (como enemigos) que sueltan botín al ser derrotados.
    public interface IRecompensable
    {
        void SoltarBotin();
    }
}
