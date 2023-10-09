using System;

namespace ExemploArrayAvancado
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 15, 8, 22, 34, 5, 12, 10, 6, 45, 30 };

            Console.WriteLine("Array de Números:");
            ExibirArray(numeros);

            double media = CalcularMedia(numeros);
            Console.WriteLine($"\nMédia dos Números: {media:F2}");

            int maximo = EncontrarMaximo(numeros);
            Console.WriteLine($"Valor Máximo: {maximo}");

            int minimo = EncontrarMinimo(numeros);
            Console.WriteLine($"Valor Mínimo: {minimo}");

            Console.Write("\nDigite um número para pesquisar no array: ");
            int numeroPesquisado = Convert.ToInt32(Console.ReadLine());
            bool encontrado = PesquisarNumero(numeros, numeroPesquisado);

            if (encontrado)
            {
                Console.WriteLine($"{numeroPesquisado} encontrado no array.");
            }
            else
            {
                Console.WriteLine($"{numeroPesquisado} não encontrado no array.");
            }

            Array.Sort(numeros);
            Console.WriteLine("\nArray Ordenado em Ordem Crescente:");
            ExibirArray(numeros);

            Array.Reverse(numeros);
            Console.WriteLine("\nArray com Elementos Invertidos:");
            ExibirArray(numeros);
        }

        static void ExibirArray(int[] arr)
        {
            foreach (int numero in arr)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        static double CalcularMedia(int[] arr)
        {
            int soma = 0;
            foreach (int numero in arr)
            {
                soma += numero;
            }
            return (double)soma / arr.Length;
        }

        static int EncontrarMaximo(int[] arr)
        {
            int maximo = arr[0];
            foreach (int numero in arr)
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }
            }
            return maximo;
        }

        static int EncontrarMinimo(int[] arr)
        {
            int minimo = arr[0];
            foreach (int numero in arr)
            {
                if (numero < minimo)
                {
                    minimo = numero;
                }
            }
            return minimo;
        }

        static bool PesquisarNumero(int[] arr, int alvo)
        {
            foreach (int numero in arr)
            {
                if (numero == alvo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
