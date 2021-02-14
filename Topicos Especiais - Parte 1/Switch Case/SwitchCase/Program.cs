using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int N;

            do
            {
                Console.Write("Digite um número: ");
                N = int.Parse(Console.ReadLine());
                string day;
                switch (N)
                {
                    case 1:
                        day = "Domingo";
                        break;
                    case 2:
                        day = "Segunda";
                        break;
                    case 3:
                        day = "Terça";
                        break;
                    case 4:
                        day = "Quarta";
                        break;
                    case 5:
                        day = "Quinta";
                        break;
                    case 6:
                        day = "Sexta";
                        break;
                    case 7:
                        day = "Sábado";
                        break;
                    default:
                        day = "valor invalido";
                        break;
                }
                Console.WriteLine("Dia da semana: " + day);
            } while (N < 8);


        }

        
        
    }
}
