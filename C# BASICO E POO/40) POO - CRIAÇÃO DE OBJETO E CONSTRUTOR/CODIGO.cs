using System;

// Classe base chamada "Pessoa"
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor da classe "Pessoa"
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método para exibir informações da pessoa
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos");
    }
}

// Classe derivada chamada "Aluno" que herda de "Pessoa"
class Aluno : Pessoa
{
    public string Matricula { get; set; }

    // Construtor da classe "Aluno" que chama o construtor da classe base "Pessoa"
    public Aluno(string nome, int idade, string matricula) : base(nome, idade)
    {
        Matricula = matricula;
    }

    // Método para exibir informações do aluno
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos, Matrícula: {Matricula}");
    }
}

class Program
{
    static void Main()
    {
        // Criando um objeto Pessoa usando o construtor
        Pessoa pessoa1 = new Pessoa("Alice", 30);

        // Criando um objeto Aluno usando o construtor da classe derivada
        Aluno aluno1 = new Aluno("Bob", 25, "12345");

        // Exibindo informações da pessoa e do aluno
        Console.WriteLine("Informações da Pessoa:");
        pessoa1.ExibirInformacoes();

        Console.WriteLine("\nInformações do Aluno:");
        aluno1.ExibirInformacoes();
    }
}
