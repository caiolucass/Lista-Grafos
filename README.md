<h2 align=center>:book: PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS :book:</h2>
<h3 align=center>Instituto de Ciências Exatas e Informática</h3>
<h3 align=center>Curso: Sistemas de informação / 2° semestre de 2020</h3>
<h3 align=center>Lista prática / Algoritmos em grafos</h3>
<h3 align=center>Membros: Caio Lucas F. Dos Santos / Wernen Rodrigues Maciel</h3>

<h3 align=center>Regras</h3>
Para  a  realização  dos  testes  e  avaliação  do  código  desenvolvido,  será  fornecido  um  arquivo  texto  de entrada que apresentará, na primeira linha, o número de vertices do grafo. As linhas seguintes desse arquivo  de  entrada  conterão,  cada  uma, informações  sobre  cada  aresta do grafo,  no  seguinte formato: vértice  v1;  vértice  v2;  peso  da  aresta;  direção  da  aresta.  Apenas  grafos  dirigidos apresentarão esse último valor em cada linha do arquivo de entrada. Se o valor desse parâmetro for 1, a aresta é direcionada de v1 para v2. Se o valor desse parâmetro for -1, a aresta tema direção contrária, sendo direcionada, portanto, de v2 para v1.

<h3 align=center>:warning: Requisitos :warning:</h3>

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
- [x] Grafo getAGMKruskal (Vertice v1)
- [x] int getCutVertices ()

### Grafos não-dirigidos

- [x] int getGrauEntrada (Vertice v1)
- [x] int getGrauSaida(Vertice v1)
- [x] bool hasCiclo ();
