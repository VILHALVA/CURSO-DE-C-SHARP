using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string texto = Console.ReadLine();

        // Usar Remove para eliminar uma substring
        string textoSemSubstring = texto.Remove(5, 6); // Remove da posição 5, 6 caracteres

        // Usar IndexOf para encontrar a posição da primeira ocorrência de uma substring
        int posicao = texto.IndexOf("uma");

        Console.WriteLine("\nTexto sem a substring 'uma': " + textoSemSubstring);
        Console.WriteLine("Posição da primeira ocorrência de 'uma': " + posicao);
    }
}
