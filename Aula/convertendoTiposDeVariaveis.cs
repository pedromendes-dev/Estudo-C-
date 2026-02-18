using System;


// Processo de conversão chamdo de Cast - Casting
// Convert é uma classe que contém métodos estáticos para converter valores de um tipo para outro
// ToInt é um método estático da classe Convert que converte uma string em um inteiro
int a = Convert.ToInt32("10");
// um type para outro type
Console.WriteLine(a);


// Usando ToString()
int numero = 10;
string texto = Convert.ToString(numero);
Console.WriteLine(texto); // Saída: "10"


// Usando Convert.ToString()
int numero2 = 10;
string texto2 = numero2.ToString();
Console.WriteLine(texto2); // Saída: "10"

// Usando interpolação de string
int numero3 = 10;
string texto3 = $"{numero3}";
Console.WriteLine(texto3); // Saída: "10"

//---

// Ele convete strings em int 32-bit
int b = int.Parse("10");
Console.WriteLine(b);


//---

/* Se eu tentar passar algo que não seja um string,
gera um erro, Argumento 1: não é possível converter de "int" para "System.ReadOnlySpan<byte>" */
int b = int.Parse(10);
Console.WriteLine(b);

int b = Convert.ToInt32("AA");
Console.WriteLine(b);

// ---

// DIFERNÇA DE PARSE PARA O CONVERT


/* É o tratamento de valores nullos 

 . Parse é mais rápido, mas lança uma exceção se a string não for válida.
...
....
*/

int a = Convert.ToInt32(null);
Console.WriteLine(a);
/* O Convert fez o seguinte ele imprimu o valor zero e não deu erro na execução do código
A null representa um valor vazio
Quando você tentar converter um valor usando a classe Converte usando o nullo ele sempre vai retorna sem erros
*/ 

int a = int.Parse(null);
Console.WriteLine(a);
/* Gerou um erro 'O valor não pode ser nullo'
...
*/


// Conversão de strings
// - ToString();

string a = 5;
// Erro eu estou esperando um valor que seja uma string
string a = "5";
// Os Types não se misturam, para isso é preciso fazer o processo de Cast- Casting 

//ex:
int inteiro = 5;
string a = inteiro.ToString();
Console.WriteLine(a);
// output 5


string a = 5.ToString("F2");  // Formatação de número com 2 casas decimais
Console.WriteLine(a);
// output 5,00


// Com strings usamos o Emty ele retorna uma string vazia
// string.Empty é uma constante que representa "" (string vazia).
string vazio = string.Empty;
// 'or' string vazio = null ?? string.Empty;
Console.WriteLine(vazio);


//---

// Cast Implícito

// Cast implícito é quando o compilador converte automaticamente um tipo de dado para outro tipo compatível.
// Exemplo: int para long, float para double, etc.

// O double suporta valores inteiros e o flot suporta valores double...

int inteiro = 10;
long longo = inteiro;  // Cast implícito de int para long
Console.WriteLine(longo);  // Output: 10

float flutuante = 10.5f;
double duplo = flutuante;  // Cast implícito de float para double
Console.WriteLine(duplo);  // Output: 10.5

/* --Redundancia--
ex:
int a = 5;
double b = Convert.ToDouble(a);
Console.WriteLine(b);

*/


/* Erros que não são aceitos ao tentar buildar
ex:
long a = 5;
int b = a;
Console.WriteLine(b);

ex:
double a = 5;
int b = a;
Console.WriteLine(b);

*/

// Precisa realizar a conversão manualmente
double a = 5;
int b = (int)a;
Console.WriteLine(b);
// or
double a = 5;
int b = Convert.ToInt32(a);
Console.WriteLine(b);

//---

long a =  long.MaxValue;
int b = Convert.ToInt32(a);
// Erro -  Value was either too large or too small for an Int32.

int x = int.MaxValue;
long y = x;
Console.WriteLine(y);
// output 2147483647