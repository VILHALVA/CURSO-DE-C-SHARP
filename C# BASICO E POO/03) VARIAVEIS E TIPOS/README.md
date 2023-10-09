# VARIAVEIS E TIPOS DE DADOS
Em C#, as variáveis são usadas para armazenar e manipular dados em um programa. Os tipos de dados em C# especificam o tipo de valor que uma variável pode conter. Aqui estão alguns dos tipos de dados mais comuns em C# e como declarar variáveis com eles:

1. **Tipos Numéricos Integrais:**
   - `int`: Representa números inteiros, positivos ou negativos. Exemplo: `int idade = 30;`
   - `long`: Para números inteiros maiores que `int`. Exemplo: `long populacaoMundial = 7800000000L;`
   - `short`: Para números inteiros curtos. Exemplo: `short temperatura = -10;`
   - `byte`: Para números inteiros pequenos entre 0 e 255. Exemplo: `byte valor = 200;`

2. **Tipos Numéricos de Ponto Flutuante:**
   - `float`: Representa números de ponto flutuante de precisão simples. Exemplo: `float altura = 1.75f;`
   - `double`: Para números de ponto flutuante de precisão dupla (mais precisos). Exemplo: `double preco = 19.99;`

3. **Tipos Booleanos:**
   - `bool`: Representa valores booleanos `true` ou `false`. Exemplo: `bool estaChovendo = false;`

4. **Tipos de Caracteres:**
   - `char`: Representa um único caractere Unicode. Exemplo: `char letra = 'A';`

5. **Tipos de Texto:**
   - `string`: Representa uma sequência de caracteres. Exemplo: `string nome = "Alice";`

6. **Tipos de Data e Hora:**
   - `DateTime`: Representa uma data e hora específicas. Exemplo: `DateTime dataHoraAtual = DateTime.Now;`

7. **Tipos Enumerados:**
   - Enums são tipos definidos pelo usuário que consistem em um conjunto fixo de valores constantes. Exemplo:
   
   ```csharp
   enum DiaDaSemana
   {
       Segunda,
       Terca,
       Quarta,
       Quinta,
       Sexta,
       Sabado,
       Domingo
   }
   DiaDaSemana hoje = DiaDaSemana.Quarta;
   ```

8. **Tipos Nulos (Nullable Types):**
   - Alguns tipos de dados podem ser tornados nulos adicionando `?` após o tipo. Isso permite que a variável contenha um valor nulo adicional ao valor do tipo normal. Exemplo: `int? numero = null;`

9. **Outros Tipos de Dados Personalizados:**
   - Você também pode criar seus próprios tipos de dados personalizados usando classes ou estruturas (structs) para representar entidades específicas em seu programa.

Para declarar uma variável em C#, você geralmente usa a seguinte sintaxe:

```csharp
tipo_dado nomeDaVariavel = valor_inicial;
```

Por exemplo, para declarar e atribuir um valor a uma variável do tipo `int`, você pode fazer:

```csharp
int numero = 10;
```

Lembre-se de que C# é uma linguagem de programação de tipagem estática, o que significa que o tipo de uma variável deve ser especificado quando ela é declarada e não pode ser alterado posteriormente. Certifique-se de escolher o tipo de dado apropriado para a sua variável, dependendo do tipo de valor que você deseja armazenar.
