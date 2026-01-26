// Case é padrão de escrita usado para nomear classes, métodos, variáveis, etc.
// Exemplos de case: camelCase, PascalCase, snake_case, spinal-case (kebab-case)


// No c# usamos principalmente camelCase e PascalCase

// Temos a imagem que está na pasta img/case.png que exemplifica os diferentes tipos de case.
namespace Curso_CSharp.Aula
{
    class Case
    {
        static void Main()
        {
            // camelCase: A primeira letra da primeira palavra é minúscula e a primeira letra de cada palavra subsequente é maiúscula. Ex: idadeDoUsuario

            var idadeDoUsuario = 25;
            Console.WriteLine(idadeDoUsuario);

            // PascalCase: A primeira letra de cada palavra é maiúscula. Ex: NomeCompleto

            var NomeCompleto = "Pedro Silva";
            Console.WriteLine(NomeCompleto);

            // snake_case: Todas as letras são minúsculas e as palavras são separadas por underscores (_). Ex: quantidade_de_produtos

            var quantidade_de_produtos = 150;
            Console.WriteLine(quantidade_de_produtos);

            // spinal-case (kebab-case): Todas as letras são minúsculas e as palavras são separadas por hífens (-). Ex: preco-do-produto
            // NOTA: kebab-case NÃO é válido em C#, usamos snake_case ou camelCase como alternativa

            var preco_do_produto = 99.90;
            Console.WriteLine(preco_do_produto);
        }
    }
}


// Nome de classes em PascalCase
// Nome de métodos em PascalCase
