using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome_Temp;
            int Conta_Temp;
            char Resposta;
            float Deposito;
            float Saque;
            Console.WriteLine("Bem Vindo ao Banco ABC!");
            Console.Write("Informe o nome do Titular da conta: ");
            Nome_Temp = Console.ReadLine();
            Console.Write("Digite o número da conta: ");
            Conta_Temp = int.Parse(Console.ReadLine());
            Conta Conta_Corrente = new Conta(Conta_Temp, Nome_Temp);
            Console.WriteLine("Deseja fazer um deposito inicial ? (S/N)");
            Console.Write("-> ");
            Resposta = char.Parse(Console.ReadLine());
            if (Resposta == 'S')
            {
                Console.Write("Informe o valor do deposito: R$");
                Deposito = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta_Corrente = new Conta(Conta_Temp, Nome_Temp, Deposito);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(Conta_Corrente);
            }
            else
            {
                Console.WriteLine("Deposito inicial não feito");
                Console.WriteLine(Conta_Corrente);
            }
            Console.Write("Digite o valor do deposito: R$");
            Deposito = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta_Corrente.Deposito(Deposito);
            Console.WriteLine("Dados bancarios atualizados: ");
            Console.WriteLine(Conta_Corrente);
            Console.WriteLine("Digite o valor do saque (Terá uma taxa de R$5.00");
            Console.Write("R$");
            Saque = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta_Corrente.Saque(Saque);
            Console.WriteLine("Dados bancários atualizados: ");
            Console.WriteLine(Conta_Corrente);
        }
    }
}
