using System;

namespace VerificadorDeVoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de Elegibilidade para Votação");

            // Solicita ao usuário que insira sua idade
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            // Verifica a elegibilidade para votação
            if (idade < 16)
            {
                Console.WriteLine("Você não é elegível para votar.");
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Você é elegível para votar, mas ainda é considerado jovem.");
            }
            else if (idade >= 18 && idade < 65)
            {
                Console.WriteLine("Você é elegível para votar e é considerado um eleitor adulto.");
            }
            else
            {
                Console.WriteLine("Você é elegível para votar e é considerado um eleitor idoso.");
            }

            // Aguarda o usuário pressionar uma tecla para sair
            Console.ReadKey();
        }
    }
}
