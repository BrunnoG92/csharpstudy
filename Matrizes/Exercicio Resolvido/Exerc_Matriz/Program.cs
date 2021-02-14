using System;

namespace Exerc_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ordem da matriz: ");
            int N = int.Parse(Console.ReadLine());
            int[,] Matriz = new int[N,N];
            for (int i =0; i < N; i++)
            {
                Console.Write("Insira a " + (i + 1) + "º linha: ");
                string[] Valores = Console.ReadLine().Split(' ');
                for (int j =0; j < N; j++)
                {
                    
                    Matriz[i, j] = int.Parse(Valores[j]);
                   
                }
            }
            Console.Write("Diagonal Principal: ");
            for (int i =0; i < N; i++)
            {
                Console.Write(Matriz[i,i] + " ");
            }
            int count = 0;
            for (int i =0; i < N; i++)
            {
                for (int j =0; j <N; j++)
                {
                    if (Matriz [i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Essa matriz possui " + count + " numeros negativos");
           
        }
    }
}

/* FAÇA UM PROGRAMA PARA LER UM NUMERO INTEIRO N E UMA MATRIZ DE ORDEM N (MATRIZ QUADRADA, MESMO N DE COLULA E LINHA) . EM SEGUTIDA MOSTRAR A DIAGNONAL PRINCIPAL
E A QUANTIDADE DE VALORES NEGATIVOS DA MATRIZ */