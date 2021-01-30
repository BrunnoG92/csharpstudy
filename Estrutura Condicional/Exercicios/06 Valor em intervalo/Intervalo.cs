using System;
using System.Globalization;

namespace _06_Valor_em_intervalo
{
    class Intervalo
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            float x = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (x >= 0 && x <= 25)
            {
                Console.WriteLine("Intervalo (0,25]");
            }
            else if (x > 25 && x <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (x > 50 && x <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (x > 75 && x <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine ("Fora do intervalo");
            }
        }
    }
}
