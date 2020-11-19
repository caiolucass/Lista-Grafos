## :book: PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS :book:
### Instituto de Ciências Exatas e Informática
### Curso: Sistemas de Informação / 2° semestre de 2020
### Lista Prática / Algortimos em Grafos
### Membros: Caio Lucas F. Dos Santos/ Wernen Rodrigues Maciel

## Regras
Para  a  realização  dos  testes  e  avaliação  do  código  desenvolvido,  será  fornecido  um  arquivo  texto  de entrada que apresentará, na primeira linha, o número de verticesdo grafo. As linhas seguintes desse arquivo  de  entrada  conterão,  cada  uma, informações  sobre  cada  arestadografo,  no  seguinte formato: vértice  v1;  vértice  v2;  peso  da  aresta;  direção  da  aresta.  Apenas  grafos  dirigidos apresentarão esse último valor em cada linha do arquivo de entrada. Se o valor desse parâmetro for 1, a aresta é direcionada de v1para v2. Se o valor desse parâmetro for -1, a aresta tema direção contrária, sendo direcionada, portanto,de v2para v1.Seguem exemplos de arquivos de entrada.

### :warning: 1. Requisitos :warning:
### Grafos dirigidos
- [x] bool isAdjacente (Vertice v1, Vertice v2)
- [x] int getGrau (Vertice v1)
- [x] bool isIsolado (Vertice v1)b
- [x] bool isPendente (Vertice v1)
- [x] bool isRegular ()
- [x] bool isNulo ()
- [x] bool isCompleto ()
- [x] bool isConexo ()
- [x] bool isEuleriano ()
- [x] bool isUnicursal ()
- [x] Grafo getAGMPrim (Vertice v1)
- [x] Grafo  getAGMKruskal (Vertice  v1)
- [x] int  getCutVertices  ()

### Grafos não-dirigidos
- [x] int getGrauEntrada (Vertice v1)
- [x] int getGrauSaida(Vertice v1)
- [x] bool hasCiclo ();


