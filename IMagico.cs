using System;

namespace ArenaRPG
{
    // INTERFAZ: Un contrato que otorga habilidades mágicas a quien lo firme.
    public interface IMagico
    {
        // Las interfaces no tienen 'public' ni 'private' en sus miembros.
        // Tampoco tienen llaves { }. Solo definen QUÉ se debe hacer.
        
        int Mana { get; set; }
        void LanzarHechizo();
    }
}
