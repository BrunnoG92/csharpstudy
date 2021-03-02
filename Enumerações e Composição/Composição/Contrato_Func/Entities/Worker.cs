using Contrato_Func.Entities.Enums;
using System.Collections.Generic;

namespace Contrato_Func.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set;}
        public Department Department { get; set; } // Composição. Propriedade do tipo departamento , associação entre duas classes diferentes
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Lista de contratos. Um trabalho tem vários contratos.

        public Worker ()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            // ASSOCIAÇÃO PARA MUITOS NÃO SÃO ADD NO CONSTRUTOR !//

        }
        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
                
            }
            return sum;
        }

    }
}
