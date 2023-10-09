# EXERCICIOS
Aqui estão cinco exercícios relacionados a arrays em C# juntamente com as questões, códigos e explicações correspondentes:

**Exercício 1: Soma dos Elementos**

**Questão:** Escreva um programa que calcule a soma de todos os elementos em um array de inteiros.

**Código:**

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int soma = CalcularSoma(numeros);
        Console.WriteLine("A soma dos elementos é: " + soma);
    }

    static int CalcularSoma(int[] arr)
    {
        int soma = 0;
        foreach (int numero in arr)
        {
            soma += numero;
        }
        return soma;
    }
}
```

**Explicação:** Este programa declara um array de inteiros, calcula a soma dos elementos usando um método separado `CalcularSoma` e exibe o resultado.

**Exercício 2: Encontrar Elemento Mínimo**

**Questão:** Escreva um programa que encontre o elemento mínimo em um array de números inteiros.

**Código:**

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 15, 8, 22, 34, 5, 12, 10, 6, 45, 30 };
        int minimo = EncontrarMinimo(numeros);
        Console.WriteLine("O elemento mínimo é: " + minimo);
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
}
```

**Explicação:** Neste programa, declaramos um array de inteiros e, em seguida, usamos um método `EncontrarMinimo` para encontrar o elemento mínimo no array.

**Exercício 3: Pesquisa de Elemento**

**Questão:** Escreva um programa que verifique se um determinado número está presente em um array de inteiros.

**Código:**

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int numeroPesquisado = 30;
        bool encontrado = PesquisarNumero(numeros, numeroPesquisado);

        if (encontrado)
        {
            Console.WriteLine(numeroPesquisado + " encontrado no array.");
        }
        else
        {
            Console.WriteLine(numeroPesquisado + " não encontrado no array.");
        }
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
```

**Explicação:** O programa declara um array de inteiros e verifica se um número específico está presente no array usando a função `PesquisarNumero`.

**Exercício 4: Inverter um Array**

**Questão:** Escreva um programa que inverta a ordem dos elementos em um array de inteiros.

**Código:**

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        InverterArray(numeros);
        Console.WriteLine("Array invertido:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
    }

    static void InverterArray(int[] arr)
    {
        int tamanho = arr.Length;
        for (int i = 0; i < tamanho / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[tamanho - 1 - i];
            arr[tamanho - 1 - i] = temp;
        }
    }
}
```

**Explicação:** O programa inverte a ordem dos elementos em um array de inteiros usando o método `InverterArray`.

**Exercício 5: Contar Elementos Ímpares**

**Questão:** Escreva um programa que conte e exiba o número de elementos ímpares em um array de inteiros.

**Código:**

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int contadorImpares = ContarImpares(numeros);
        Console.WriteLine("Número de elementos ímpares: " + contadorImpares);
    }

    static int ContarImpares(int[] arr)
    {
        int contador = 0;
        foreach (int numero in arr)
        {
            if (numero % 2 != 0)
            {
                contador++;
            }
        }
        return contador;
    }
}
```

**Explicação:** O programa conta o número de elementos ímpares em um array de inteiros usando o método `ContarImpares`.

Esses exercícios ajudam a praticar o uso de arrays em C# e a entender como realizar várias operações com eles.