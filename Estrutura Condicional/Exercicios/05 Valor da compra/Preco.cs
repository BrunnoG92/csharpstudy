using System;
using System.Globalization;
namespace _05_Valor_da_compra
{
    class Preco
    {
        static void Main(string[] args)
        {
            float p1 = 4.00f;
            float p2 = 4.50f;
            float p3 = 5.00f;
            float p4 = 2.00f;
            float p5 = 1.50f;
            Console.Write("Digite o número do pedido: ");
            int codigo_pedido = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade a ser comprada: ");
            int qtd = int.Parse(Console.ReadLine());
            float valor_total = 0.0f;

            if (codigo_pedido == 1)
            {
                valor_total = qtd * p1;
            }
            else if (codigo_pedido == 2)
            {
                valor_total = qtd * p2;
            }
            else if (codigo_pedido == 3)
            {
                valor_total = qtd * p3;
            }
            else if (codigo_pedido == 4)
            {
                valor_total = qtd * p4;
            }
            else
            {
                valor_total = qtd * p5;
            }
            Console.WriteLine ("Valor total do pedido: R$"+ valor_total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
