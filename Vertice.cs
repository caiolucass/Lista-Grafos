using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///<sumary name="Caio Lucas F. Dos Santos  604365" name = "Wernen Rodrigues Maciel" />

namespace Lista_pratica
{
    public class Vertice
    {
        private string nome;
        private List<Vertice> adjacente;
        private List<Aresta> aresta;
       

        ///<sumary name="Construtor"/>
        ///<param name="nome"/>
        public Vertice(string nome)
        {
            this.nome = nome;
            this.adjacente = new List<Vertice>();
            this.aresta = new List<Aresta>();
        }

        ///<sumary name="Método para adicionar vértice adjacente"/>
        ///<param name="vértice"/>
        public void adicionar_Adjacente(Vertice vertice)
        {
            this.adjacente.Add(vertice);
        }

        ///<sumary name="Método para adicionar arestas"/>
        ///<param name="arestas"/>
        public void adicionar_Aresta(Aresta aresta)
        {
            this.aresta.Add(aresta);
        }

        ///<sumary name="Método para obter os vértices adjacentes"/>
        ///<param name="vértice"/>
        public Vertice get_Adjacente(Vertice vertice)
        {
            //percorre os vértices adjacentes
            for (int i = 0; i < this.adjacente.Count(); i++)
            {
                //verifica se o vertice é igual ao vertice adjacente
                if (vertice.nome == this.adjacente[i].nome)
                {
                    return this.adjacente[i];
                }
            }
            return null;
        }

        ///<sumary name="Método para obter os vértices adjacentes"/>
        ///<param name="vértice"/>
        public Aresta get_ArestaLigacao(Vertice vertice, List<Aresta> aresta)
        {
            for (int i = 0; i <= aresta.Count(); i++)
            {
                if (Convert.ToInt32 (vertice.nome) == this.aresta[i].Peso)
                {
                    return this.aresta[i];
                }
            }
            return aresta[0];
        }

        ///<sumary name="Seção para os métodos Getters e Setters"/>
        //Nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //Lista de vértices adjacentes
        internal List<Vertice> Adjacente
        {
            get => adjacente;
            set => adjacente = value;
        }

        //Lista de arestas
        public List<Aresta> Aresta
        {
            get => aresta;
            set => aresta = value;
        }
    }
}