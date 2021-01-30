using System;

namespace _03___Diferença_do_Produto
{
    class Diferneca_do_produto
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º número: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 4º número: ");
            int n4 = int.Parse(Console.ReadLine());
            int diferenca = (n1*n2 - (n3*n4));
            Console.Write ($"A difereça do produto é : {diferenca}");
        }
    }
}
