using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; // ? indica que a variavel pode receber um null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault()); // pega o valor da variavel, caso seja nulo, seu valor padrão //
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue); // A variavel possui valor ? //
            Console.WriteLine(y.HasValue);
            if (x.HasValue) // Se o X possui algum valor
            {
                Console.WriteLine(x.Value);  // Imprimo o seu valor //
            }
            else
            {
                Console.WriteLine("X é nulo");

            }

            Console.WriteLine(y.Value);

            double? A = null;
            double? B =10;


            // Operador de Coalescência nula //
            double a = A ?? 5; //vou colocar em "a" o valor de A, se A for nulo, ele terá valor 5 //
            double b = B ?? 5; //vou colocar em "b" o valor de B, se A for nulo, ele terá valor 5 //
            Console.WriteLine(a); // Exibe como resposta 5 ,pois A é nulo //
            Console.WriteLine(b); // Exibe como resposta 10 ,pois B não é nulo //


        }
    }
}
