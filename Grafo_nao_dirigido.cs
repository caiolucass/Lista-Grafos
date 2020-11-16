using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*Caio Lucas F. Dos Santos  Matrícula:604365
*Wernen Rodrigues Maciel   Matrícula:597704
*/

namespace Lista_pratica
{
    public class Grafo_nao_dirigido : Grafo, Interface_grafo_nao_dirigido
    {
        /*
         *Construtor do grafo não-dirigido
         */
        public Grafo_nao_dirigido (string[] Arquivo) : base(Arquivo)
        {
            this.preencher_Grafo();
        }

        ///<sumary name="Método para adicionar vértices e arestas aos grafos"/>
        private void preencher_Grafo()
        {
            string[] Linha;
            int pesoAresta;
            Vertice Vert_1, Vert_2;
            Vertice Vert_1_aux, Vert_2_aux;
            Aresta novaAresta;

            //percorre o arquivo e inicia na linha "1" porque tem a quantidade de vértice
            for (int i = 1; i < this.Arquivo.Length; i++)
            {
                Linha = this.Arquivo[i].Split(';');
                if (Linha[0] == "") continue;
                Vert_1 = new Vertice(Linha[0]);
                Vert_2 = new Vertice(Linha[1]);

                Vert_1_aux = this.procurar_Vertice(Vert_1);
                Vert_2_aux = this.procurar_Vertice(Vert_1);

                //verifica se o vértice existe
                if (Vert_1_aux == null)
                {
                    this.Lista_Vertice.Add(Vert_1);
                }
                else
                {
                    Vert_1 = Vert_1_aux;
                }

                if (Vert_2_aux == null)
                {
                    this.Lista_Vertice.Add(Vert_1);
                }
                else
                {
                    Vert_2 = Vert_2_aux;
                }

                // verifica se um vértice não consta na lista de adjacência do outro,
                // chama os métodos para adicionar adjacente para o vértice 1 e 2
                if (!this.IsAdjacente(Vert_1, Vert_2))
                {
                    Vert_1.adicionar_Adjacente(Vert_2);
                    Vert_2.adicionar_Adjacente(Vert_1);
                }

                pesoAresta = int.Parse(Linha[2]);
                novaAresta = new Aresta(pesoAresta, Vert_1, Vert_2);

                this.Lista_Aresta.Add(novaAresta);

                Vert_1.adicionar_Aresta(novaAresta);
                Vert_2.adicionar_Aresta(novaAresta);
            }
        }

        ///<sumary name="Método para obter o numero de graus"/>
        ///<param name="vertice"/>
        public int GetGrau(Vertice v1)
        {
            v1 = procurar_Vertice(v1);

            if (v1 == null)
            {
                return -1;
            }
            return v1.Aresta.Count();
        }


        ///<sumary name="Método para ver se vértices sao isolados"/>
        ///<param name="vértice"/>
        public bool IsIsolado(Vertice v1)
        {
            //verifica se o vertice é existe
            if (this.procurar_Vertice(v1) == null)
            {
                return false;
            }
            return v1.Adjacente.Count() == 0;
        }

        public string GetCaminho(Vertice origem, Vertice vertAux, Vertice destino, List<String> caminho, int index, List<Vertice> visitados)
        {
            Aresta arestaAux;

            vertAux = origem;
            arestaAux = vertAux.get_ArestaLigacao(destino, null);
            if (arestaAux.Vert_1 != destino && arestaAux.Vert_2 != destino)
            {
                if (arestaAux.Vert_1 != vertAux)
                {
                    vertAux = arestaAux.Vert_1;
                }
                else
                {
                    return arestaAux.ToString();
                }

            }
            else
            {
                return arestaAux.ToString();
            }
            // Regra de formação
            GetCaminho(vertAux, null, destino, caminho, index, null);

            return arestaAux.ToString();
        }

                ///<sumary name="Método para ver se o vértice é pendente"/>
                ///<param name="vertice"/>
                public bool IsPendente(Vertice v1)
        {
            //verifica se o vertice é existe
            v1 = procurar_Vertice(v1);

            if (v1 == null)
            {
                return false;
            }
            return this.GetGrau(v1) == 1;
        }

        ///<sumary name="Método para ver se o grafo é regular"/>
        public bool IsRegular()
        {
            int grau_Prim_Vert = this.GetGrau(this.Lista_Vertice[0]);

            for (int i = 1; i < this.Lista_Vertice.Count(); i++)
            {
                if (this.GetGrau(Lista_Vertice[i]) != grau_Prim_Vert)
                {
                    return false;
                }
            }
            return true;
        }

        ///<sumary name="Método para ver se o grafo é nulo"/>
        public bool IsNulo()
        {
            for (int i = 0; i < this.Lista_Vertice.Count(); i++)
            {
                if (!this.IsIsolado(this.Lista_Vertice[i]))
                {
                    return false;
                }
            }
            return true;
        }

        ///<sumary name="Método para ver se o grafo é completo"/>
        public bool IsCompleto()
        {
            for (int i = 0; i < this.Lista_Vertice.Count(); i++)
            {
                for (int x = 0; x < this.Lista_Vertice.Count(); x++)
                {
                    if (x == i)
                        continue;
                    if (!this.IsAdjacente(this.Lista_Vertice[i], this.Lista_Vertice[x]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        ///<sumary name="Método para ver se o grafo é conexo"/>
        public bool IsConexo()
        {
            int posicao = 0;

            List<string> caminho = new List<string>();
            List<Vertice> visitados = new List<Vertice>();
            this.GetCaminho(this.Lista_Vertice[0], null, this.Lista_Vertice[3], caminho, posicao, visitados);

            return true;
        }

        ///<sumary name="Método para ver se o grafo é euleriano"/>
        public bool IsEuleriano()
        {
            return true;
        }

        ///<sumary name="Método para ver se o grafo é unicursal"/>
        public bool IsUnicursal()
        {
            return true;
        }

        ///<sumary name="Método para ver se o grafo é complementar"/>
        public Grafo GetComplementar()
        {
            return new Grafo(new string[] { "1", "2" });
        }

        ///<sumary name="Método para retornar sua ávore gerada mínima"/>
        public Grafo GetAGMPrim(Vertice v1)
        {
            return new Grafo(new string[] { "1", "2" });
        }

        ///<sumary name="Método para retornar sua ávore gerada mínima"/>
        public Grafo GetAGMKruskal(Vertice v1)
        {
            return new Grafo(new string[] { "1", "2" });
        }
    }
}