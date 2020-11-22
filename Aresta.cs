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

    public class Aresta{

        private int peso;
        private Vertice vert_1;
        private Vertice vert_2;
        private int direcao;

        /*
         *Construtor d aresta nao dirigida
         */
        public Aresta(int peso, Vertice vert_1, Vertice vert_2){
            this.peso = peso;
            this.vert_1 = vert_1;
            this.vert_2 = vert_2;
        }

         /*
         *Construtor da aresta dirigida
         */
        public Aresta(int peso, Vertice vert_1, Vertice vert_2, int direcao){
            this.peso = peso;
            this.vert_1 = vert_1;
            this.vert_2 = vert_2;
            this.direcao = direcao;
        }

         /*
         *Imprimi as informações das arestas
         */
        public override string ToString(){

            // verifica se a aresta é direcionada
            if (this.direcao != 0){

                if (this.direcao == 1){
                    return this.vert_1.Titulo + "->" + this.vert_2.Titulo;
                }else
                {
                    return this.vert_2.Titulo + "->" + this.vert_2.Titulo;
                }
            }else {
                return this.vert_1.Titulo + "--" + this.vert_2.Titulo;
            }
        }

        /*
         *Seção dos métodos Getters e Setter
         */
        //Peso
        public int Peso{
            get => peso;
            set => peso = value;
        }

        //Direção
        public int Direcao{
            get => direcao;
            set => direcao = value;
        }

        //Vertice v1
        public Vertice Vert_1{
            get => vert_1;
            set => vert_1 = value;
        }

        //Vertice v2
        public Vertice Vert_2{
            get => vert_2;
            set => vert_2 = value;
        }
    }
}