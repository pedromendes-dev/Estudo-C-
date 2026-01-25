// using System.Reflection;
// using System.Reflection.Metadata;
// using System.Runtime.InteropServices;
// using System;

// // Class é apenas um molde para criar objetos, ela é apenas um container (molde) de métodos e propriedades
// // Main é o ponto de entrada do programa
// class Program2
// {     // static significa que o método pertence à classe e não a uma instância específica
//     static void Main(string[] args)     // um array de strings que recebe argumentos (args)
//     {    // void significa que o método não retorna nenhum valor (vazio)

//         System.Console.WriteLine("Hello, World!");


//           Main(["arg1" , "arg2"]);  // chamada do método Main com argumentos


//         var nome = new Main();  //  instancia e armazena em uma variável
//     }


// }








// public class Teste
// {
//     static void PrintarNaTela(string nome, int idade, bool ativo)
//     {
//         System.Console.WriteLine($"Nome: {nome}, Idade: {idade}, Ativo: {ativo}");


//         PrintarNaTela(nome: "Maria", idade: 30, ativo: true);   // chamada do método com argumentos nomeados
//     }
// }









// // Método construtor
// // Exemplo de classe com construtor
// class Pessoa
// {
//     public string Nome;
//     public int Idade;

//     // Construtor (sem parâmetros)
//     public Pessoa()
//     {
//         Nome = "Sem nome";
//         Idade = 0;
//     }

//     // Construtor (com parâmetros)
//     public Pessoa(string nome, int idade)
//     {
//         Nome = nome;
//         Idade = idade;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Chamando o construtor sem parâmetros
//         Pessoa p1 = new Pessoa();
//         System.Console.WriteLine(p1.Nome);  // Sem nome

//         // Chamando o construtor com parâmetros
//         Pessoa p2 = new Pessoa("João", 25);
//         System.Console.WriteLine(p2.Nome);  // João
//     }
// }


// // ------------
