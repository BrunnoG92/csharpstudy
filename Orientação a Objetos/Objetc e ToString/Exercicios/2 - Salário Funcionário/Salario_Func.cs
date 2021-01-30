using System;
using System.Globalization;

namespace Salário_Funcionário
{
    class Salario_Funcionario
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario ();
            Console.Write ("Digite o nome do funcionário: ");
            func.nome =  Console.ReadLine ();
            Console.Write ("Digite o salário do funcionário: R$");
            func.salario_base = double.Parse (Console.ReadLine ());
            Console.Write ("Informe o valor do imposto: R$");
            func.imposto = double.Parse (Console.ReadLine ());
            Console.WriteLine ( func);
            Console.Write ("Informe a porcentagem de aumento do salário: ");
            double porcento = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario (porcento);
            Console.WriteLine ();
            Console.WriteLine ("Dados atualizados: " + func);
        }
    }
}
