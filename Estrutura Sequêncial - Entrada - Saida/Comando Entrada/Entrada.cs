using System;

namespace Comando_Entrada
{
    class Entrada
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite uma frase: ");
            
            string [] vetor = Console.ReadLine().Split (' ');
            string p1 = vetor [0];
            string p2 = vetor [1];
            string p3 = vetor [2];
            Console.WriteLine ($"Você digitou: {p1} {p2} {p3}" );
            
        }
    }
}
