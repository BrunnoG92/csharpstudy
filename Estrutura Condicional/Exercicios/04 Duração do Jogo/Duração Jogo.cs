using System;

namespace _04_Duração_do_Jogo
{
    class Duração_Jogo
    {
        static void Main(string[] args)
        {
            Console.Write("Hora de inicio do jogo: ");
            int hora_inicio = int.Parse(Console.ReadLine());
            Console.Write("Hora de termino do jogo: ");
            int hora_fim = int.Parse(Console.ReadLine());
            int duracao;
            if (hora_inicio < hora_fim)
            {
                duracao = hora_fim - hora_inicio;
            }
            else
            {
                duracao = 24 - hora_inicio + hora_fim;
            }
            Console.WriteLine($"O jogo durou {duracao} horas ");
        }
    }
}
