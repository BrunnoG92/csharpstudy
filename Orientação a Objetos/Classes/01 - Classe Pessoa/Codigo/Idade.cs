using System;

namespace Codigo
{
    class Idade
    {
        static void Main(string[] args)
        {
            Classe_Pessoas p1 = new Classe_Pessoas();
            Classe_Pessoas p2 = new Classe_Pessoas();

            Console.Write("Digite o nome da pessoa 1: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite a idade da pessoa 1: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da pessoa 2: ");
            p2.nome = Console.ReadLine();
            Console.Write("Digite a idade da pessoa 2: ");
            p2.idade = int.Parse(Console.ReadLine());
            if (p1.idade == p2.idade )
            {
                Console.WriteLine ("Ambos tem a mesma idade");
            }
            else if (p1.idade > p2.idade)
            {
                Console.WriteLine ($"{p1.nome} tem {p1.idade} anos e é mais velho (a) que {p2.nome} que possui {p2.idade} anos");
            }
            else
            {
                Console.WriteLine ($"{p2.nome} tem {p2.idade} anos e é mais velho (a) que {p1.nome} que possui {p1.idade} anos");
            }

        }
    }
}
