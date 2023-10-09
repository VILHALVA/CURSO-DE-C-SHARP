using System;

namespace JogoDeAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto (entre 1 e 100).");

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
            int tentativas = 0;
            bool acertou = false;

            while (!acertou)
            {
                Console.Write("Digite sua tentativa: ");
                int tentativa = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Tente um número maior.");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("Tente um número menor.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
                    acertou = true;
                }
            }

            Console.WriteLine("O jogo acabou. Obrigado por jogar!");
            Console.ReadKey();
        }
    }
}
