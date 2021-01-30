using System;

namespace _02_Par_Impar
{
    class Par_ou_impar
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int x = int.Parse (Console.ReadLine ());
            if ( x % 2 == 0 )
            {
                Console.WriteLine ($"{x} é um número par");
            }
            else
            {
                Console.WriteLine ($"{x} é um número impar");
            }
            
        }
    }
}
