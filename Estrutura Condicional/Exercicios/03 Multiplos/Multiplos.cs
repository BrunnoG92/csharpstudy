using System;

namespace _03_Multiplos
{
    class Multiplos
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x % y == 0)
                {
                    Console.WriteLine($"{x} e {y} são multiplos");
                }
                else
                {
                    Console.WriteLine($"{x} e {y} não  são multiplos");
                }
            }
            else
            {
                if (y % x == 0)
                {
                    Console.WriteLine($"{x} e {y} são multiplos");
                }
                else
                {
                    Console.WriteLine($"{x} e {y} não são multiplos");
                }
            }



        }
    }
}
