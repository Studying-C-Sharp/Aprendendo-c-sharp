Estudos em C# Basico

using System; //forma de fazer importação de classes quando necessario

Console.WriteLine(""); //escreve algo na tela
Strng s = Console.ReadLine() //recebe uma string do que foi digitado no console
Console.ReadKey(); //pausa o programa e aguarda qualquer telca ser precionada
// Lê do console um caractere simples.
char c = (char)Console.Read( ); //le apenas um char

//Classes
Uma classe define atributos e métodos que implementam a estrutura de dados
e as suas operações, respectivamente.

//Modificadores
Quando o modificador de acesso não é especificado, o compilador assume o
modificador default “private”.


//classes
[modificador de acesso] class <identificador> : [classe base]
{
// declaração de atributos e métodos
}

//metodos
[modificador de acesso] [tipo do método] <tipo do valor de retorno>
<identificador do método>([lista de parâmetros])
{
	// implementação
}

//Parametros
Quando não é especificado o tipo de passagem do parâmetro por default, a
passagem é por valor e não requer nenhum modificador adicional para tal
fim.

parametros com array
Quando o método receber mais de um parâmetro, o parâmetro array deve ser
o último da lista.

Estuturas struct
[modificador de acesso] struct <nome da estrutura> : [interface]
{
//membros da estrutura
}

Para criarmos uma variável de um tipo struct:
<tipo_struct> identificador = new <tipo_struct>[parâmetros do construtor]


//Quando usar estruturas
Se as estruturas são tão semelhantes a classes, então quando devemos usar estruturas
e quando devemos usar classes? Vejamos:
so Quando se está lidando com estruturas de dados pequenas.
so Quando não precisamos de suporte para o mecanismo de herança.
O uso de classes é mais custoso em termos de desempenho e uso da memó-
ria, portanto, quando as duas características acima forem verdadeiras, o
recomendado é usar uma estrutura e não uma classe

//para dados Enumerados Enumerados
string (“G”), hexa (“x”) ou decimal(“d”).

//arrays - OBS manipulação da arrays é treta pra porra

//A seguir, temos a declaração de um array de inteiros unidimensional:
int[ ] arrInt = new int[2] ;
//As três formas a seguir são válidas para inicializar um array quando é feita sua
//declaração:
int[ ] arrInt = new int[2] {0,1}; //ou
int[ ] arrInt = new int[ ] {0,1}; //ou
int[ ] arrInt = {0,1} ;
//Declarando um exemplo multidimensional de 2×2 dimensões:
int[,] arrInt = new int[2,2] ;
//Inicializando o array:
int[,] arrInt = new int[2,2] {{0,0},{0,1}}
//Declarando um array de arrays:
private int[ ][,] ArrDeArr = new int[2][,] {new int[2,3], new int[4,5]};
Inicializando o array na declaração:
private int[ ][,] ArrDeArr = new int[2][,] {new int[2,2] {{1,2},{3,4}}, new int[2,2]{{5,6},{7,8}}};

