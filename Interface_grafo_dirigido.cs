using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 /*
  *Interface do grafo dirigido, com os métodos complementares
  *Caio Lucas F. Dos Santos  Matrícula:604365
  *Wernen Rodrigues Maciel   Matrícula:597704
  */
namespace Lista_pratica{
    
    public interface Interface_grafo_dirigido{
        int get_GrauEntrada(Vertice v1);
        int get_GrauSaida(Vertice v1);
        bool Has_Ciclo();
    }
}