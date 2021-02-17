using System;

namespace DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime D1 = new DateTime(2000, 8, 15, 13, 5, 58, System.DateTimeKind.Local);
            DateTime D2 = new DateTime(2000, 8, 15, 13, 5, 58, System.DateTimeKind.Utc);
            DateTime D3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("D1:" + D1);
            Console.WriteLine("D1 kind " + D1.Kind);
            Console.WriteLine("D1 Local :" + D1.ToLocalTime ());
            Console.WriteLine("D1 UTC: " + D1.ToUniversalTime());
            Console.WriteLine("=========================");
           
            Console.WriteLine("D2:" + D2);
            Console.WriteLine("D2 kind " + D2.Kind);
            Console.WriteLine("D2 Local :" + D2.ToLocalTime());
            Console.WriteLine("D2 UTC: " + D2.ToUniversalTime());
            Console.WriteLine("========================="); 
           
            Console.WriteLine("D3 kind " + D3.Kind);
            Console.WriteLine("D3 Local :" + D3.ToLocalTime());
            Console.WriteLine("D3 UTC: " + D3.ToUniversalTime());
            Console.WriteLine("=========================");

            /* DATAS DEVEM SER SALVA NO PADRÃO UTC NO BANCO */



        }
    }
}
