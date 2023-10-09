# EXERCICIOS - REVISÃO DO CONTEÚDO.
Aqui estão alguns exercícios que envolvem variáveis, estruturas condicionais (if-else) e estruturas de repetição (for e while), juntamente com as soluções e explicações:

**Exercício 1: Calculadora Simples**
Crie um programa que permita ao usuário realizar operações de adição, subtração, multiplicação e divisão entre dois números. O programa deve perguntar ao usuário qual operação ele deseja realizar e, em seguida, solicitar os dois números. Execute a operação selecionada e exiba o resultado.

**Solução:**
```csharp
using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simples");
            Console.Write("Escolha uma operação (+, -, *, /): ");
            char operacao = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    return;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
```

**Explicação:**
- O programa solicita ao usuário que escolha uma operação e lê o caractere correspondente.
- Em seguida, solicita os dois números para realizar a operação selecionada.
- O `switch` é usado para executar a operação apropriada com base na escolha do usuário.
- O resultado da operação é exibido.

**Exercício 2: Contagem Regressiva**
Crie um programa que peça ao usuário para inserir um número e, em seguida, conte de 1 até esse número, exibindo cada número no console.

**Solução:**
```csharp
using System;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem Regressiva");
            Console.Write("Digite um número inteiro positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
```

**Explicação:**
- O programa solicita ao usuário que insira um número inteiro positivo.
- O número é verificado para garantir que seja positivo.
- Em seguida, um loop `for` é usado para contar de 1 até o número fornecido e exibir cada número no console.

**Exercício 3: Adivinhe o Número**
Crie um jogo em que o programa gere um número secreto entre 1 e 100. O usuário deve adivinhar o número secreto, e o programa dará dicas sobre se a tentativa foi muito alta ou muito baixa. O jogo continua até que o usuário adivinhe corretamente.

**Solução:**
```csharp
using System;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo de Adivinhação");
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int tentativa;
            int tentativas = 0;
            bool acertou = false;

            while (!acertou)
            {
                Console.Write("Tente adivinhar o número secreto (entre 1 e 100): ");
                tentativa = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Tente um número maior.");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("Tente um número menor.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
                    acertou = true;
                }
            }
        }
    }
}
```

**Explicação:**
- O programa gera um número secreto aleatório entre 1 e 100.
- O loop `while` continua até que o usuário adivinhe corretamente (`acertou` seja verdadeiro).
- O programa fornece dicas ao usuário sobre se a tentativa foi muito alta ou muito baixa.
- O número de tentativas é contado (`tentativas`).

Estes são exemplos de exercícios que envolvem variáveis, estruturas condicionais e estruturas de repetição em C#. Eles demonstram como criar programas interativos e controlar o fluxo de execução com base em condições e iterações.