using System;

namespace Propriedades_Operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime D1 = new DateTime(2021,02,15,22,30,10);

            Console.WriteLine("Data completa: " + D1);
            Console.WriteLine("Data inicial as 0h:" + D1.Date);
            Console.WriteLine("Dia:" + D1.Date.Day); //DIA
            Console.WriteLine("Dia da semana:" + D1.Date.DayOfWeek); // DIA DA SEMANA
            Console.WriteLine("Dias de 1 Janeiro a data:" + D1.Date.DayOfYear); // DIAS DE 1 JANEIRO ATÉ A DATA//
            Console.WriteLine("Hora:" + D1.Hour); //HORA DA DATA
            Console.WriteLine("Fuso horario:" + D1.Kind); //FUSO HORARIO //
            Console.WriteLine("Milisegundos:" + D1.Millisecond); //MILISEGUNDOS
            Console.WriteLine("Minutos:" + D1.Minute); // MINUTOS
            Console.WriteLine("Mês:" + D1.Month); // MES
            Console.WriteLine("Segundos:" + D1.Second); //SEGUNDOS
            Console.WriteLine("Ticks:" + D1.Ticks); //TICKS
            Console.WriteLine("Hora:" + D1.TimeOfDay);// HORA DA DATA
            Console.WriteLine("Ano:" + D1.Year); // ANO
            Console.WriteLine("=============================");
         
            
            Console.WriteLine("FORMATAÇÕES DE DATAS");
            Console.WriteLine("=============================");
            Console.WriteLine(D1.ToLongDateString()); // EXIBIR DATA POR EXTENSO
            Console.WriteLine(D1.ToShortDateString()); // EXIBIR DATA POR ABREVIADA,
            Console.WriteLine(D1.ToLongTimeString()); // EXIBIR HORA POR EXTENSO
            Console.WriteLine(D1.ToShortTimeString()); // EXIBIR HORA POR EXTENSO
            Console.WriteLine(D1.ToString("yyy-MM-dd HH:mm:ss")); // EXIBIR DATA PERSONALIZADA




        }
    }
}
