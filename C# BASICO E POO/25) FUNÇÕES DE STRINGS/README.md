# FUNÇÕES DE STRINGS
Em C#, existem muitas funções úteis para manipulação de strings. Aqui estão algumas das funções mais comuns que você pode usar para trabalhar com strings:

1. **Length:** Retorna o número de caracteres em uma string.

   ```csharp
   string texto = "Olá, mundo!";
   int tamanho = texto.Length; // Retorna 12
   ```

2. **Substring:** Retorna uma parte da string com base em um índice inicial e um comprimento ou com base apenas no índice inicial.

   ```csharp
   string texto = "Exemplo de substring";
   string parte = texto.Substring(8, 2); // Retorna "de"
   string restante = texto.Substring(8); // Retorna "de substring"
   ```

3. **ToUpper e ToLower:** Converte uma string para letras maiúsculas ou minúsculas.

   ```csharp
   string texto = "Hello World";
   string maiusculas = texto.ToUpper(); // Retorna "HELLO WORLD"
   string minusculas = texto.ToLower(); // Retorna "hello world"
   ```

4. **Concatenação de Strings:** Você pode concatenar strings usando o operador `+` ou o método `Concat`.

   ```csharp
   string primeiroNome = "John";
   string sobrenome = "Doe";
   string nomeCompleto = primeiroNome + " " + sobrenome; // Retorna "John Doe"
   ```

5. **Replace:** Substitui todas as ocorrências de uma substring por outra.

   ```csharp
   string texto = "Hoje é um dia ensolarado.";
   string novoTexto = texto.Replace("ensolarado", "chuvoso"); // Retorna "Hoje é um dia chuvoso."
   ```

6. **Split:** Divide uma string em um array de substrings com base em um caractere delimitador.

   ```csharp
   string texto = "Maçã, Banana, Pera, Uva";
   string[] frutas = texto.Split(','); // Retorna um array: ["Maçã", " Banana", " Pera", " Uva"]
   ```

7. **Trim:** Remove espaços em branco do início e do fim de uma string.

   ```csharp
   string texto = "    Espaços    ";
   string semEspacos = texto.Trim(); // Retorna "Espaços"
   ```

8. **IndexOf e LastIndexOf:** Encontra a posição da primeira ou última ocorrência de uma substring em uma string.

   ```csharp
   string texto = "Olá, mundo!";
   int posicao = texto.IndexOf("mundo"); // Retorna 5
   int ultimaPosicao = texto.LastIndexOf("o"); // Retorna 8
   ```

9. **StartsWith e EndsWith:** Verifica se uma string começa ou termina com uma determinada substring.

   ```csharp
   string texto = "Olá, mundo!";
   bool comecaComOla = texto.StartsWith("Olá"); // Retorna true
   bool terminaComMundo = texto.EndsWith("mundo"); // Retorna true
   ```

10. **Format:** Formata uma string substituindo marcadores de posição por valores.

    ```csharp
    string nome = "Alice";
    int idade = 30;
    string mensagem = string.Format("Meu nome é {0} e tenho {1} anos.", nome, idade);
    // Retorna "Meu nome é Alice e tenho 30 anos."
    ```

Estas são apenas algumas das funções de strings disponíveis em C#. Existem muitas outras que podem ser usadas para várias operações de manipulação de strings.