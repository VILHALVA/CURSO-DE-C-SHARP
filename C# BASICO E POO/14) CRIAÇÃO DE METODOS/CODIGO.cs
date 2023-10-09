using System;

namespace GerenciamentoDeContas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria minhaConta = new ContaBancaria("João", 1000);
            Console.WriteLine($"Bem-vindo, {minhaConta.Titular}!");
            ExibirMenuPrincipal(minhaConta);
        }

        static void ExibirMenuPrincipal(ContaBancaria conta)
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1 - Consultar Saldo");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("4 - Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ConsultarSaldo(conta);
                        break;
                    case 2:
                        Depositar(conta);
                        break;
                    case 3:
                        Sacar(conta);
                        break;
                    case 4:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void ConsultarSaldo(ContaBancaria conta)
        {
            Console.WriteLine($"Saldo atual da conta de {conta.Titular}: ${conta.Saldo}");
        }

        static void Depositar(ContaBancaria conta)
        {
            Console.Write("Digite o valor a ser depositado: $");
            double valor = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(valor);
            Console.WriteLine($"Depósito de ${valor} realizado com sucesso.");
        }

        static void Sacar(ContaBancaria conta)
        {
            Console.Write("Digite o valor a ser sacado: $");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (conta.Sacar(valor))
            {
                Console.WriteLine($"Saque de ${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente. Operação não realizada.");
            }
        }
    }

    class ContaBancaria
    {
        public string Titular { get; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
