using System;

namespace CalculoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Média");
            
            // Solicita ao usuário que insira três números
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());
            
            // Calcula a média dos três números
            double media = (numero1 + numero2 + numero3) / 3.0;
            
            // Exibe o resultado
            Console.WriteLine($"A média dos números {numero1}, {numero2} e {numero3} é: {media}");
            
            // Aguarda o usuário pressionar uma tecla para sair
            Console.ReadKey();
        }
    }
}
