# POO - EQUALS E HASHCODE
Em programação orientada a objetos (POO), os métodos `Equals` e `GetHashCode` são usados para comparar objetos e fornecer um código de hash para os objetos, respectivamente. Vou fornecer um exemplo que demonstra como implementar esses métodos em uma classe C#.

```csharp
using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método Equals para comparar duas instâncias de Pessoa
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Pessoa outraPessoa = (Pessoa)obj;
        return (Nome == outraPessoa.Nome) && (Idade == outraPessoa.Idade);
    }

    // Método GetHashCode para calcular o código de hash da instância de Pessoa
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Nome.GetHashCode();
            hash = hash * 23 + Idade.GetHashCode();
            return hash;
        }
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa("Alice", 30);
        Pessoa pessoa2 = new Pessoa("Bob", 25);
        Pessoa pessoa3 = new Pessoa("Alice", 30);

        // Comparando objetos com Equals
        bool saoIguais = pessoa1.Equals(pessoa3);
        Console.WriteLine("pessoa1 e pessoa3 são iguais: " + saoIguais);

        // Exibindo códigos de hash
        Console.WriteLine("HashCode de pessoa1: " + pessoa1.GetHashCode());
        Console.WriteLine("HashCode de pessoa2: " + pessoa2.GetHashCode());
        Console.WriteLine("HashCode de pessoa3: " + pessoa3.GetHashCode());
    }
}
```

Neste exemplo:

- Criamos uma classe `Pessoa` com dois atributos, `Nome` e `Idade`, e um construtor.
- Substituímos o método `Equals` para comparar duas instâncias de `Pessoa`. Ele verifica se os nomes e idades das duas pessoas são iguais.
- Substituímos o método `GetHashCode` para calcular o código de hash da instância de `Pessoa`. O código de hash é calculado com base nos valores dos atributos `Nome` e `Idade`.
- No método `Main`, criamos três instâncias de `Pessoa` (`pessoa1`, `pessoa2` e `pessoa3`).
- Usamos o método `Equals` para comparar `pessoa1` e `pessoa3`, e ele retorna `true` porque possuem os mesmos valores de `Nome` e `Idade`.
- Exibimos os códigos de hash de `pessoa1`, `pessoa2` e `pessoa3`.

Implementar `Equals` e `GetHashCode` de forma apropriada é importante para garantir que objetos possam ser comparados corretamente e usados em estruturas de dados baseadas em hash, como dicionários e conjuntos. O método `Equals` é usado para comparações de igualdade, enquanto `GetHashCode` é usado para determinar onde o objeto será armazenado em estruturas de dados baseadas em hash.