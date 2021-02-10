using System;

namespace Soma_Pararms
{
    class Program
    {
        static void Main(string[] args)
        {
            int S1 = Soma.Sum(2, 3); // instanciação do vetor pode ser feita diretamente com numeros, ao inves de new int [] { 2,3}
            int S2 = Soma.Sum(2, 4, 5, 7);
            Console.WriteLine("Soma 1: " + S1);
            Console.WriteLine("Soma 2: " + S2);
;        }
    }
}
