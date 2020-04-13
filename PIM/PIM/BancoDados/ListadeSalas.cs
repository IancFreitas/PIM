using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PIM.Locais;

namespace PIM.ListadeSalas
{
    class BasedeDadosSalas
    {
        public static List<Local> SalasdaEscola = new List<Local>()
        {
            new Locais.Local{Ocupada=false, Sala="Sala da Vídeo", NumeroSala=43, Id=1},
            new Locais.Local{Ocupada=false, Sala="Sala de Teatro", NumeroSala=52, Id=2},
            new Locais.Local{Ocupada=false, Sala="Sala de Apresentação", NumeroSala=12, Id=3}
        };
        public static int SalasLiberadas()
        {
            return SalasdaEscola.OfType<Local>().Where(x => x.Ocupada == false).Count();
        }
        public static int SalasOcupadas()
        {
            return SalasdaEscola.OfType<Local>().Where(x => x.Ocupada == true).Count();
        }
        public static int SalasTotais()
        {
            return SalasdaEscola.OfType<Local>().Count();
        }
    }
}
