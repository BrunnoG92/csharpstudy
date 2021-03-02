using System;
using System.Globalization;
using Contrato_Func.Entities;
using Contrato_Func.Entities.Enums;


namespace Contrato_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLvel/Senior): ");
            WorkerLevel level = Enum.Parse < WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName); // instanciado departamento
            Worker worker = new Worker(name, level, basesalary, dept); // instanciado trabalhador

            Console.Write("How many contracts to this worker ?" );
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valueperhour, hours);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate inome (MM/YYYY)");
            string monthandyear = Console.ReadLine();
            int month = int.Parse(monthandyear.Substring(0, 2)); //recortar 2 posições, para ter o mês 01/2020 
            int year = int.Parse(monthandyear.Substring(3));
            Console.WriteLine("Name: " +  worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthandyear + ":" + worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
