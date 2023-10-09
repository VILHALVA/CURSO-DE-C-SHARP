using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Números Primos");
            Console.Write("Digite um número inteiro positivo para encontrar os primeiros N números primos: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
            }
            else
            {
                Console.WriteLine($"Os primeiros {n} números primos são:");

                int count = 0; // Contador de números primos encontrados
                int numeroAtual = 2; // O primeiro número primo é 2

                while (count < n)
                {
                    if (EhPrimo(numeroAtual))
                    {
                        Console.Write(numeroAtual + " ");
                        count++;
                    }
                    numeroAtual++;
                }
            }

            Console.ReadKey();
        }

        // Função para verificar se um número é primo
        static bool EhPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
