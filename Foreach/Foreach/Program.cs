using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            for (int i =0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Usando o foreach");
            Console.WriteLine("------------------");
            foreach (string nome in vect) //PARA CADA STRING NO VETOR, NOME É UM NOME QUALQUER, APELIDO DOS ITENS 
            {
                Console.WriteLine(nome);
            }

        }
    }
}
