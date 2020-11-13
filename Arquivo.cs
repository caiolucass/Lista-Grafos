using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lista_pratica
{
    class Arquivo
    {
        string ArquivoNome;
        StreamReader Leitor;

        
        /*
        *@Sumary: Construtor classe Arquivo
        */
        public Arquivo (string ArquivoNome)
        {
            this.ArquivoNome = ArquivoNome;
           //ArquivoNome = 'C:\Users\Wernen\Documents\Lista_pratica\bin\Debug\netcoreapp3.1\Grafo_dirigido';
            if (this.ArquivoNome.IndexOf(".txt") == -1)
            {
                this.ArquivoNome = this.ArquivoNome + ".txt";
            }
            this.Leitor = new StreamReader(this.ArquivoNome);
        }

        /*
         *@Sumary: Metodo de Leitura de Arquivo
         */
        public string[] LeituraAquivo()
        {
            string linha = this.Leitor.ReadToEnd();
            string[] Arquivo;

            linha = linha.Replace("\r", "");

            Arquivo = linha.Split('\n');

            this.Leitor.Close();

            return Arquivo;
        }
    }
}
