using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Salario_Func
{
    class Funcionario
    {
        public string Id;
        private string name;
        private double sal;

        public Funcionario(string id_temp, string name_Temp, double sal_temp)
        {
            this.Id = id_temp;
            this.name = name_Temp;
            this.sal = sal_temp;
        }

        public override string ToString()
        {
            return "ID:" + Id
                + "|"
                + "Nome:"+name
                + "|"
                + "Salario: R$" + sal.ToString("F2", CultureInfo.InvariantCulture);
        }

    }




}
