using System;


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



double altura = 1.75;
Console.WriteLine("Altura: " + altura.ToString("F2")); 