using System;
using System.Globalization;

namespace Exercicio_2___Saida
{
    class Exercicio_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome_completo = Console.ReadLine();
            Console.WriteLine("Quantos Quartos tem na sua casa ? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');
            string sobrenome = vetor[0];
            int idade = int.Parse(vetor[1]);
            float altura = float.Parse(vetor[2], CultureInfo.InvariantCulture);
            Console.WriteLine($"Nome Completo: {nome_completo} ");
            Console.WriteLine($"Qtd de Quartos na casa: {quartos}");
            Console.WriteLine($"Preço do produto: R${preco}");
            Console.WriteLine("Ultimo nome , idade e altura: " + sobrenome + " " + idade + " " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
