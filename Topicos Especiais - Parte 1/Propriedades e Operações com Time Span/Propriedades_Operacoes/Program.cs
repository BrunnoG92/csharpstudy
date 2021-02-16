using System;

namespace Propriedades_Operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan T1 = new TimeSpan(2, 3, 5, 7, 11);
            TimeSpan T2 = new TimeSpan(0, 10, 5);

            Console.WriteLine("Tempo inicial: " + T1);
            Console.WriteLine("=====================");
            
            Console.WriteLine("Dias: " + T1.Days);
            Console.WriteLine("Horas: " + T1.Hours);
            Console.WriteLine("Minutos: " + T1.Minutes);
            Console.WriteLine("Segundos: " + T1.Seconds);
            Console.WriteLine("Milisegundos: " + T1.Milliseconds);
            Console.WriteLine("Dias Totais: " + T1.TotalDays);
            Console.WriteLine("Horas Totais: " + T1.TotalHours);
            Console.WriteLine("Minutos Totais: " + T1.TotalMinutes);
            Console.WriteLine("Segundos Totais: " + T1.TotalSeconds);
            Console.WriteLine("Milisegundos Totais: " + T1.TotalMilliseconds);

            Console.WriteLine("OPERAÇÕES");
            Console.WriteLine("Somando: " + T1.Add(T2));
            Console.WriteLine("Subtraindo: " + T1.Subtract(T2));
            Console.WriteLine("Multiplicando: " + T1.Multiply(2));
            Console.WriteLine("Divindo: " + T1.Divide(2));


        }
    }
}
