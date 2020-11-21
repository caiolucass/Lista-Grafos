using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*Caio Lucas F. Dos Santos  Matrícula:604365
*Wernen Rodrigues Maciel   Matrícula:597704
*/
namespace Lista_pratica{

   public class Grafo{

        int quant_Vertices;
        string[] arquivo;
        bool direcinado;

         /*
         *Lista de vértice e arestas
         */
        List<Vertice> lista_Vertice;
        List<Aresta> lista_Aresta;

        /*
         *Construtor da classe grafos
         */
        public Grafo(string[] Arquivo){
            this.quant_Vertices = int.Parse(Arquivo[0]);
            this.Arquivo = Arquivo;

            this.lista_Vertice = new List<Vertice>();
            this.lista_Aresta = new List<Aresta>();
        }

        /*
         *Método de busca de vértice no grafo
         */
        public Vertice procurar_Vertice(Vertice v){
            for (int i = 0; i < lista_Vertice.Count(); i++) {

                if (lista_Vertice[i].titulo == v.titulo){
                    return lista_Vertice[i];
                }
            }
            return null;
        }

        /*
         *Método para ver se os vértices sao adjacentes
         */
        public bool IsAdjacente(Vertice v1, Vertice v2){
            v1 = this.procurar_Vertice(v1);
            v2 = this.procurar_Vertice(v2);

            if (v1 == null || v2 == null){
                return false;
            }
            for (int i = 0; i < this.lista_Vertice.Count(); i++){

                if (this.lista_Vertice[i].titulo == v1.titulo){

                    for (int j = 0; j < this.lista_Vertice[i].Adjacente.Count(); j++){

                        if (this.lista_Vertice[i].Adjacente[j].titulo == v2.titulo){
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /*
         *Imprimi as informações do grafo
         */
        public override string ToString(){
            string arq = "";

            //percorre todas as linhas do arquivo
            for (int i = 1; i < this.Arquivo.Length; i++){
                arq += this.Arquivo[i] + "\n";
            }
            return arq;
        }

        /*
         *Seção dos métodos Getters e Setters
         */       
        //Quantidade de vertices
        public int Quant_Vertices{
            get => quant_Vertices;
            set => quant_Vertices = value;
        }

        //Arquivo
        public string[] Arquivo{
            get => arquivo;
            set => arquivo = value;
        }

        //Direcionado
        public bool Direcinado{
            get => direcinado;
            set => direcinado = value;
        }

        //Lista de vertices
        public List<Vertice> Lista_Vertice{
            get => lista_Vertice;
            set => lista_Vertice = value;
        }

        //Lista de arestas
        public List<Aresta> Lista_Aresta{
            get => lista_Aresta;
            set => lista_Aresta = value;
        }
    }
}
