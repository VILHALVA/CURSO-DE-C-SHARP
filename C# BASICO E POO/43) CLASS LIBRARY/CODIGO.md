# CODIGO
Vou fornecer um exemplo mais abrangente de como criar, usar e compartilhar uma Class Library em C#. Neste exemplo, vamos criar uma Biblioteca de Classes chamada "Calculadora" que contém métodos para realizar operações matemáticas simples.

Passo 1: Criar a Biblioteca de Classes "Calculadora"

1. Abra o Visual Studio.
2. Crie um novo projeto selecionando "Arquivo" > "Novo" > "Projeto...".
3. Escolha o modelo "Biblioteca de Classes (.NET Framework)" ou "Biblioteca de Classes (.NET Core/.NET 5+)" com base na sua versão do .NET.
4. Dê um nome ao projeto, como "CalculadoraLibrary".
5. Crie uma classe chamada "Calculadora" dentro do projeto e adicione métodos para realizar operações matemáticas, como soma, subtração, multiplicação e divisão.

```csharp
namespace CalculadoraLibrary
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("A divisão por zero não é permitida.");
            }
            return (double)a / b;
        }
    }
}
```

Passo 2: Compilar a Biblioteca de Classes

Certifique-se de que o projeto "CalculadoraLibrary" seja compilado com sucesso.

Passo 3: Criar um Projeto de Console para Usar a Biblioteca de Classes

1. Crie um novo projeto de Console selecionando "Arquivo" > "Novo" > "Projeto...".
2. Dê um nome ao projeto, como "CalculadoraApp".
3. Na janela "Gerenciador de Soluções", clique com o botão direito no projeto "CalculadoraApp" e escolha "Adicionar Referência...".
4. Selecione o projeto "CalculadoraLibrary" na guia "Projetos" ou adicione a referência ao arquivo .dll gerado pelo projeto "CalculadoraLibrary".

Passo 4: Usar a Biblioteca de Classes na Aplicação de Console

Agora, você pode usar os métodos da Biblioteca de Classes em seu projeto de Console:

```csharp
using System;
using CalculadoraLibrary; // Importe o namespace da Biblioteca de Classes

class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();

        int resultadoSoma = calculadora.Somar(5, 3);
        Console.WriteLine("5 + 3 = " + resultadoSoma);

        int resultadoSubtracao = calculadora.Subtrair(10, 4);
        Console.WriteLine("10 - 4 = " + resultadoSubtracao);

        int resultadoMultiplicacao = calculadora.Multiplicar(6, 7);
        Console.WriteLine("6 * 7 = " + resultadoMultiplicacao);

        try
        {
            double resultadoDivisao = calculadora.Dividir(8, 2);
            Console.WriteLine("8 / 2 = " + resultadoDivisao);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
```

Este exemplo demonstra como criar uma Biblioteca de Classes chamada "CalculadoraLibrary", compilar e usá-la em um projeto de Console chamado "CalculadoraApp". A Biblioteca de Classes encapsula a lógica da calculadora e pode ser compartilhada entre diferentes aplicativos. Isso promove a reutilização de código e a organização eficiente de funcionalidades comuns.