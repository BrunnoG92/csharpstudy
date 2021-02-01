using System;
using System.Globalization;

namespace Media_Altura___P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetor");
            int N = int.Parse(Console.ReadLine());
            double[] vect = new double[N]; // tipo do vetor [] nomedovetor = new tipodovetor [tamanhodovetor];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite o " + i + "° número do vetor");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double Soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                Soma += vect[i];
            }
            double avg = Soma / N;

            Console.WriteLine("A média dos números do vetor é:" + avg.ToString("F2", CultureInfo.InvariantCulture));
;        }
    }
}
