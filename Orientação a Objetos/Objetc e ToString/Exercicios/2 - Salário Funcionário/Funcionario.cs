using System.Globalization;
namespace Salário_Funcionário
{
    public class Funcionario
    {
        public string nome;
        public double salario_base;
        public double imposto;
        public double salario_final;

        public double SalarioLiquido()
        {
            return salario_final = salario_base - imposto;
        }
        public double AumentarSalario(double porcentagem)
        {
            return salario_base = salario_base + (salario_base * porcentagem / 100.0);

        }

        public override string ToString()
        {
            return "Funcionário: " + nome + "," + "R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}