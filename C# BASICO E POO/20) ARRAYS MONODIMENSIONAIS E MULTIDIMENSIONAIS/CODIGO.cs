using System;

namespace ExemploArrayAvancado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array bidimensional para representar um tabuleiro de xadrez 8x8
            char[,] tabuleiroXadrez = new char[8, 8];

            InicializarTabuleiro(tabuleiroXadrez);
            ExibirTabuleiro(tabuleiroXadrez);

            // Array unidimensional para pontuações de jogadores
            int[] pontuacoes = new int[2];

            JogarPartida(tabuleiroXadrez, pontuacoes);

            Console.WriteLine("\nPontuações dos Jogadores:");
            Console.WriteLine("Jogador 1: " + pontuacoes[0]);
            Console.WriteLine("Jogador 2: " + pontuacoes[1]);
        }

        static void InicializarTabuleiro(char[,] tabuleiro)
        {
            // Preenche o tabuleiro com espaços em branco
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tabuleiro[i, j] = ' ';
                }
            }

            // Inicializa algumas peças no tabuleiro (simplificado)
            tabuleiro[0, 0] = 'R';
            tabuleiro[7, 0] = 'r';
            tabuleiro[1, 4] = 'K';
            tabuleiro[6, 4] = 'k';
        }

        static void ExibirTabuleiro(char[,] tabuleiro)
        {
            Console.WriteLine("Tabuleiro de Xadrez:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(tabuleiro[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void JogarPartida(char[,] tabuleiro, int[] pontuacoes)
        {
            // Simulação de uma partida (simplificada)
            Console.WriteLine("\nSimulando uma partida...");
            tabuleiro[3, 3] = 'Q'; // Rainha
            tabuleiro[4, 4] = 'p'; // Peão

            ExibirTabuleiro(tabuleiro);

            // Atualiza as pontuações dos jogadores
            pontuacoes[0] = 5; // Pontuação fictícia para o jogador 1
            pontuacoes[1] = 3; // Pontuação fictícia para o jogador 2
        }
    }
}
