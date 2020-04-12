using System;
using System.Collections.Generic;
using System.Text;
using PIM.Locais;

namespace PIM.SalasdeAula
{
    class Salas : Local
    {
        Salas sala1 = new Salas()
        {
            Ocupada = true,
            Sala = "Sala da Vídeo",
            NumeroSala = 43,
            Id = 1
        };

        Salas sala2 = new Salas()
        {
            Ocupada = false,
            Sala = "Coordenação",
            NumeroSala = 52,
            Id = 2
        };
        Salas sala3 = new Salas()
        {
            Ocupada = false,
            Sala = "Sala dos Professores",
            NumeroSala = 12,
            Id = 3
        };

    }
}
