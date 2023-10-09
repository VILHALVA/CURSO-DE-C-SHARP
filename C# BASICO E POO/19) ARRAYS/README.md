# ARRAYS
Em C#, os arrays são estruturas de dados que permitem armazenar múltiplos valores do mesmo tipo em uma única variável. Os elementos em um array são acessados por meio de índices, que começam em zero. Vou mostrar como declarar, inicializar e usar arrays em C# com exemplos:

**Declarando um Array:**

Você pode declarar um array especificando o tipo dos elementos seguido de colchetes `[]` e o nome do array. Por exemplo, para declarar um array de inteiros:

```csharp
int[] numeros;
```

**Inicializando um Array:**

Existem várias maneiras de inicializar um array em C#:

1. Inicialização direta:

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
```

2. Usando o operador `new` com tamanho:

```csharp
int[] numeros = new int[5]; // Cria um array com 5 elementos, todos inicializados com zero.
```

**Acessando Elementos de um Array:**

Os elementos de um array são acessados usando índices. Os índices começam em zero e vão até o tamanho do array menos um. Por exemplo, para acessar o terceiro elemento de `numeros`:

```csharp
int terceiroElemento = numeros[2]; // Lembre-se de que os índices começam em zero.
```

**Exemplo de Uso de Array:**

Aqui está um exemplo de um programa que declara, inicializa e usa um array:

```csharp
using System;

namespace ExemploArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Elementos do Array:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Elemento {i}: {numeros[i]}");
            }
        }
    }
}
```

Este programa declara um array `numeros`, inicializa-o com valores e, em seguida, usa um loop `for` para percorrer todos os elementos do array e exibi-los no console.

Os arrays em C# são úteis quando você precisa armazenar uma coleção de valores do mesmo tipo, como uma lista de números, nomes ou objetos. Eles são amplamente usados na programação para gerenciar e manipular conjuntos de dados.