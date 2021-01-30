using System;
using System.Globalization;
namespace Exercicio_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            int qtd;
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome do Produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: R$");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Qtd = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("---------------------------");
            Console.Write("Digite a quantidade de produtos a adicionar no estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.Adiciona_Produto(qtd);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("---------------------------");
            Console.Write("Digite a quantidade de produtos a remover no estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.Remove_Produto(qtd);
            Console.WriteLine("Dados atualizados: " + p);



        }
    }
}


