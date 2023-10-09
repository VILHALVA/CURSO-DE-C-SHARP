using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma lista de itens separados por vírgulas: ");
        string entrada = Console.ReadLine();

        // Usar Split para dividir a string com base em vírgulas
        string[] itens = entrada.Split(',');

        Console.WriteLine("\nItens separados:");

        // Exibir cada item após a divisão
        foreach (string item in itens)
        {
            Console.WriteLine("- " + item.Trim()); // Remover espaços em branco ao redor do item
        }
    }
}
