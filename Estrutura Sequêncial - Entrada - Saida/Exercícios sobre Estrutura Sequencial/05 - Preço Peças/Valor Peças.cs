using System;
using System.Globalization;

namespace _05___Preço_Peças
{
    class Valor_peças
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o código da peça1: ");
            int codigo_1 = int.Parse( Console.ReadLine());
            Console.Write("Informe o valor da peça1 R$: ");
            float valor_1 = float.Parse (Console.ReadLine (),CultureInfo.InvariantCulture);
            Console.Write("Informe a quantidade comprada : ");
            int qtd1 = int.Parse (Console.ReadLine ());
            Console.Write("Informe o código da peça2: ");
            int codigo_2 = int.Parse (Console.ReadLine ());
            Console.Write("Informe o valor da peça2 R$: ");
            float valor_2 = float.Parse (Console.ReadLine (),CultureInfo.InvariantCulture);
            Console.Write("Informe a quantidade comprada : ");
            int qtd2 = int.Parse (Console.ReadLine ());
            float valor_total = ((valor_1 * qtd1)+ (valor_2 * qtd2));
            Console.WriteLine ("Valor total da compra: R$ " + valor_total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
