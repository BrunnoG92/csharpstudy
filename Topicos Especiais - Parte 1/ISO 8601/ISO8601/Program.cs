using System;

namespace ISO8601
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime D1 = DateTime.Parse(" 2020-08-12 12:34:11");
            DateTime D2 = DateTime.Parse(" 2020-08-12T12:34:11Z"); // PADRÃO UTC 

            Console.WriteLine("D1:" + D1);
            Console.WriteLine("D1 Kind: " + D1.Kind);
            Console.WriteLine("D1 para Local: " + D1.ToLocalTime());
            Console.WriteLine("D1 para UTC: "+ D1.ToUniversalTime());
            Console.WriteLine("==============================");

            Console.WriteLine("D2: " + D2);
            Console.WriteLine("D2 Kind: " + D2.Kind);
            Console.WriteLine("D2 para Local: " + D2.ToLocalTime());
            Console.WriteLine("D2 para UTC: " + D2.ToUniversalTime());
            Console.WriteLine("==============================");
            Console.WriteLine("D2: " + D2.ToString ("yyyy-MMM-ddTHH:mm:ssZ")); // CUIDADO AO USAR. IDEAL É CONVETER PRIMEIRO PARA UTC
            Console.WriteLine("D2: " + D2.ToUniversalTime().ToString("yyy-MMM-ddTHH:mm:ssZ"));


        }
    }
}

/* FORMTATO ISO 8601 UTC
 * yyy-MM-ddTHH:mm:ssZ
 * Z indica que a data ou hora está em utc
 */