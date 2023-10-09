using System;
using System.Collections.Generic;

class Carro
{
    private string marca;
    private string modelo;
    private int ano;

    // Propriedades públicas para acesso aos atributos encapsulados
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }

    // Construtor padrão
    public Carro()
    {
        marca = "Desconhecida";
        modelo = "Desconhecido";
        ano = 0;
    }

    // Construtor de cópia
    public Carro(Carro outroCarro)
    {
        marca = outroCarro.Marca;
        modelo = outroCarro.Modelo;
        ano = outroCarro.Ano;
    }

    // Método para exibir informações do carro
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano: {ano}");
    }
}

class Program
{
    static void Main()
    {
        // Criando uma lista de carros
        List<Carro> listaCarros = new List<Carro>();

        Carro carro1 = new Carro();
        carro1.Marca = "Toyota";
        carro1.Modelo = "Corolla";
        carro1.Ano = 2021;

        listaCarros.Add(carro1);

        // Usando o construtor de cópia para fazer uma cópia profunda da lista de carros
        List<Carro> listaCarrosCopia = new List<Carro>();
        foreach (Carro carro in listaCarros)
        {
            listaCarrosCopia.Add(new Carro(carro));
        }

        // Modificando a cópia
        listaCarrosCopia[0].Ano = 2022;

        Console.WriteLine("Informações do Carro Original:");
        listaCarros[0].ExibirInformacoes();

        Console.WriteLine("\nInformações do Carro na Cópia:");
        listaCarrosCopia[0].ExibirInformacoes();
    }
}
