using System;
using System.Data;


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