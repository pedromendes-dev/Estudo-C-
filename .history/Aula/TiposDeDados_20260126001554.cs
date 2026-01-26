// TIPOS DE DADOS EM C#
// Os tipos de dados definem o tipo de valor que uma variável pode armazenar.
// Em C#, existem dois principais grupos: Tipos de Valor (Value Types) e Tipos de Referência (Reference Types)


// Qunado você coloca o tipo vc está declarando ela. Quando vc não coloca o tipo vc está alterando o valor da variável já declarada anteriormente.



// ╔══════════════════════════════════════════════════════════════════════════════╗
// ║                         TIPOS DE VALOR (VALUE TYPES)                        ║
// ╚══════════════════════════════════════════════════════════════════════════════╝

// Tipos Inteiros (armazenam números inteiros, sem casas decimais):
// - byte: 0 a 255 (8 bits)
// - sbyte: -128 a 127 (8 bits com sinal)
// - short: -32,768 a 32,767 (16 bits)
// - ushort: 0 a 65,535 (16 bits)
// - int: -2,147,483,648 a 2,147,483,647 (32 bits) ← MAIS USADO
// - uint: 0 a 4,294,967,295 (32 bits)
// - long: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807 (64 bits)
// - ulong: 0 a 18,446,744,073,709,551,615 (64 bits)

// Tipos Ponto Flutuante (armazenam números com casas decimais):
// - float: números decimais com precisão simples (32 bits) ← MENOS PRECISO
// - double: números decimais com precisão dupla (64 bits) ← MAIS PRECISO E PADRÃO
// - decimal: números decimais com alta precisão para cálculos financeiros (128 bits)

// Tipo Booleano:
// - bool: true ou false (1 bit lógico)

// Tipo Caractere:
// - char: um único caractere Unicode (16 bits) ← Use aspas simples: 'A'

// ╔══════════════════════════════════════════════════════════════════════════════╗
// ║                         TIPOS DE REFERÊNCIA (REFERENCE TYPES)               ║
// ╚══════════════════════════════════════════════════════════════════════════════╝

// - string: cadeia de caracteres (texto) ← Use aspas duplas: "Olá"
// - object: tipo base para todos os tipos em C#
// - class: tipos de classe customizados
// - interface: tipos de interface customizados
// - delegate: tipos de delegado

namespace Curso_CSharp.Aula
{
    class TiposDeDados
    {
        // Método para demonstrar os diferentes tipos de dados
        static void ExemploTiposDados()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           EXEMPLOS DE TIPOS DE DADOS EM C#                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // TIPOS INTEIROS
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("► TIPOS INTEIROS (números sem casas decimais):");
            Console.WriteLine("─────────────────────────────────────────────────");

            byte meuByte = 255;
            Console.WriteLine($"byte: {meuByte} (máximo: 255)");

            sbyte meuSbyte = -128;
            Console.WriteLine($"sbyte: {meuSbyte} (mínimo: -128)");

            short meuShort = 32767;
            Console.WriteLine($"short: {meuShort} (máximo: 32,767)");

            ushort meuUshort = 65535;
            Console.WriteLine($"ushort: {meuUshort} (máximo: 65,535)");

            int meuInt = 2147483647;
            Console.WriteLine($"int: {meuInt} (máximo: 2,147,483,647) ← MAIS USADO");

            uint meuUint = 4294967295;
            Console.WriteLine($"uint: {meuUint} (máximo: 4,294,967,295)");

            long meuLong = 9223372036854775807;
            Console.WriteLine($"long: {meuLong} (máximo: 9,223,372,036,854,775,807)");

