# POO - CRIAÇÃO DE OBJETO E CONSTRUTOR
Orientação a objetos (POO) em C# envolve a criação de objetos de classes. Um construtor é um método especial que é chamado quando um objeto é criado a partir de uma classe. Vou fornecer um exemplo simples de criação de uma classe com um construtor em C#.

Suponha que você queira criar uma classe chamada `Pessoa` que represente uma pessoa com um nome e uma idade. Aqui está como você pode criar essa classe com um construtor:

```csharp
using System;

class Pessoa
{
    // Atributos da classe
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor da classe
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método para exibir informações da pessoa
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos");
    }
}

class Program
{
    static void Main()
    {
        // Criando um objeto Pessoa usando o construtor
        Pessoa pessoa1 = new Pessoa("Alice", 30);

        // Exibindo informações da pessoa
        pessoa1.ExibirInformacoes();
    }
}
```

Neste exemplo:

- Criamos uma classe chamada `Pessoa` com dois atributos: `Nome` e `Idade`.
- Definimos um construtor para a classe `Pessoa` que aceita dois parâmetros, `nome` e `idade`, e atribui esses valores aos atributos da classe.
- Criamos um método `ExibirInformacoes` para exibir as informações da pessoa.
- No método `Main`, criamos um objeto `pessoa1` da classe `Pessoa` usando o construtor. Passamos "Alice" como nome e 30 como idade.
- Finalmente, chamamos o método `ExibirInformacoes` do objeto `pessoa1` para exibir as informações da pessoa.

Isso é um exemplo básico de como criar um objeto de uma classe com um construtor em C#. O construtor é usado para inicializar os atributos do objeto quando ele é criado. Você pode criar outros objetos da mesma classe e definir diferentes valores de atributos para cada um deles.