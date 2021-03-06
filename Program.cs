﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

/*
 *Caio Lucas F. Dos Santos  Matrícula:604365
 *Wernen Rodrigues Maciel   Matrícula:597704
 */

namespace Lista_pratica{

    class Program{
        static Arquivo arquivo;
        static Random random = new Random();
        static string Arq;
        static bool dirigido;

        /*
         *Metodo criar um grafo
         */
        static void criarGrafo(bool dirigido, string[] Arquivo, ref Grafo_nao_dirigido grafo,
                                                                ref Grafo_dirigido digrafo){
            arquivo = new Arquivo(Arq);
            Arquivo = arquivo.LeituraAquivo();
            dirigido = IsDirecionado(Arquivo[1]);

            if (dirigido){
                digrafo = new Grafo_dirigido(Arquivo);
            }
            else{
                grafo = new Grafo_nao_dirigido(Arquivo);
            }
        }

        /*
         *Método para printar o grafo
         */
        static void PrintGrafo<G>(G grafo){
            Console.WriteLine(grafo.ToString());
        }
        static void Resposta(string responde){
            Console.WriteLine("\n" + responde);
        }

        /*
        *Metodo para saber se o grafo é dirigido 
        */
        static bool isDirigido(string Linha){
            string[] vetor = Linha.Split(';');

            if (vetor.Length == 4){
                return true;
            }
            else{
                return false;
            }
        }

        /*
        *Metodo para verificar se o grafo é Direcionado
        */
        static bool IsDirecionado(string Linha){
            string[] vetor = Linha.Split(';');

            if (vetor.Length == 4){
                return true;
            }
            else{
                return false;
            }
        }

        /*
        *Método principal(main) do programa
        */
        static void Main(string[] args){
            int Menu;
            string resposta;
            Grafo_nao_dirigido grafo = null;
            Grafo_dirigido digrafo = null;
            Vertice v1, v2;
            string[] Arquivo;

            Console.WriteLine("\nArquivos disponiveis para leitura: Grafo_dirigido ou Grafo_nao_dirigido");
            Console.WriteLine("\nInforme o nome do arquivo: ");
            Arq = Console.ReadLine();

            arquivo = new Arquivo(Arq);
            Arquivo = arquivo.LeituraAquivo();
            dirigido = IsDirecionado(Arquivo[1]);

            criarGrafo(dirigido, Arquivo, ref grafo, ref digrafo);
            if (dirigido){
                string vertice;
                int grauVertice;

                do{
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção:\n");
                    menu(dirigido);
                    Console.WriteLine();
                    Menu = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    
                    switch (Menu){
                        case 1:
                            PrintGrafo(digrafo);
                            break;

                        case 2:
                            Console.WriteLine("Informe o nome do vértice:");
                            vertice = Console.ReadLine();
                            v1 = new Vertice(vertice);
                            grauVertice = digrafo.get_GrauEntrada(v1);
                            resposta = (grauVertice == -1) ? "Vértice Inexistente" : "O grau de entrada do vértice é " + grauVertice + ".";
                            Resposta(resposta);
                            break;

                        case 3:
                            Console.WriteLine("Informe o nome do vértice:");
                            vertice = Console.ReadLine();
                            v1 = new Vertice(vertice);
                            grauVertice = digrafo.get_GrauSaida(v1);
                            resposta = (grauVertice == -1) ? "Vértice Inexistente" : "O grau de saída do vértice é " + grauVertice + ".";
                            Resposta(resposta);
                            break;
                        default:

                            if (Menu != 0){
                                Console.WriteLine("\nA Opção escolhida é inválida. Pressione qualquer tecla.");
                            }
                            break;
                    }
                    if (Menu != 0){
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
                        Console.ReadKey();
                    }
                } while (Menu != 0);
            }
            else{

                string vertice;
                do{
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção:\n");
                    menu(dirigido);
                    Console.WriteLine();
                    Menu = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (Menu){
                        case 1:
                            PrintGrafo(grafo);
                            break;

                        case 2:
                            string nomeVert1, nomeVert2;
                            Console.WriteLine("Informe o nome do vértice 1:");
                            nomeVert1 = Console.ReadLine();
                            Console.WriteLine("\nInforme o nome do vértice 2:");
                            nomeVert2 = Console.ReadLine();
                            v1 = new Vertice(nomeVert1);
                            v2 = new Vertice(nomeVert2);
                            resposta = (grafo.IsAdjacente(v1, v2)) ? "Os vértices são adjacentes!" : "Os vértices não são adjacentes.";
                            Resposta(resposta);
                            break;

                        case 3:
                            int grauVertice;
                            Console.WriteLine("Informe o nome do vértice:");
                            vertice = Console.ReadLine();
                            v1 = new Vertice(vertice);
                            grauVertice = grafo.GetGrau(v1);
                            resposta = (grauVertice == -1) ? "Vértice Inexistente" : "O grau do vértice é " + grauVertice + ".";
                            Resposta(resposta);
                            break;

                        case 4:
                            Console.WriteLine("Informe o nome do vértice:");
                            vertice = Console.ReadLine();
                            v1 = new Vertice(vertice);
                            resposta = (grafo.IsPendente(v1)) ? "O vértice é pendente!" : "O vértice não é pendente.";
                            Resposta(resposta);
                            break;

                        case 5:
                            resposta = (grafo.IsRegular()) ? "O grafo é regular!" : "O grafo não é regular.";
                            Resposta(resposta);
                            break;

                        case 6:
                            resposta = (grafo.IsNulo()) ? "O grafo é nulo!" : "O grafo não é nulo.";
                            Resposta(resposta);
                            break;

                        case 7:
                            resposta = (grafo.IsCompleto()) ? "O grafo é completo!" : "O grafo não é completo.";
                            Resposta(resposta);
                            break;

                        case 8:
                            resposta = (grafo.IsUnicursal()) ? "O grafo é Unicursal!" : "O grafo não é Unicursal.";
                            Resposta(resposta);
                            break;

                        case 9:
                            resposta = (grafo.IsEuleriano()) ? "O grafo é Euleriano!" : "O grafo não é Euleriano.";
                            Resposta(resposta);
                            break;

                        case 10:
                            resposta = (grafo.IsConexo()) ? "O grafo é conexo!" : "O grafo não é conexo.";
                            Resposta(resposta);
                            break;

                        default:
                            if (Menu != 0){
                                Console.WriteLine("\nA opção escolhida é inválida. Pressione qualquer tecla e tente novamente.");
                                Console.ResetColor();
                            }
                            break;
                    }
                    if (Menu != 0){
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
                        Console.ReadKey();
                    }
                } while (Menu != 0);
            }
        }

