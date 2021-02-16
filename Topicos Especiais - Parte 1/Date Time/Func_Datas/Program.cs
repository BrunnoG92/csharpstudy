using System;
using System.Globalization;
namespace Func_Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime D1 = DateTime.Now; // INSTACIA A DATA ATUAL NO FORMATO DO SISTEMA
            DateTime D2 = new DateTime(2021, 02, 15);  //INSTANCIA UMA DATA PERSONALIZADA, COM HORA 0:00H
            DateTime D3 = new DateTime(2021, 02, 15, 19, 00, 13); // INSTANCIA UMA DATA PERSONALIZADA + HORA
            DateTime D4 = DateTime.Today; // DATA DE HOJE AS 0H)
            DateTime D5 = DateTime.UtcNow; // HORARIO UNIVERSAL, GMT GREENWICH
            DateTime D6 = DateTime.Parse("2000-08-15"); // CONVETER STRING PARA DATA
            DateTime D7 = DateTime.Parse("2000-07-29 13:40:21"); // CONVETER STRING PARA DATA E HORA
            DateTime D8 = DateTime.Parse("10/01/2021 12:21:32"); // STRING PADRAO BRASILEIRO PARA DATA
            DateTime D9 = DateTime.ParseExact("2021-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); // CRIAR UM FORMATO DE DATA PERSONALIZADO
            
            Console.WriteLine(D1);
            Console.WriteLine(D1.Ticks); // QUANTIDADE DE TICKS (1 TICK E 100 NANO SEGUNDO) DE 01/01/01 A DATA DE 
            Console.WriteLine(D2);
            Console.WriteLine(D3);
            Console.WriteLine(D4);
            Console.WriteLine(D5);
            Console.WriteLine(D6);
            Console.WriteLine(D7);
            Console.WriteLine(D8);
            Console.WriteLine(D9);
        }
    }
}
