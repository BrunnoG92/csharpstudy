using System;

namespace Exercicio1_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a dimensão da matriz ");
            string[] line = Console.ReadLine().Split(' ');
           
            int l = int.Parse(line[0]);
            int c = int.Parse(line[1]);

            int[,] Matriz = new int[l, c];
           
            for (int i = 0; i <l; i++)
            {
                
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j <c; j++)
                {
                    Matriz[i, j] = int.Parse(valores [j]);
                }
            }
            Console.WriteLine("Digite um número da matriz: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (Matriz[i, j] == x)
                    {
                        Console.WriteLine("");

                        Console.WriteLine("Número encontrado na posição: " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Numero a esquerda: " + Matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Número acima: " + Matriz[i - 1, j]);
                        }
                        if (j < c - 1)
                        {
                            Console.WriteLine("Número a direita: " + Matriz[i, j + 1]);
                        }
                        if (i < l - 1)
                        {
                            Console.WriteLine("Número abaixo: " + Matriz[i + 1, j]);

                        }
                    }
                    
                }
            }
        }
    }
}

/* FAÇA UM PROGRAMA PAR LER DOIS NUMEROS INTEIROS M E N , DEPOIS LER UMA MATRIZ M X N , CONTENDO NUMEROS INTEIROS
 * PODENDO HAVER REPETIÇÕES. EM SEGUIDA LER UM NUMERO INTEIRO X QUE PERTENCE A MATRIZ. PARA CADA OCORRENCIA DE X , MOSTRAR OS VALORES
 * À EQUERDA, ACIMA , À DIREITA E ABAIXO DE X, QUANDO HOUVEREM */