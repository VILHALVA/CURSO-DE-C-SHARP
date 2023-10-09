using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();

        string textoMaiusculas = texto.ToUpper();
        string textoMinusculas = texto.ToLower();

        Console.WriteLine("\nTexto em maiúsculas: " + textoMaiusculas);
        Console.WriteLine("Texto em minúsculas: " + textoMinusculas);
    }
}
