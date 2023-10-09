# ARRAYS - ORDENAR COM BUBBLE SORT
O algoritmo de ordenação Bubble Sort é um dos métodos mais simples de ordenação de arrays. Ele funciona comparando pares de elementos adjacentes e trocando-os se estiverem fora de ordem, repetindo esse processo até que o array esteja completamente ordenado. Aqui está um exemplo de como usar o Bubble Sort para ordenar um array em C#:

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 2, 9, 3, 6 };

        Console.WriteLine("Array não ordenado:");
        ExibirArray(numeros);

        BubbleSort(numeros);

        Console.WriteLine("\nArray ordenado:");
        ExibirArray(numeros);
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

    static void ExibirArray(int[] arr)
    {
        foreach (int numero in arr)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
```

Neste exemplo:

- Declaramos um array de inteiros `numeros` com valores desordenados.
- Implementamos o algoritmo Bubble Sort no método `BubbleSort`. O algoritmo usa um loop `do-while` para repetir a comparação e troca de elementos até que nenhum elemento precise ser trocado.
- O método `TrocarElementos` é usado para trocar dois elementos no array quando estão fora de ordem.
- Exibimos o array não ordenado e, em seguida, o array ordenado usando o método `ExibirArray`.

Após a execução do Bubble Sort, o array estará ordenado em ordem crescente. É importante observar que o Bubble Sort não é o algoritmo mais eficiente para grandes conjuntos de dados, mas é útil para fins educacionais e pequenas listas. Para grandes conjuntos de dados, algoritmos de ordenação mais eficientes, como Quick Sort ou Merge Sort, são geralmente preferíveis.