using System;
using System.Globalization;
namespace Exercicio_Saida
{
    class Exercicio
    {
        static void Main (string [] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            Console.WriteLine("Produtos: ");
            Console.WriteLine ($"{produto1} cujo preço é R$ {preco1}");
            Console.WriteLine ($"{produto2} cujo preço é R$ {preco2}");
            Console.WriteLine ($"{idade} anos de idade, código {codigo} e genero {genero}");
            Console.WriteLine ($"Medida com 8 casas decimais: {medida:F8}");
            Console.WriteLine ($" Arredondado - 3 casas decimais: {medida:F3}");
            Console.WriteLine ("Separador decimal ponto: " + medida.ToString ("F3", CultureInfo.InvariantCulture));
        }
    }
}