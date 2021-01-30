using System;
using System.Globalization;

namespace Static_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cotação do Dolar em R$");
            float Cotacao =  float.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
            Console.Write ("Quantos dolares deseja comprar:  ");
            float Qtd = float.Parse (Console.ReadLine (),CultureInfo.InvariantCulture);
            Console.WriteLine ("Total a pagar: " + ConversorMoeda.DolarReal (Qtd, Cotacao).ToString ("F2",CultureInfo.InvariantCulture));
        }
    }
}
