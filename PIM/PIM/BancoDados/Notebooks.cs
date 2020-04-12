using System;
using System.Collections.Generic;
using System.Text;
using PIM.Equipamentos;

namespace PIM.Notebooks
{
    public class Notebook : Equipamento
    {
        Notebook notebook1 = new Notebook() 
        { 
            Id = 1, 
            Modelo = "Sony Vaio i456", 
            CodigoSerie = 01325546, 
            Voltagem = 110, 
            Alugado = false 
        };
        Notebook notebook2 = new Notebook()
        {
            Id = 2,
            Modelo = "Positivo dual",
            CodigoSerie = 032465,
            Voltagem = 110,
            Alugado = false
        };
        Notebook notebook3 = new Notebook()
        {
            Id = 3,
            Modelo = "Dell boladao i9",
            Voltagem = 220,
            Alugado = false
        };

        public int EstoqueNotebook()
        {
            return Notebook.Id.Count();
        }
    }
}
