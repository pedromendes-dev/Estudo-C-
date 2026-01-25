using System;



public class Aula1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


            Pessoa_ pessoa = new Pessoa_ { Nome = "Pedro", Idade = 25 };

            pessoa.Apresentar();

            // Instanciar uma classe significa criar uma "nova inicialização" ou um novo objeto baseado naquela classe.
            // feito usando o operador new por exemplo
    }

}




 public class Pessoa_
{
    public required string Nome { get; set; }  // O get serve para obter (ler) o valor da propriedade, set serve para setar (atribuir) um novo valor à propriedade.
    public int Idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");

    }
}


