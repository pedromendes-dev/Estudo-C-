using System;
using System.Data;
using OrdemOperadores;


// // Class é apenas um molde para criar objetos, ela é apenas um container (molde) de métodos e propriedades

// class Teste
// {
//     static void Main()
//     {
//         PrintarNaTela("Pedro", 25, true);
//     }

//     static void PrintarNaTela(string nome, int idade, bool ativo)
//     {
//         Console.WriteLine($"Nome: {nome}, Idade: {idade}, Ativo: {ativo}");
//     }
// }







// // Exemplo para entender o método Main
// class MinhaClasse
// {
//     static void Funcao1()  // Não roda automaticamente
//     {
//         Console.WriteLine("Funcao1");
//     }

//     static void Main()  // ← ESTA RODA AUTOMATICAMENTE
//     {
//         Console.WriteLine("Main rodou!");
//         Funcao1();  // Aqui você chama explicitamente
//     }

// }



//---------------------------------------------------------------------

// Exemplo de Tipos Primitivos em C#

// string apresentacao = "Olá, seja bem-vindo ao Curso de C#!";
// int quantidadeDeAlunos = 1200;
// double notaMedia = 8.5;
// char letra = 'A';
// decimal valorDoProduto = 199.99m;
// bool estaAprovado = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Quantidade de Alunos: " + quantidadeDeAlunos);
// Console.WriteLine("Nota Média: " + notaMedia);
// Console.WriteLine("Letra: " + letra);
// Console.WriteLine("Valor do Produto: " + valorDoProduto);
// Console.WriteLine("Está Aprovado: " + estaAprovado);


// Exemplo de Tratamento 
// double altura = 1.75;
// Console.WriteLine("Altura: " + altura.ToString("F2")); 


//---------------------------------------------------------------------
// {
//  int numero = 10;
// numero = 20;   // Sobrescreve 
//  Console.WriteLine(numero);  // Output: 20

// // Quando você coloca o tipo vc está declarando ela. Quando vc não coloca o tipo vc está alterando o valor da variável já declarada anteriormente.

// }



//---------------------------------------------------------------------

// Data e Hora em C# em tempo real 

// DateTime dataAtual = DateTime.Now;  // Obtém a data e hora atuais (now = agora)
// Console.WriteLine("Data e Hora Atuais: " + dataAtual);


// DateTime dataAtual = DateTime.Now.AddDays(5);  // Adiciona 5 dias à data atual (5 dias a mais)
// Console.WriteLine("Data e Hora Atuais: " + dataAtual);


// DateTime dataAtual = DateTime.Now   // Add seria para adicionar algo
//     .AddHours(3)  // Adiciona 3 horas à data atual (3 horas a mais)
//     .AddMinutes(30);  // Adiciona 30 minutos à data atual (30 minutos a mais)
// Console.WriteLine("Data e Hora Atuais: " + dataAtual);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// // O ToString() é um método que converte um valor para texto (string).
    


//---------------------------------------------------------------------

// Operadores de Atribuição em C#

// int a = 10;
// int b = 20;

// int c = a + b;  // c recebe a soma de a e b

// c = c + 5;  // or c += 5;    |  c recebe c mais 5

// Console.WriteLine("c = " + c);  


// ---

// int a = Convert.ToInt32("10");

// Console.WriteLine(a);

// int b = int.Parse("10");
// Console.WriteLine(b);


// // Usando ToString()
// int numero = 10;
// string texto = Convert.ToString(numero);
// Console.WriteLine(texto); // Saída: "10"


// // Usando Convert.ToString()
// int numero2 = 10;
// string texto2 = numero2.ToString();
// Console.WriteLine(texto2); // Saída: "10"

// // Usando interpolação de string
// int numero3 = 10;
// string texto3 = $"{numero3}";
// Console.WriteLine(texto3); // Saída: "10"

// /* Se eu tentar passar algo que não seja um string,
// gera um erro, Argumento 1: não é possível converter de "int" para "System.ReadOnlySpan<byte>" */
// int b = Convert.ToInt32("AA");
// Console.WriteLine(b);

//--


// int a = Convert.ToInt32(null);
// Console.WriteLine(a);
// /* O Convert fez o seguinte ele imprimu o valor zero e não deu erro na execução do código
// A null representa um valor vazio
// Quando você tentar converter um valor usando a classe Converte usando o nullo ele sempre vai retorna sem erros
// */ 

// int a = int.Parse(null);
// Console.WriteLine(a);
// /* Gerou um erro 'O valor não pode ser nullo'

// */
// string vazio = null ?? string.Empty;
// Console.WriteLine(vazio);

//string a = 5.ToString("F2");  // Formatação de número com 2 casas decimais
//Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

//---

// double a = 5;
// int b = Convert.ToInt32(a);
// Console.WriteLine(b);


//long a =  long.MaxValue;
//int b = Convert.ToInt32(a);
// Erro -  Value was either too large or too small for an Int32.


// int x = int.MaxValue;
// long y = x;
// Console.WriteLine(y);
// // output 2147483647

//---

//double a = 4 / 2 + 2;
//Console.WriteLine(a);


OrdemOperadores.Executar();
