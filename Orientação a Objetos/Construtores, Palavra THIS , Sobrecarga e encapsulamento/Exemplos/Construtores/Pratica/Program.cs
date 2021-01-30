using System;
using System.Globalization;

namespace Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do Produto: ");
            string Nome_Temp = Console.ReadLine ();
            Console.Write ("Preço: R$ ");
            float Preco_Temp = float.Parse (Console.ReadLine (),CultureInfo.InvariantCulture);
            Console.Write ("Quantidade: ");
            int Qtd_Temp = int.Parse (Console.ReadLine ());
            Produto p = new Produto (Nome_Temp, Preco_Temp, Qtd_Temp); // fazendo a instaciação, com os dados do produto obrigatórios
            Console.WriteLine ("Dados do produto");
            Console.Write (p);
        }
    }
}
