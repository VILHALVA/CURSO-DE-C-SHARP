# CICLO WHILE
A estrutura de repetição `while` em C# permite que você execute um bloco de código enquanto uma condição específica for verdadeira. A estrutura `while` é útil quando você não sabe antecipadamente quantas vezes deseja repetir uma ação, mas deseja continuar enquanto a condição especificada for verdadeira. Aqui está um exemplo de uso da estrutura `while`:

```csharp
using System;

namespace ExemploWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem regressiva a partir de 10:");

            int contador = 10;

            // A estrutura while executa um bloco de código enquanto a condição for verdadeira
            while (contador >= 0)
            {
                Console.WriteLine(contador);
                contador--;
            }

            Console.WriteLine("Fim da contagem regressiva.");
            Console.ReadKey();
        }
    }
}
```

Neste exemplo:

- O programa exibe uma mensagem inicial.
- A variável `contador` é inicializada com o valor 10.
- A estrutura `while` é usada para repetir um bloco de código enquanto a condição `contador >= 0` for verdadeira.
- O programa imprime o valor atual do `contador` em cada iteração.
- O `contador` é decrementado a cada iteração com `contador--`.

Aqui estão algumas considerações sobre o uso da estrutura `while` em C#:

- A estrutura `while` verifica a condição antes de executar o bloco de código. Se a condição for falsa desde o início, o bloco de código dentro do `while` nunca será executado.
- É importante garantir que a condição em um `while` seja eventualmente falsa para evitar um loop infinito.
- Você pode usar a estrutura `while` para implementar loops que continuam até que uma condição específica seja alcançada.

A estrutura `while` é uma maneira eficaz de repetir um bloco de código enquanto uma condição específica for verdadeira, e é usada em situações em que o número de iterações não é conhecido antecipadamente.