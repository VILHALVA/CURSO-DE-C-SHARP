using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string texto = Console.ReadLine();

        // Usar Replace para substituir um caractere ou substring
        string textoSubstituido = texto.Replace("a", "@");

        // Usar Trim para remover espaços em branco no início e no fim
        string textoSemEspacos = texto.Trim();

        // Usar Length para obter o comprimento da string
        int comprimentoTexto = texto.Length;

        Console.WriteLine("\nTexto com substituição de 'a' por '@': " + textoSubstituido);
        Console.WriteLine("Texto sem espaços em branco: " + textoSemEspacos);
        Console.WriteLine("Comprimento do texto: " + comprimentoTexto);
    }
}
