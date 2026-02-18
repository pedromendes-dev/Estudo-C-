using System;

// Exemplos sobre variaveis comuns, const e readonly.
// Mantidos em uma classe para evitar erros de compilacao.
class TiposDeVariaveisDemo
{
    // const: valor fixo em tempo de compilacao
    private const int MaxTentativas = 3;
    private const string AppNome = "Minha Aplicacao";

    // readonly: valor definido no construtor (tempo de execucao)
    private readonly DateTime CriadoEm;

    // static readonly: valor calculado uma vez no construtor estatico
    private static readonly Guid IdSistema;

    static TiposDeVariaveisDemo()
    {
        IdSistema = Guid.NewGuid();
    }

    public TiposDeVariaveisDemo()
    {
        CriadoEm = DateTime.Now;
    }

    public void Executar()
    {
        // Variavel comum: pode mudar a qualquer momento
        int contador = 0;
        contador++;
        contador = 10;

        Console.WriteLine($"MaxTentativas: {MaxTentativas}");
        Console.WriteLine($"AppNome: {AppNome}");
        Console.WriteLine($"CriadoEm: {CriadoEm}");
        Console.WriteLine($"IdSistema: {IdSistema}");

        // Isto NAO e permitido:
        // MaxTentativas = 5;
        // AppNome = "Nova Aplicacao";
        // CriadoEm = DateTime.Now;
        // IdSistema = Guid.NewGuid();
    }
}