            ulong meuUlong = 18446744073709551615;
            Console.WriteLine($"ulong: {meuUlong} (máximo: 18,446,744,073,709,551,615)\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // TIPOS PONTO FLUTUANTE
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("► TIPOS PONTO FLUTUANTE (números com casas decimais):");
            Console.WriteLine("─────────────────────────────────────────────────────");

            float meuFloat = 3.14159f; // Use 'f' ou 'F' como sufixo para float
            Console.WriteLine($"float: {meuFloat} (precisão simples - 32 bits) ← MENOS PRECISO");

            double meuDouble = 3.141592653589793;
            Console.WriteLine($"double: {meuDouble} (precisão dupla - 64 bits) ← MAIS USADO");

            decimal meuDecimal = 99.99m; // Use 'm' ou 'M' como sufixo para decimal
            Console.WriteLine($"decimal: {meuDecimal} (alta precisão - ideal para dinheiro)\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // TIPO BOOLEANO
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("► TIPO BOOLEANO (verdadeiro ou falso):");
            Console.WriteLine("────────────────────────────────────");

            bool ehVerdadeiro = true;
            bool ehFalso = false;

            Console.WriteLine($"bool (true): {ehVerdadeiro}");
            Console.WriteLine($"bool (false): {ehFalso}\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // TIPO CARACTERE
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("► TIPO CARACTERE (um único caractere):");
            Console.WriteLine("───────────────────────────────────────");

            char meuChar = 'A'; // Use aspas simples para char
            Console.WriteLine($"char: {meuChar} (um caractere Unicode)");

            char numero = '5';
            Console.WriteLine($"char: {numero} (caractere '5', não é número)");

            char especial = '@';
            Console.WriteLine($"char: {especial} (caractere especial)\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // TIPOS DE REFERÊNCIA
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("► TIPOS DE REFERÊNCIA (armazenam referência em memória):");
            Console.WriteLine("──────────────────────────────────────────────────────");

            string meuTexto = "Olá, Mundo!"; // Use aspas duplas para string
            Console.WriteLine($"string: {meuTexto} (sequência de caracteres)");

            string nome = "Pedro Silva";
            Console.WriteLine($"string: {nome} (texto com múltiplas palavras)");

            object meuObjeto = "Qualquer coisa"; // object pode armazenar qualquer tipo
            Console.WriteLine($"object: {meuObjeto} (tipo base universal)\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // INFERÊNCIA DE TIPO COM 'var'
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("► INFERÊNCIA DE TIPO COM 'var':");
            Console.WriteLine("────────────────────────────────");

            var idade = 25; // C# infere que é 'int'
            Console.WriteLine($"var idade = 25; → tipo: {idade.GetType().Name}");

            var preco = 19.99; // C# infere que é 'double'
            Console.WriteLine($"var preco = 19.99; → tipo: {preco.GetType().Name}");

            var ativo = true; // C# infere que é 'bool'
            Console.WriteLine($"var ativo = true; → tipo: {ativo.GetType().Name}");

            var mensagem = "Olá"; // C# infere que é 'string'
            Console.WriteLine($"var mensagem = \"Olá\"; → tipo: {mensagem.GetType().Name}\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // TABELA COMPARATIVA
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    TABELA COMPARATIVA                        ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ Tipo      │ Tamanho │ Mínimo               │ Máximo          ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ byte      │ 8 bits  │ 0                    │ 255             ║");
            Console.WriteLine("║ sbyte     │ 8 bits  │ -128                 │ 127             ║");
            Console.WriteLine("║ short     │ 16 bits │ -32,768              │ 32,767          ║");
            Console.WriteLine("║ ushort    │ 16 bits │ 0                    │ 65,535          ║");
            Console.WriteLine("║ int       │ 32 bits │ -2,147,483,648       │ 2,147,483,647   ║");
            Console.WriteLine("║ uint      │ 32 bits │ 0                    │ 4,294,967,295   ║");
            Console.WriteLine("║ long      │ 64 bits │ -9,223,372,036...    │ 9,223,372,036...║");
            Console.WriteLine("║ ulong     │ 64 bits │ 0                    │ 18,446,744,073..║");
            Console.WriteLine("║ float     │ 32 bits │ ±1.5×10⁻⁴⁵           │ ±3.4×10³⁸       ║");
            Console.WriteLine("║ double    │ 64 bits │ ±5.0×10⁻³²⁴          │ ±1.7×10³⁰⁸      ║");
            Console.WriteLine("║ decimal   │ 128 bits│ ±1.0×10⁻²⁸           │ ±7.9×10²⁸       ║");
            Console.WriteLine("║ bool      │ 1 bit   │ false                │ true            ║");
            Console.WriteLine("║ char      │ 16 bits │ \\u0000              │ \\uffff         ║");
            Console.WriteLine("║ string    │ Variável│ null                 │ sem limite      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // DICAS E BOAS PRÁTICAS
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   DICAS E BOAS PRÁTICAS                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n📌 Use 'int' para números inteiros (mais comum)");
            Console.WriteLine("📌 Use 'double' para números decimais (mais comum)");
            Console.WriteLine("📌 Use 'decimal' para operações financeiras/moeda");
            Console.WriteLine("📌 Use 'string' para texto");
            Console.WriteLine("📌 Use 'bool' para condições verdadeiro/falso");
            Console.WriteLine("📌 Use 'var' quando o tipo for óbvio pelo contexto");
            Console.WriteLine("📌 Prefira 'string' sobre 'char' para mais de um caractere");
            Console.WriteLine("📌 Cuidado com overflow: valores que excedem o máximo\n");

            // ═══════════════════════════════════════════════════════════════════════════════
            // CONVERSÃO ENTRE TIPOS (CASTING)
            // ═══════════════════════════════════════════════════════════════════════════════

            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    CONVERSÃO ENTRE TIPOS                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝\n");

            int numeroInteiro = 100;
            double numeroDouble = numeroInteiro; // Conversão implícita (segura)
            Console.WriteLine($"Conversão implícita: int → double");
            Console.WriteLine($"int {numeroInteiro} → double {numeroDouble}\n");

            double decimal100 = 100.50;
            int inteiro = (int)decimal100; // Conversão explícita (casting)
            Console.WriteLine($"Conversão explícita: double → int");
            Console.WriteLine($"double {decimal100} → int {inteiro} (casas decimais perdidas)\n");

            string numero_texto = "42";
            int numero_convertido = int.Parse(numero_texto); // Converte string para int
            Console.WriteLine($"Conversão de string para int:");
            Console.WriteLine($"string \"{numero_texto}\" → int {numero_convertido}\n");
        }
    }
}