        /*
        *Menu de opções do programa
        */
        static void menu(bool dirigido){

            if (dirigido){
                Console.WriteLine("Nomes: Caio Lucas F. Dos Santos matricula:604365");
                Console.WriteLine("Wernen Rodrigues Maciel matricula:597704");

                Console.WriteLine("Menu do grafo dirigido");
                Console.WriteLine(" 0 - Sair.");
                Console.WriteLine(" 1 - Imprimir grafo.");
                Console.WriteLine(" 2 - Obter o grau de entrada do vértice.");
                Console.WriteLine(" 3 - Obter grau de saída do vértice.");
            }
            else{
                Console.WriteLine("Nomes: Caio Lucas F. Dos Santos matricula:604365");
                Console.WriteLine("Wernen Rodrigues Maciel matricula:597704");
                Console.WriteLine("Menu do grafo não-dirigido");
                Console.WriteLine(" 0 - Sair.");
                Console.WriteLine(" 1 - Imprimir grafo.");
                Console.WriteLine(" 2 - Verificar se pelo menos (2) dois vértices são adjacentes.");
                Console.WriteLine(" 3 - Obter grau o vértice.");
                Console.WriteLine(" 4 - Verificar se um vértice do grafo é pendente.");
                Console.WriteLine(" 5 - Verificar se um vértice do grafo é regular.");
                Console.WriteLine(" 6 - Verificar se um vértice do grafo é nulo.");
                Console.WriteLine(" 7 - Verificar se o grafo é completo.");
                Console.WriteLine(" 8 - Verificar se o grafo é Unicursal.");
                Console.WriteLine(" 9 - Verificar se o grafo é Euleriano.");
                Console.WriteLine(" 10 - Verificar se o grafo é conexo.");
            }
        }
    }
}