using System;
using System.Globalization;

namespace VetorP2___PrecoProduto
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Quantidade de produtos a cadastrar:");
            int N = int.Parse(Console.ReadLine());
            Produto[] Vetor = new Produto[N]; // VETOR DE PRODUTOS //

            for (int i =0; i < N; i++) // laço para leitura dos produtos //
            {
                Console.Write("Nome do Produto:");
                string Name_Temp = Console.ReadLine();
                Console.Write("Preço do Produto:R$");
                double Price_Temp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Vetor[i] = new Produto {Name = Name_Temp , Price = Price_Temp};
            }
            double sum = 0.0;
            for (int i =0; i <N; i++)
            {
                sum += Vetor[i].Price; // SOMA RECEBE A SOMA DO ITEM PREÇO DO VETOR DE PRODUTO //
            }
            double avg = sum / N;
            Console.Write("Preço médio dos produtos: R$" + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
