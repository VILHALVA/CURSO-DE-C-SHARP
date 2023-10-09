using System;

namespace Casino
{
    class Program
    {
        // Variável global para o saldo do jogador
        static double saldoJogador = 1000.0;

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Cassino Virtual!");

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1 - Jogo de Dados");
                Console.WriteLine("2 - Raspadinha");
                Console.WriteLine("3 - Consultar Saldo");
                Console.WriteLine("4 - Levantar Fundos");
                Console.WriteLine("5 - Depósito de Fundos");
                Console.WriteLine("6 - Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        JogarJogoDeDados();
                        break;
                    case 2:
                        JogarRaspadinha();
                        break;
                    case 3:
                        ConsultarSaldo();
                        break;
                    case 4:
                        LevantarFundos();
                        break;
                    case 5:
                        DepositarFundos();
                        break;
                    case 6:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

            Console.WriteLine("Obrigado por jogar no Cassino Virtual!");
        }

        static void JogarJogoDeDados()
        {
            Console.WriteLine("Jogo de Dados:");
            Console.Write("Pressione Enter para lançar os dados...");
            Console.ReadLine();

            Random random = new Random();
            int dado1 = random.Next(1, 7); // Número aleatório entre 1 e 6
            int dado2 = random.Next(1, 7);

            Console.WriteLine($"Dado 1: {dado1}");
            Console.WriteLine($"Dado 2: {dado2}");

            if (dado1 == dado2)
            {
                Console.WriteLine("Parabéns! Você ganhou!");
                saldoJogador += 50.0; // Prêmio de $50 por ganhar
            }
            else
            {
                Console.WriteLine("Você perdeu. Tente novamente.");
                saldoJogador -= 10.0; // Perda de $10 por perder
            }
        }

        static void JogarRaspadinha()
        {
            Console.WriteLine("Jogo de Raspadinha:");
            Console.Write("Pressione Enter para revelar o resultado...");
            Console.ReadLine();

            Random random = new Random();
            int resultado = random.Next(1, 4); // Número aleatório entre 1 e 3

            if (resultado == 1)
            {
                Console.WriteLine("Parabéns! Você ganhou uma raspadinha!");
                saldoJogador += 20.0; // Prêmio de $20 por ganhar
            }
            else
            {
                Console.WriteLine("Você não ganhou. Tente novamente.");
                saldoJogador -= 5.0; // Perda de $5 por perder
            }
        }

        static void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo atual é de ${saldoJogador}");
        }

        static void LevantarFundos()
        {
            Console.Write("Digite o valor que deseja levantar: $");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (valor > 0 && valor <= saldoJogador)
            {
                saldoJogador -= valor;
                Console.WriteLine($"Levantamento bem-sucedido de ${valor}");
            }
            else
            {
                Console.WriteLine("Valor inválido ou saldo insuficiente.");
            }
        }

        static void DepositarFundos()
        {
            Console.Write("Digite o valor que deseja depositar: $");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (valor > 0)
            {
                saldoJogador += valor;
                Console.WriteLine($"Depósito bem-sucedido de ${valor}");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}
