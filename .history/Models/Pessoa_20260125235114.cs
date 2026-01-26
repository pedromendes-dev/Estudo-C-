// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// // Temos as palavras reservadas da lingaugem C# que não podem ser usadas para nomear classes, variáveis, métodos, etc.
// // Exemplos de palavras reservadas: int, string, public, class, void, namespace
// // Uso o @ antes do nome para usar uma palavra reservada como nome de classe, variável, etc. Ex: public class @int { }
// // Nome de classes não devem conter espaços ou caracteres especiais (ex: @, #, $,


// // Nome de classes devem ser substantivos e começar com letra maiúscula.
// // Nome de classes devem ser escritos em PascalCase (Primeira letra de cada palavra maiúscula).
// // Nome de classes devem ser únicos dentro do mesmo namespace.


// // Atributos primiero depois métodos

// namespace Curso_CSharp.Models    // Namespace é uma forma de organizar as classes em grupos. Em forma virtual, é como se fosse uma pasta onde guardamos arquivos relacionados.
// {
//     public class Pessoa                             
//     {                                       // comando prop + tab  gera a estrutura básica de uma propriedade (proriedade = atributo de uma classe) 
//                // Seria as características que uma pessoa vai ter            
//         public string? Nome { get; set; }    // o get serve para obter (ler) o valor da propriedade, set serve para setar (atribuir) um novo valor à propriedade.
//         public int Idade { get; set; }

//         public void Apresentar(){                     // método é uma ação que a classe pode realizar
//             Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");  // Estou chamando a claesse console e o método WriteLine 
//         }                                   // Argumento ou Parametro: é o valor que passamos para o método quando o chamamos.

//     }
// }   


// // Ela é um modelo. Ela representar uma planta de uma casa, ela representa uma construção de uma casa na vida real, mas a planta em si não é uma casa, ela define oque uma casa deve ter etc...
// // Lembrando um classe é uma representação de um objeto do mundo real no código.


// // Vamos fazer a nossa classe funcionar instanciando ela como um objeto e ai sim imprimindo uma ação para ela.
