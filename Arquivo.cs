using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/*
*Caio Lucas F. Dos Santos  Matrícula:604365
*Wernen Rodrigues Maciel   Matrícula:597704
*/

namespace Lista_pratica{

    class Arquivo{
        string ArquivoNome;
        StreamReader Leitor;
 
        /*
        * Construtor da classe Arquivo
        */
        public Arquivo (string ArquivoNome){
            this.ArquivoNome = ArquivoNome;
            
            //verifica se o arquivo contem "txt"
            if (this.ArquivoNome.IndexOf(".txt") == -1) {
                this.ArquivoNome = this.ArquivoNome + ".txt";
            }
            this.Leitor = new StreamReader(this.ArquivoNome);
        }

        /*
         *Metodo de Leitura de Arquivo
         */
        public string[] LeituraAquivo(){
            string linha = this.Leitor.ReadToEnd();
            string[] Arquivo;

            linha = linha.Replace("\r", "");
            Arquivo = linha.Split('\n');
            this.Leitor.Close();
            return Arquivo;
        }
    }
}
