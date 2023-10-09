# CRIAÇÃO DE METODOS
A criação de métodos em C# é uma parte fundamental da programação, pois permite organizar o código em blocos reutilizáveis. Métodos são funções que realizam ações específicas quando chamadas. Aqui estão exemplos de como criar métodos em C# e como chamá-los:

**Exemplo 1: Método Simples**

```csharp
using System;

namespace ExemploMetodo
{
    class Program
    {
        // Definindo um método simples
        static void Saudacao()
        {
            Console.WriteLine("Olá, mundo!");
        }

        static void Main(string[] args)
        {
            // Chamando o método Saudacao
            Saudacao();
        }
    }
}
```

Neste exemplo, criamos um método chamado `Saudacao` que exibe "Olá, mundo!" quando chamado. No método `Main`, chamamos o método `Saudacao` para exibir a saudação.

**Exemplo 2: Método com Parâmetros e Retorno**

```csharp
using System;

namespace ExemploMetodo
{
    class Program
    {
        // Definindo um método que recebe parâmetros e retorna um valor
        static int Soma(int a, int b)
        {
            int resultado = a + b;
            return resultado;
        }

        static void Main(string[] args)
        {
            int numero1 = 5;
            int numero2 = 3;

            // Chamando o método Soma e armazenando o resultado em uma variável
            int resultadoSoma = Soma(numero1, numero2);

            Console.WriteLine($"A soma de {numero1} e {numero2} é igual a {resultadoSoma}");
        }
    }
}
```

Neste exemplo, criamos um método chamado `Soma` que recebe dois parâmetros (inteiros `a` e `b`) e retorna a soma desses números. No método `Main`, chamamos o método `Soma`, passando dois números e armazenando o resultado em uma variável.

**Exemplo 3: Método com Modificador `ref`**

```csharp
using System;

namespace ExemploMetodo
{
    class Program
    {
        // Definindo um método que utiliza o modificador ref para alterar o valor de uma variável
        static void Incrementar(ref int numero)
        {
            numero++;
        }

        static void Main(string[] args)
        {
            int valor = 5;

            // Chamando o método Incrementar com o modificador ref
            Incrementar(ref valor);

            Console.WriteLine($"O valor incrementado é {valor}");
        }
    }
}
```

Neste exemplo, criamos um método chamado `Incrementar` que usa o modificador `ref` para permitir que ele altere o valor da variável `numero` que é passada como argumento. No método `Main`, chamamos o método `Incrementar` com o modificador `ref` e, assim, conseguimos alterar o valor da variável `valor`.

Esses são exemplos básicos de como criar métodos em C#. Você pode criar métodos mais complexos com várias instruções e lógica de programação, dependendo das necessidades do seu programa. Métodos ajudam a tornar seu código mais organizado, modular e reutilizável.