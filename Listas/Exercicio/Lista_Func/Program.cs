using System;
using System.Collections.Generic;
using System.Linq;

namespace Salario_Func
{
    class Program
     
    {
      
        static void Main(string[] args)
        {
            List<Funcionario> Lista_Func = new List<Funcionario>();
            Console.Write("Funcionários para cadastrar: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            { 
                Console.Write("Nome do funcionário " + (i) + ":");
                string Name_Temp = Console.ReadLine();
                Console.Write("Salário do funcionário: " + (i) + ":R$");
                double Sal = double.Parse(Console.ReadLine());
                Console.Write("ID do funcionário " + (i) + ": ");
                string Id_temp = Console.ReadLine();

                if (Lista_Func.Count == 0)                       //Se a lista estiver vazia, não necessita validação, realiza a inserção direta
                {

                    Lista_Func.Add(new Funcionario(Id_temp, Name_Temp, Sal));
                }

               else if   (Lista_Func.Any(x => x.Id == Id_temp) == true){ //se id duplicado foi encontrado, não permito a inserção
                   
                    do
                    {
                        
                        Console.Write("Esse ID já está em uso.Digite outro: ");
                        Id_temp = Console.ReadLine();
                       
                    } while (Lista_Func.Any(x => x.Id == Id_temp) == true);
                    if (Lista_Func.Any(x => x.Id == Id_temp) != true) // se item duplicado não foi encontrado, faça a inserção 
                    {

                        Lista_Func.Add(new Funcionario(Id_temp, Name_Temp, Sal));

                    }
                }
                if (Lista_Func.Any(x => x.Id == Id_temp) != true) // se item duplicado não foi encontrado, faça a inserção 
                {

                    Lista_Func.Add(new Funcionario(Id_temp, Name_Temp, Sal));

                }

            }
            Console.WriteLine("Lista de funcionários");
            foreach (Funcionario ListaDeFuncionario in Lista_Func)
            {
                Console.WriteLine (ListaDeFuncionario);
            }

        }

    }
}
