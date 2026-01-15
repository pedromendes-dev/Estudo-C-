## Iniciando Estudos em C#

O comando 'dotnet new console'
serve para criar um novo projeto de aplicação de console em C# usando o .NET SDK.

Se você quiser dar um nome específico ao projeto, pode usar
'dotnet new console -n MeuProjeto'

- Compilar
  compilador C# direto (csc nome_arquivo.cs)
  E rodar ele ./nome_arquivo.exe pois vai gerar um .exe
  Se quiser rodar sem deixar o .exe na pasta, pode usar csc -out:output.exe Teste.cs
  Para projetos completos com Program.cs, 'dotnet run' é a opção mais recomendadas

---

### Sintaxe e convenções

#### Como é composto um projeto, classes e suas convenções:

Class é apenas um molde para criar objetos, ela é apenas um container (molde) de métodos e propriedades
Métodos dentro da classe só rodam se forem chamados
O método Main é especial ele roda automaticamente quando você faz 'dotnet run'
- Ele precisa ser static porque o runtime (a máquina virtual ou CLR) chama esse método diretamente pela classe, sem criar um objeto antes. -


---

#### Modificadores de acesso:    (public, private, protected, etc.)
- Eles servem para controlar quem pode acessar atributos e métodos de uma classe.

1 public: Visível para todos: qualquer classe pode acessar. Usado quando você quer que o método ou atributo seja aberto.

public class Pessoa {
    public string Nome; // qualquer um pode acessar
}

2 private: Visível apenas dentro da própria classe. Usado para encapsular dados, protegendo-os de acesso externo.

public class Pessoa {
    private int idade; // só a própria classe pode acessar

    public void SetIdade(int valor) {
        idade = valor; // manipulado por método público
    }
}

3 protected: Visível dentro da classe e em subclasses (herança). Usado quando você quer que apenas quem herda a classe tenha acesso.

public class Animal {
    protected void Respirar() {
        Console.WriteLine("Respirando...");
    }
}

public class Cachorro : Animal {
    public void Latir() {
        Respirar(); // pode acessar porque herdou
        Console.WriteLine("Au au!");
    }
}


---

#### Quanto ao escopo, métodos podem ser chamados dependendo do seu modificador de acesso:

public - pode ser chamado de qualquer lugar
private - só pode ser chamado dentro da mesma classe
protected - só dentro da classe e classes derivadas
internal - só dentro do mesmo assembly/projeto
static - chamado pela classe, não precisa de instância
abstract - método sem implementação que obriga classes derivadas a implementarem

(Uma instância é um objeto criado a partir de uma classe, Instanciar: criar um objeto a partir de uma classe)
- um método static não está ligado a nenhum objeto específico, mas sim à própria classe.

Construtor é um método especial que é chamado automaticamente quando você instancia (cria) uma classe. Ele serve para inicializar o objeto.
