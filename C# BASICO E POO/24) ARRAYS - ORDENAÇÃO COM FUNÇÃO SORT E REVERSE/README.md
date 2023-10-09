# ARRAYS - ORDENAÇÃO COM FUNÇÃO SORT E REVERSE
Em C#, você pode usar as funções `Sort` e `Reverse` para ordenar e inverter arrays, respectivamente, de forma mais eficiente do que o Bubble Sort. Aqui está um exemplo que demonstra como usar essas funções:

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 2, 9, 3, 6 };

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
```

Neste exemplo:

- Declaramos um array de inteiros `numeros` com valores desordenados.
- Usamos `Array.Sort(numeros)` para ordenar o array em ordem crescente. Isso é feito de forma eficiente pela função `Sort`.
- Usamos `Array.Reverse(numeros)` para inverter a ordem dos elementos no array.
- Exibimos o array não ordenado, o array ordenado e o array invertido.

Este método é mais eficiente e mais fácil de usar do que a implementação manual do Bubble Sort. Portanto, para tarefas de ordenação e inversão de arrays em C#, é recomendável utilizar as funções integradas `Sort` e `Reverse`.