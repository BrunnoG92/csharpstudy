using System;

namespace Exercicios
{
    class Negativo_Positivo
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int x = int.Parse (Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine ($"{x} é um numero negativo");
            }
            else
            {
                Console.WriteLine ($"{x} é um numero positivo");
            }
        }
    }
}
