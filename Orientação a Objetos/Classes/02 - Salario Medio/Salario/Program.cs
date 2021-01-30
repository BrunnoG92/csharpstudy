using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();
            float salario_medio;

            Console.Write("Digite o nome do funcionário: ");
            func1.nome = Console.ReadLine();
            Console.Write($"Digite o salário de {func1.nome}: R$ ");
            func1.salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o nome do funcionário: ");
            func2.nome = Console.ReadLine();
            Console.Write($"Digite o salário de {func2.nome}: R$ ");
            func2.salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario_medio = ((func1.salario + func2.salario)/2);
            Console.WriteLine ($"O salário médio é : R$ {salario_medio}");
            
        }
    }
}
