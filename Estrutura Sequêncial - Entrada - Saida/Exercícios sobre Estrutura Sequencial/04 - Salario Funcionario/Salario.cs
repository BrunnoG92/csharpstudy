using System;
using System.Globalization;

namespace _04___Salario_Funcionario
{
    class Salario
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write ("Digite o valor recebido por hora: ");
            float valor = float.Parse (Console.ReadLine());
            Console.Write ("Total de horas trabalhadas: ");
            float horas_trabalhadas = float.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            float salario = valor*horas_trabalhadas;
            Console.WriteLine (nome + " Trabalhou "+ horas_trabalhadas + " horas e ira receber o valor de R$"+ salario.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
