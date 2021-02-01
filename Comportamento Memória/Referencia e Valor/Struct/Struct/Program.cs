using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p; // Novo struct tipo p. Iniciando com valores pre definidos
            p.X = 10;
            p.Y = 5;
            Console.WriteLine(p);
            p = new Point(); // Iniciada a struct. Valores inicias zeros
            Console.WriteLine(p);

        }
    }
}
