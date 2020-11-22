using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *"Caio Lucas F. Dos Santos  Matrícula:604365
 *Wernen Rodrigues Maciel    Matrícula:597704
 */
namespace Lista_pratica{ 
    
    public interface Interface_grafo_nao_dirigido {
        bool IsAdjacente(Vertice v1, Vertice v2);
        int GetGrau(Vertice v1);
        bool IsIsolado(Vertice v1);
        bool IsPendente(Vertice v1);
        bool IsRegular();
        bool IsNulo();
        bool IsCompleto();
        bool IsConexo();
        bool IsEuleriano();
        bool IsUnicursal();
        Grafo GetComplementar();
        Grafo GetAGMPrim(Vertice v1);
        Grafo GetAGMKruskal(Vertice v1);
    }
}
