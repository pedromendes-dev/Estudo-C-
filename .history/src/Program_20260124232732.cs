using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;
using Curso_CSharp.Models;   // Importando o namespace Models para usar a classe Pessoa dentro do Program.cs 

// Ponto de partida do programa (arquivo principal) normalmente chamado de Program.cs

namespace Curso_CSharp.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

Pessoa p = new Pessoa();    // Instanciando a classe Pessoa, criando um objeto p do tipo Pessoa