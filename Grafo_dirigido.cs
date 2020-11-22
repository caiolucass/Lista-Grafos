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
    
    public class Grafo_dirigido : Grafo, Interface_grafo_dirigido{
        /*
         *Construtor da classe do grafo dirigido
         */
        public Grafo_dirigido(string[] Arquivo) : base(Arquivo){
            this.preencher_Grafo();
        }

        /*
         *Método de preenchimento do grafo
         */
        private void preencher_Grafo(){
            string[] Linha;
            int peso_Aresta;
            Vertice Vert_1, Vert_2;
            Vertice Vert_1_aux, Vert_2_aux;
            Aresta nova_Aresta;
            int direcao_Aresta;

            for (int i = 1; i < this.Arquivo.Length; i++) {
                Linha = this.Arquivo[i].Split(';');
                Vert_1 = new Vertice(Linha[0]);
                Vert_2 = new Vertice(Linha[1]);

                Vert_1_aux = this.procurar_Vertice(Vert_1);
                Vert_2_aux = this.procurar_Vertice(Vert_2);

               if (Vert_1_aux == null)
                {
                    this.Lista_Vertice.Add(Vert_1);
                }
                else{
                    Vert_1 = Vert_1_aux;
                }

                if (Vert_2_aux == null){
                    this.Lista_Vertice.Add(Vert_2);
                } else
                {
                    Vert_2 = Vert_2_aux;
                }

                // verifica se um vértice não consta na lista de adjacência do outro.
                // aciona os métodos para de adicionar adjacente para o vértice 1 e 2.
                if (!this.IsAdjacente(Vert_1, Vert_2)){
                    Vert_1.adicionar_Adjacente(Vert_2);
                    Vert_2.adicionar_Adjacente(Vert_1);
                }

                peso_Aresta = int.Parse(Linha[2]);
                direcao_Aresta = int.Parse(Linha[3]);
                nova_Aresta = new Aresta(peso_Aresta, Vert_1, Vert_2, direcao_Aresta);

                this.Lista_Aresta.Add(nova_Aresta);

                Vert_1.adicionar_Aresta(nova_Aresta);
                Vert_2.adicionar_Aresta(nova_Aresta);
            }
        }

        /*
         *Método para obter o grau de entrada do vértice
         */
        public int get_GrauEntrada(Vertice v1){
            int grauEntrada = 0;
            v1 = procurar_Vertice(v1);

            if (v1 == null) {
                return -1;
            }
            for (int i = 0; i < v1.Adjacente.Count(); i++){
                
                for (int x = 0; x < v1.Adjacente[i].Aresta.Count(); x++){
                    if (v1.Adjacente[i].Aresta[x].Vert_1    == v1 && v1.Adjacente[i].Aresta[x].Direcao == -1 ||
                        v1.Adjacente[i].Aresta[x].Vert_2 == v1 && v1.Adjacente[i].Aresta[x].Direcao == 1){
                        grauEntrada++;
                    }
                }
            }
            return grauEntrada;
        }

        /*
         *Método para obter o grau de saída do vértice
         */
        public int get_GrauSaida(Vertice v1) {
            int grauSaida = 0;
            v1 = procurar_Vertice(v1);

            if (v1 == null){
                return -1;
            }
            for (int i = 0; i < v1.Adjacente.Count(); i++){
                for (int j = 0; j < v1.Adjacente[i].Aresta.Count(); j++){

                    if (v1.Adjacente[i].Aresta[j].Vert_1 == v1 && v1.Adjacente[i].Aresta[j].Direcao == 1 ||
                        v1.Adjacente[i].Aresta[j].Vert_2 == v1 && v1.Adjacente[i].Aresta[j].Direcao == -1) {
                        grauSaida++;
                    }
                }
            }
            return grauSaida;
        }

        /*
         *Método para ver se o grafo possui ciclo
         */
        public bool Has_Ciclo() {
            return true;
        }
    }
}
