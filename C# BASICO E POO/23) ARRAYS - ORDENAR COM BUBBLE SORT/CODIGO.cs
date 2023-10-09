using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int tamanhoArray = 10000;
        int[] numeros = GerarArrayAleatorio(tamanhoArray);

        Console.WriteLine("Array não ordenado (amostra das primeiras 10 posições):");
        ExibirArray(numeros, 10);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        BubbleSort(numeros);

        stopwatch.Stop();
        Console.WriteLine("\nArray ordenado (amostra das primeiras 10 posições):");
        ExibirArray(numeros, 10);

        TimeSpan tempoDecorrido = stopwatch.Elapsed;
        Console.WriteLine($"\nTempo de execução do Bubble Sort: {tempoDecorrido.TotalMilliseconds} ms");
    }

    static int[] GerarArrayAleatorio(int tamanho)
    {
        Random random = new Random();
        int[] arr = new int[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            arr[i] = random.Next(1, 10001); // Números aleatórios de 1 a 10,000
        }
        return arr;
    }

    static void BubbleSort(int[] arr)
    {
        int tamanho = arr.Length;
        bool troca;

        do
        {
            troca = false;

            for (int i = 0; i < tamanho - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    TrocarElementos(arr, i, i + 1);
                    troca = true;
                }
            }
        } while (troca);
    }

    static void TrocarElementos(int[] arr, int indice1, int indice2)
    {
        int temp = arr[indice1];
        arr[indice1] = arr[indice2];
        arr[indice2] = temp;
    }

    static void ExibirArray(int[] arr, int quantidade)
    {
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
