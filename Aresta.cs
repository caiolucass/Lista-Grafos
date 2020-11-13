using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<sumary name="Caio Lucas F. Dos Santos  604365" name = "Wernen Rodrigues Maciel" />

namespace Lista_pratica
{
    public class Aresta
    {

        private int peso;
        private Vertice vert_1;
        private Vertice vert_2;
        private int direcao;

        ///<sumary name="Construtor do grafo não-dirigido"/>
        ///<param name="peso"  name="vertice vert_1" name="vertice vert_2"/>
        public Aresta(int peso, Vertice vert_1, Vertice vert_2)
        {
            this.peso = peso;
            this.vert_1 = vert_1;
            this.vert_2 = vert_2;
        }

        ///<sumary name="Construtor do grafo dirigido"/>
        ///<param name="peso"  name="vertice vert_1" name="vertice vert_2" name="direcao"/>
        public Aresta(int peso, Vertice vert_1, Vertice vert_2, int direcao)
        {
            this.peso = peso;
            this.vert_1 = vert_1;
            this.vert_2 = vert_2;
            this.direcao = direcao;
        }

        ///<sumary name="Imprimir as informações das arestas"/>
        public override string ToString()
        {
            // verifica se é direcionado
            if (this.direcao != 0)
            {
                if (this.direcao == 1)
                {
                    return this.vert_1.Nome + "->" + this.vert_2.Nome;
                }
                else
                {
                    return this.vert_2.Nome + "->" + this.vert_2.Nome;
                }
            }
            else
            {
                return this.vert_1.Nome + "--" + this.vert_2.Nome;
            }
        }

        ///<sumary name="Seção para os métodos Getters e Setters"/>
        //Peso
        public int Peso
        {
            get => peso;
            set => peso = value;
        }

        //Direção
        public int Direcao
        {
            get => direcao;
            set => direcao = value;
        }

        //Vertice v1
        internal Vertice Vert_1
        {
            get => vert_1;
            set => vert_1 = value;
        }

        //Vertice v2
        internal Vertice Vert_2
        {
            get => vert_2;
            set => vert_2 = value;
        }
    }
}