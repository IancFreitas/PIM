using System;
using System.Collections.Generic;
using System.Text;
using PIM.Equipamentos;
using PIM.Notebooks;
using PIM.Projetores;
using PIM.Tablets;

namespace PIM.ListadeEquipamentos
{
    public static List<Equipamento> EstoquedeEquipamentos = new List<Equipamento>()
    {
        new Notebook(){Id = 1, Alugado = false},
        new Notebook(){Id = 2, Alugado = false},
        new Notebook(){Id = 3, Alugado = false},
        new Projetor(){Id = 1, Alugado = false},
        new Projetor(){Id = 2, Alugado = false},
        new Projetor(){Id = 3, Alugado = false},
        new Tablet(){Id = 1, Alugado = false},
        new Tablet(){Id = 2, Alugado = false},
        new Tablet(){Id = 3, Alugado = false},
    };

    public static int EstoqueNotebook()
    {
        return EstoquedeEquipamentos.OfType<Notebook>().Where(x => x.Alugado == false).Count();
    }



}
