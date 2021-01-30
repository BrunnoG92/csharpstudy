using System;
using System.Globalization;

namespace _02___Raio_de_um_Circulo
{
    class Area_do_circulo
    {
        static void Main(string[] args)
        {
           Console.Write ("Digite o valor do raio do circulo: ");
           float raio = float.Parse (Console.ReadLine ());
           float pi = 3.14159f;
           double  area = pi * Math.Pow (raio,2) ;
           Console.WriteLine ("A área do circulo é : " + area.ToString ("F4",CultureInfo.InvariantCulture));
        }
    }
}