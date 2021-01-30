using System;
using System.Globalization;

namespace Comando_Saida
{
    class Comando_Saida
    {
        static void Main(string[] args)
        {
            string nome = "Maria";
            int idade = 32;
            float saldo = 314.12834f;

            Console.WriteLine("--------------------------");
            Console.WriteLine("PLACEHOLDER");
            Console.WriteLine("");
            Console.WriteLine("{0} tem {1} anos e tem {2:F2} reais em saldo", nome, idade, saldo);
            Console.WriteLine("--------------------------");
            Console.WriteLine("INTERPOLAÇÃO");
            Console.WriteLine();
            Console.WriteLine($"{nome} tem {idade} anos e tem {saldo:F2} reais em saldo ");
            Console.WriteLine("--------------------------");
            Console.WriteLine("CONCATENAÇÃO");
            Console.WriteLine();
            Console.WriteLine(nome + " tem " + idade + " anos e tem " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais em saldo ");


        }
    }
}
