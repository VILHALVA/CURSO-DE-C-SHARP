using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 9, 5, 7, 1, 3, 8, 2, 4, 6 };

        Console.WriteLine("Array não ordenado:");
        ExibirArray(numeros);

        // Ordenando o array em ordem crescente
        Array.Sort(numeros);

        Console.WriteLine("\nArray ordenado em ordem crescente:");
        ExibirArray(numeros);

        // Invertendo a ordem dos elementos no array
        Array.Reverse(numeros);

        Console.WriteLine("\nArray invertido:");
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
}
