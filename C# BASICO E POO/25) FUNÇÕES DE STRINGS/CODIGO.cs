using System;

class Program
{
    static void Main()
    {
        string texto = "   Olá, mundo!   ";

        // Remover espaços em branco do início e do fim
        string textoSemEspacos = texto.Trim();

        // Converter para maiúsculas e minúsculas
        string textoMaiusculas = texto.ToUpper();
        string textoMinusculas = texto.ToLower();

        // Substituir uma substring
        string textoSubstituido = texto.Replace("mundo", "C#");

        // Verificar se a string começa ou termina com determinadas substrings
        bool comecaComOla = texto.StartsWith("Olá");
        bool terminaComEspaco = texto.EndsWith(" ");

        // Dividir a string em partes usando um delimitador
        string[] palavras = texto.Split(' ');

        // Encontrar a posição de uma substring
        int posicaoOla = texto.IndexOf("Olá");
        int ultimaPosicaoEspaco = texto.LastIndexOf(" ");

        // Verificar o comprimento da string
        int tamanhoTexto = texto.Length;

        // Exibir resultados
        Console.WriteLine("Texto original: \"" + texto + "\"");
        Console.WriteLine("Texto sem espaços em branco: \"" + textoSemEspacos + "\"");
        Console.WriteLine("Texto em maiúsculas: \"" + textoMaiusculas + "\"");
        Console.WriteLine("Texto em minúsculas: \"" + textoMinusculas + "\"");
        Console.WriteLine("Texto com substituição: \"" + textoSubstituido + "\"");
        Console.WriteLine("Começa com 'Olá': " + comecaComOla);
        Console.WriteLine("Termina com espaço em branco: " + terminaComEspaco);
        Console.WriteLine("Palavras divididas: ");
        foreach (string palavra in palavras)
        {
            Console.WriteLine("- " + palavra);
        }
        Console.WriteLine("Posição de 'Olá': " + posicaoOla);
        Console.WriteLine("Última posição de espaço em branco: " + ultimaPosicaoEspaco);
        Console.WriteLine("Comprimento do texto: " + tamanhoTexto);
    }
}
