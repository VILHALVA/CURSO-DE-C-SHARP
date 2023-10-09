# CICLO FOR
A estrutura de repetição `for` em C# permite que você execute um bloco de código várias vezes com base em uma condição e um contador. A estrutura `for` é frequentemente usada quando você sabe antecipadamente quantas vezes deseja repetir uma ação. Aqui está um exemplo de uso da estrutura `for`:

```csharp
using System;

namespace ExemploFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem de 1 a 10:");

            // A estrutura for executa um bloco de código 10 vezes, incrementando o contador a cada iteração
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
```

Neste exemplo:

- O programa exibe uma mensagem inicial.
- A estrutura `for` é usada para contar de 1 a 10.
- A variável `i` é inicializada com 1.
- A condição `i <= 10` determina quando o loop deve continuar executando.
- O contador `i` é incrementado em cada iteração com `i++`.
- O programa imprime o valor atual de `i` em cada iteração, resultando em uma contagem de 1 a 10.

Você pode personalizar a estrutura `for` para atender às suas necessidades específicas. Por exemplo, você pode controlar o valor inicial, a condição de término e o incremento do contador. Aqui está uma visão geral da sintaxe da estrutura `for`:

```csharp
for (inicialização; condição; incremento)
{
    // Código a ser repetido
}
```

- `inicialização`: É onde você inicializa o contador ou variável de controle.
- `condição`: É a condição que determina quando o loop deve continuar executando. Enquanto essa condição for verdadeira, o loop continuará.
- `incremento`: É a operação que atualiza o contador em cada iteração.

Você também pode usar a estrutura `for` para iterar em matrizes, coleções e outros tipos de dados iteráveis, tornando-a uma das estruturas de repetição mais versáteis em C#.