using System;
using System.Collections.Generic;
using System.Text;
using PIM.Equipamentos;

namespace PIM.Tablets
{
    class Tablet : Equipamento
    {
        Tablet tablet1 = new Tablet()
        {
            Id = 1,
            Modelo = "Samsung A16",
            CodigoSerie = 123564,
            Voltagem = 5,
            Alugado = false
        };
        Tablet tablet2 = new Tablet()
        {
            Id = 2,
            Modelo = "Postivo fd5",
            CodigoSerie = 498498,
            Voltagem = 5,
            Alugado = false
        };
        Tablet tablet3 = new Tablet()
        {
            Id = 3,
            Modelo = "Ipad 10",
            Voltagem = 5,
            Alugado = false
        };
    }
}
