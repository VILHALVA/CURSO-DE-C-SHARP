using System;

namespace CalculadoraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (escolha)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado da Adição: {resultado}");
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado da Subtração: {resultado}");
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado da Divisão: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Por favor, escolha uma operação válida (1 a 4).");
                    break;
            }

            Console.ReadKey();
        }
    }
}
