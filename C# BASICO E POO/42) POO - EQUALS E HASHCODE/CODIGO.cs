using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string CodigoDeBarras { get; set; }

    public Produto(string nome, decimal preco, string codigoDeBarras)
    {
        Nome = nome;
        Preco = preco;
        CodigoDeBarras = codigoDeBarras;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Produto outroProduto = (Produto)obj;
        return CodigoDeBarras == outroProduto.CodigoDeBarras;
    }

    public override int GetHashCode()
    {
        return CodigoDeBarras.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Produto produto1 = new Produto("Camiseta", 19.99m, "12345");
        Produto produto2 = new Produto("Calça Jeans", 39.99m, "54321");
        Produto produto3 = new Produto("Camiseta", 19.99m, "12345");

        // Comparando produtos com Equals
        bool saoIguais = produto1.Equals(produto3);
        Console.WriteLine("produto1 e produto3 são iguais: " + saoIguais);

        // Criando um dicionário de produtos
        Dictionary<Produto, int> estoque = new Dictionary<Produto, int>();

        estoque.Add(produto1, 10);
        estoque.Add(produto2, 5);

        // Verificando a quantidade em estoque usando produto3 como chave
        int quantidadeEmEstoque;
        if (estoque.TryGetValue(produto3, out quantidadeEmEstoque))
        {
            Console.WriteLine($"Quantidade em estoque de produto3: {quantidadeEmEstoque}");
        }
        else
        {
            Console.WriteLine("produto3 não encontrado no estoque.");
        }
    }
}
