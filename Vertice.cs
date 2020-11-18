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

    public class Vertice{
        private string titulo;
        private List<Vertice> adjacente;
        private List<Aresta> aresta;
       
        /*
         *Construtor da classe vertice
         */
        public Vertice(string titulo){
            this.titulo = titulo;
            this.adjacente = new List<Vertice>();
            this.aresta = new List<Aresta>();
        }

        /*
         *Método para adicionar vertice adjacente
         */
        public void adicionar_Adjacente(Vertice vertice){
            this.adjacente.Add(vertice);
        }

        /*
         *Méotodo para adicionar aresa
         */
        public void adicionar_Aresta(Aresta aresta){
            this.aresta.Add(aresta);
        }

        /*
         *Método para  obter o vértice adjacente
         */
        public Vertice get_Adjacente(Vertice vertice){

            //percorre os vértices adjacentes
            for (int i = 0; i < this.adjacente.Count(); i++)
            {
                //verifica se o vertice é igual ao vertice adjacente
                if (vertice.titulo == this.adjacente[i].titulo){
                    return this.adjacente[i];
                }
            }
            return null;
        }

        /*
         *Método para obter a aresta de ligacao
         */
        public Aresta get_ArestaLigacao(Vertice vertice, List<Aresta> aresta){

            for (int i = 0; i <= aresta.Count(); i++){
                if (Convert.ToInt32 (vertice.titulo) == this.aresta[i].Peso) {
                    return this.aresta[i];
                }
            }
            return aresta[0];
        }

       /*
         *Sessão dos métodos Getters e Setters
         */
        public string Titulo{
            get { return titulo; }
            set { titulo = value; }
        }

        //Lista de vértices adjacentes
        public List<Vertice> Adjacente{
            get => adjacente;
            set => adjacente = value;
        }

        //Lista de arestas
        public List<Aresta> Aresta{
            get => aresta;
            set => aresta = value;
        }
    }
}