using System;

namespace _01___Soma
{
    class Soma_02_Numeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Digite o primeiro número: ");
            int n1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o segundo número: ");
            int n2 = int.Parse (Console.ReadLine ());
            int soma = n1 + n2;
            Console.WriteLine ($"A soma é {soma}");

        }
    }
}
