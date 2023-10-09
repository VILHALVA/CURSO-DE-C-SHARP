using System;

namespace MenuComWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1 - Opção 1");
                Console.WriteLine("2 - Opção 2");
                Console.WriteLine("3 - Opção 3");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Você escolheu a Opção 1.");
                        // Adicione o código correspondente à Opção 1 aqui.
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu a Opção 2.");
                        // Adicione o código correspondente à Opção 2 aqui.
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a Opção 3.");
                        // Adicione o código correspondente à Opção 3 aqui.
                        break;
                    case 4:
                        Console.WriteLine("Saindo do programa.");
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            }
        }
    }
}
