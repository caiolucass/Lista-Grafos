﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<sumary name="Caio Lucas F. Dos Santos  604365" name = "Wernen Rodrigues Maciel" />

namespace Lista_pratica
{
    /*Classe de grafos*/
   public class Grafo
    {

        int quant_Vertices;
        string[] arquivo;
        bool direcinado;

        ///<sumary name="Lista de Vértices e Arestas"/>
        List<Vertice> lista_Vertice;
        List<Aresta> lista_Aresta;

        ///<sumary name="Construtor"/>
        public Grafo(string[] Arquivo)
        {
            this.quant_Vertices = int.Parse(Arquivo[0]);
            this.Arquivo = Arquivo;

            this.lista_Vertice = new List<Vertice>();
            this.lista_Aresta = new List<Aresta>();
        }

        ///<sumary name="Método para procurar vértices no grafo"/>
        ///<param name="vertice v"/>
        public Vertice procurar_Vertice(Vertice v)
        {
            for (int i = 0; i < lista_Vertice.Count(); i++)
            {
                if (lista_Vertice[i].Nome == v.Nome)
                {
                    return lista_Vertice[i];
                }
            }
            return null;
        }


        ///<sumary name="Método para ver se os vertices sao adjacentes"/>
        ///<param name="vertice v1"  name="vertice v2"/>
        public bool IsAdjacente(Vertice v1, Vertice v2)
        {
            v1 = this.procurar_Vertice(v1);
            v2 = this.procurar_Vertice(v2);

            //verifica se os vertices sao nulos
            if (v1 == null || v2 == null)
            {
                return false;
            }

            //percorre a lista de vertices, contando seus numeros
            for (int i = 0; i < this.lista_Vertice.Count(); i++)
            {
                //verifica se os vertices possuem o mesmo nome, caso possua, sao adjacentes
                if (this.lista_Vertice[i].Nome == v1.Nome)
                {
                    //verifica se os vertices possuem o mesmo nome, caso possua, sao adjacentes
                    for (int j = 0; j < this.lista_Vertice[i].Adjacente.Count(); j++)
                    {
                        //percorre a lista de vertices, contando seus numeros
                        if (this.lista_Vertice[i].Adjacente[j].Nome == v2.Nome)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        ///<sumary name="Imprimir as informações do grafo"/>
        public override string ToString()
        {
            string arq = "";

            //percorre todas as linhas do arquivo
            for (int i = 1; i < this.Arquivo.Length; i++)
            {
                arq += this.Arquivo[i] + "\n";
            }
            return arq;
        }

        ///<sumary name="Seção dos métodos Getters e Setters"/>
        //Quantidade de vertices
        public int Quant_Vertices
        {
            get => quant_Vertices;
            set => quant_Vertices = value;
        }

        //Arquivo
        public string[] Arquivo
        {
            get => arquivo;
            set => arquivo = value;
        }

        //Direcionado
        public bool Direcinado
        {
            get => direcinado;
            set => direcinado = value;
        }

        //Lista de vertices
        public List<Vertice> Lista_Vertice
        {
            get => lista_Vertice;
            set => lista_Vertice = value;
        }

        //Lista de arestas
        public List<Aresta> Lista_Aresta
        {
            get => lista_Aresta;
            set => lista_Aresta = value;
        }
    }
}