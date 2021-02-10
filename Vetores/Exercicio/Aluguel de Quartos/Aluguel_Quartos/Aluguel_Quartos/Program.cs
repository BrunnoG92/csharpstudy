using System;

namespace Aluguel_Quartos
{

    class Program

    {
        static void Main(string[] args)
        {

            Aluga();
        }
        static void Aluga()
        {
            string Name_temp;
            string Email_temp;
            int N_quarto_temp;
            Quartos_Aluguel[] Vetor_Aluga = new Quartos_Aluguel[10]; //QUARTOS PARA ALUGAR //
            Console.Write("Quantidade de quartos alugados: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                Console.Write("Nome: ");
                Name_temp = Console.ReadLine();
                Console.Write("Email: ");
                Email_temp = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                N_quarto_temp = int.Parse(Console.ReadLine());
                if (Vetor_Aluga[i] == null)
                {
                    Vetor_Aluga[i] = new Quartos_Aluguel { N_Quarto = N_quarto_temp, Nome = Name_temp, Email = Email_temp, };

                }
                if (Vetor_Aluga[i] != null)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (Vetor_Aluga[i ].N_Quarto == N_quarto_temp)
                        {
                            do
                            {
                                Console.Write("Esse quarto já está alugado. Escolha outro quarto: ");
                                N_quarto_temp = int.Parse(Console.ReadLine());
                                if (N_quarto_temp == Vetor_Aluga[i].N_Quarto)
                                {
                                    i -= 1;
                                }
                            } while (N_quarto_temp == Vetor_Aluga[i].N_Quarto);

                        }
                        if (Vetor_Aluga[i].N_Quarto != N_quarto_temp)
                        {
                            Vetor_Aluga[i] = new Quartos_Aluguel { N_Quarto = N_quarto_temp, Nome = Name_temp, Email = Email_temp};
                        }
                    }
                }




            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Quartos Alugados: " + N);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Quarto: " + Vetor_Aluga[i].N_Quarto);
                Console.WriteLine("Nome: " + Vetor_Aluga[i].Nome);
                Console.WriteLine("Email: " + Vetor_Aluga[i].Email);
                Console.WriteLine("-------------------------");




            }




        }




    }
}


