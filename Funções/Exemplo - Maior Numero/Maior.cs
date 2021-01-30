using System;

namespace Funções
{
    class Maior_Numero
    {
        static void Main(string[] args)
        {
            Console.Write("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int resultado = (Maior(n1, n2, n3));
            Console.WriteLine($"O maior número é {resultado}");
        }
        static int Maior(int A, int B, int C)
        {
            int m;
            if (A > B && A > C)
            {
                m = A;
            }
            else if (B > C)
            {
                m = B;
            }
            else
            {
                m = C;
            }
            return m;

        }

    }
}
