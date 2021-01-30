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
            p.Nome = nome_temp; // alterando o nome diretamente
            p.Nome = "abc";
            Console.WriteLine("O nome do produto é " + p.Nome); // acessando o nome do produto diretamente, que é privado
            
        
        }
    }
}
