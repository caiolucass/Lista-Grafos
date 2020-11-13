using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<sumary name="Caio Lucas F. Dos Santos  604365" name = "Wernen Rodrigues Maciel" />

namespace Lista_pratica
{
    public interface Interface_grafo_dirigido
    {
        int get_GrauEntrada(Vertice v1);

        int get_GrauSaida(Vertice v1);

        bool Has_Ciclo();
    }
}