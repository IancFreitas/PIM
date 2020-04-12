using System;
using System.Collections.Generic;
using System.Text;
using PIM.Equipamentos;

namespace PIM.Projetores
{
    class Projetor : Equipamento
    {
        Projetor projetor1 = new Projetor()
        {
            Id = 1,
            Modelo = "Epson 410",
            CodigoSerie = 01325546,
            Voltagem = 220,
            Alugado = false
        };
        Projetor projetor2 = new Projetor()
        {
            Id = 2,
            Modelo = "Sony light 12",
            CodigoSerie = 032465,
            Voltagem = 220,
            Alugado = false
        };
        Projetor projetor3 = new Projetor()
        {
            Id = 3,
            Modelo = "HP fullcinema",
            Voltagem = 220,
            Alugado = false
        };
    }
}
