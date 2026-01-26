using Curso_CSharp.Models;   // Importando o namespace Models para usar a classe Pessoa dentro do Program.cs 

// Ponto de partida do programa (arquivo principal) normalmente chamado de Program.cs

// Estou pegando a 'Pessoa' que está dentro do namespace 'Curso_CSharp.Models' e criando um objeto dela chamado 'p'.
Pessoa p = new Pessoa();    // Instanciando a classe Pessoa, criando um objeto p do tipo Pessoa
// p é uma variável de referência que aponta para o objeto da classe
// p aponta para um espaço na memória onde o objeto Pessoa está armazenado. 


// Oque significa instanciar uma classe?
// Instanciar uma classe significa criar um objeto baseado nessa classe.

// . seria a continuação de algo que já foi iniciado. No caso, o ponto está indicando que estamos acessando um membro (propriedade ou método) da classe 

p.Nome = "Pedro";   // Acessando a propriedade Nome do objeto p e atribuindo o valor "Pedro"
p.Idade = 20;      // Acessando a propriedade Idade do objeto p e atribuindo o valor 25

p.Apresentar();    // Chamando o método Apresentar do objeto p