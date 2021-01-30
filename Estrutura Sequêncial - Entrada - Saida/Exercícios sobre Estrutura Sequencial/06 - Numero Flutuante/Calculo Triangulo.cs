using System;
using System.Globalization;

namespace _06___Numero_Flutuante
{
    class Calculo_Triagulo
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            float A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de B: ");
            float B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de C: ");
            float C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("CALCULO DA AREA DO TRIÂNGULO RETÂNGULO ");
            float area_t = (A * C) / 2;
            Console.WriteLine("A Área do Triângulo retângulo é : " + area_t.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("CALCULO DA AREA DO CIRCULO ");
            float pi = 3.14159f;
            float area_c = pi * C *C ;
            Console.WriteLine("A area do circulo é: " + area_c.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("CALCULO DA AREA DO TRAPEZIO ");
            float area_trap = ((A + B) / 2) * C;
            Console.WriteLine("A area do trapézio é : " + area_trap.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("CALCULO DA AREA DO QUADRADO ");
            double area_quad = Math.Pow(B, 2);
            Console.WriteLine("A área do quadrado é: " + area_quad.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("CALCULO DA AREA DO RETÂNGULO ");
            float area_ret = A*B;
            Console.WriteLine ("A area do retângulo é : "+ area_ret.ToString("F2",CultureInfo.InvariantCulture));




        }
    }
}
