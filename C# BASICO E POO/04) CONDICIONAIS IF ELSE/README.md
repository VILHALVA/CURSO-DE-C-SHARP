# CONDICIONAIS IF ELSE
As estruturas de controle condicional `if` e `else` em C# permitem que você execute blocos de código com base em condições. Aqui está um exemplo de uso dessas estruturas:

```csharp
using System;

namespace ExemploIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }

            Console.ReadKey();
        }
    }
}
```

Neste exemplo:

- O programa solicita que o usuário digite sua idade.
- A entrada é lida e convertida em um valor inteiro usando `Convert.ToInt32`.
- Uma estrutura `if` é usada para verificar se a idade é maior ou igual a 18. Se a condição for verdadeira (idade maior ou igual a 18), o bloco de código dentro do `if` é executado, exibindo "Você é maior de idade". Caso contrário, o bloco de código dentro do `else` é executado, exibindo "Você é menor de idade".

Aqui estão algumas considerações sobre as estruturas de controle condicional `if` e `else` em C#:

- Você pode aninhar múltiplos blocos `if-else` para lidar com várias condições.
- Use operadores de comparação, como `<`, `>`, `<=`, `>=`, `==`, e `!=`, para comparar valores em suas condições.
- Você pode usar operadores lógicos, como `&&` (E lógico) e `||` (OU lógico), para combinar condições.
- A cláusula `else` é opcional e pode ser omitida se não houver código a ser executado quando a condição do `if` for falsa.
- Você também pode usar `else if` para verificar condições adicionais quando a condição do `if` for falsa.

As estruturas `if` e `else` são fundamentais para a lógica condicional em C# e são amplamente utilizadas para controlar o fluxo de execução do programa com base em condições específicas.