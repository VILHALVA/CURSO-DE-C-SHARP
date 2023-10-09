# CONDICIONAIS SWITCH CASE
A estrutura de controle `switch` em C# é usada para tomar decisões com base no valor de uma expressão. Ela é frequentemente usada quando você tem várias opções diferentes a serem avaliadas. Aqui está um exemplo de como usar a estrutura `switch` em C#:

```csharp
using System;

namespace ExemploSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma cor: (1-Vermelho, 2-Verde, 3-Azul)");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu a cor Vermelho.");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a cor Verde.");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a cor Azul.");
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Por favor, escolha 1, 2 ou 3.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
```

Neste exemplo:

- O programa solicita ao usuário que escolha uma cor, fornecendo opções numéricas.
- A escolha do usuário é lida e convertida em um valor inteiro.
- Em seguida, a estrutura `switch` é usada para avaliar o valor da variável `escolha` e tomar uma decisão com base nesse valor.
- Cada `case` representa uma opção possível. Se o valor de `escolha` corresponder a um dos `case`, o bloco de código correspondente será executado.
- O `default` é opcional e é executado quando nenhum dos `case` corresponde ao valor de `escolha`.
- O `break` é usado para sair da estrutura `switch` após a execução do bloco correspondente.

Aqui estão algumas considerações sobre o uso da estrutura `switch` em C#:

- A estrutura `switch` é útil quando você precisa fazer várias comparações com base em um valor específico.
- Você pode usar tipos de dados como `int`, `char`, `string`, `enum` e outros como expressão no `switch`.
- Cada `case` deve ser exclusivo, e você pode ter vários `case` com o mesmo bloco de código se desejar.
- O `default` é opcional, mas é útil para lidar com valores que não correspondem a nenhum dos `case` definidos.

A estrutura `switch` é uma maneira eficaz de simplificar o código quando você precisa tomar decisões com base em um valor específico, especialmente quando há várias opções a serem consideradas.