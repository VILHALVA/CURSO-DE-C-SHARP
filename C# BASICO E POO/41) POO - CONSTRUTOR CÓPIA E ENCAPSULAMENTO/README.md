# POO - CONSTRUTOR CÓPIA E ENCAPSULAMENTO
Em programação orientada a objetos (POO), um construtor de cópia é um construtor que cria uma nova instância de um objeto com base em outra instância existente do mesmo tipo. O encapsulamento é um princípio de POO que consiste em ocultar os detalhes internos de uma classe e fornecer uma interface pública para interagir com a classe. Vou fornecer um exemplo em C# que demonstra o uso de um construtor de cópia e encapsulamento em uma classe.

```csharp
using System;

class Pessoa
{
    // Propriedades privadas encapsuladas
    private string nome;
    private int idade;

    // Propriedades públicas para acesso aos atributos encapsulados
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    // Construtor padrão
    public Pessoa()
    {
        nome = "Sem Nome";
        idade = 0;
    }

    // Construtor de cópia
    public Pessoa(Pessoa outraPessoa)
    {
        nome = outraPessoa.Nome;
        idade = outraPessoa.Idade;
    }

    // Método para exibir informações da pessoa
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}, Idade: {idade} anos");
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Alice";
        pessoa1.Idade = 30;

        // Usando o construtor de cópia para criar uma nova pessoa baseada em pessoa1
        Pessoa pessoa2 = new Pessoa(pessoa1);

        Console.WriteLine("Informações da Pessoa 1:");
        pessoa1.ExibirInformacoes();

        Console.WriteLine("\nInformações da Pessoa 2 (cópia de Pessoa 1):");
        pessoa2.ExibirInformacoes();
    }
}
```

Neste exemplo:

- Criamos uma classe `Pessoa` que possui atributos privados `nome` e `idade` encapsulados com propriedades públicas de leitura e escrita.
- Definimos dois construtores na classe `Pessoa`: um construtor padrão e um construtor de cópia. O construtor de cópia cria uma nova instância de `Pessoa` com base em outra instância existente.
- No método `Main`, criamos uma instância de `Pessoa` chamada `pessoa1` e definimos seus atributos.
- Em seguida, usamos o construtor de cópia para criar uma nova instância `pessoa2` com base em `pessoa1`.
- Demonstramos o encapsulamento ao acessar os atributos `Nome` e `Idade` por meio das propriedades públicas.
- Exibimos as informações de ambas as instâncias para mostrar que a cópia foi bem-sucedida.

Este exemplo ilustra o uso de um construtor de cópia e o princípio de encapsulamento em C#. O encapsulamento protege os detalhes internos da classe e fornece métodos públicos para acessar e manipular seus atributos. O construtor de cópia permite criar cópias de objetos existentes com facilidade.