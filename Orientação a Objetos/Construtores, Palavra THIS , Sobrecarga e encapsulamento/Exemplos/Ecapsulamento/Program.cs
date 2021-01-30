using System;


namespace Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();  // fazendo a instaciação
            Console.Write("Nome do Produto: ");
            string nome_temp = Console.ReadLine();
            p.SetNome(nome_temp); // alterando o nome diretamente
            Console.WriteLine("O nome do produto é " + p.GetNome()); // acessando o nome do produto diretamente, que é privado

        }
    }
}
