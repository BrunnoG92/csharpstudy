using System;

namespace Func_DateSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan T1 = new TimeSpan(0, 1, 30); // TIME SPAN REPRESENTA INTERVALO DE TEMPO. AQUI 0H:01 MIN E 30S
            TimeSpan T2 = new TimeSpan(); // 0h:0m:0s
            TimeSpan T3 = new TimeSpan(1, 2, 11, 21); // DIA , HORA, MIN , SEGUNDO
            TimeSpan T4 = TimeSpan.FromDays(1.5); // CONVERTE DIAS PARA DIA , HORA MIN E SEGUNDO. AQUI CONVERTER 1 DIA E MEIO
            TimeSpan T5 = TimeSpan.FromHours (1.5);
            TimeSpan T6 = TimeSpan.FromMinutes(1.5);
            TimeSpan T7 = TimeSpan.FromSeconds(1.5);
            TimeSpan T8 = TimeSpan.FromMilliseconds(1.5);





            Console.WriteLine(T1);
            Console.WriteLine(T2);
            Console.WriteLine(T3);
            Console.WriteLine(T4);
            Console.WriteLine(T5);
            Console.WriteLine(T6);
            Console.WriteLine(T7);
            Console.WriteLine(T8);





        }
    }
}
