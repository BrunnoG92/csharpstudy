using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length); // tamanho da matriz 
            Console.WriteLine(mat.Rank); // quantas linhas //
            Console.WriteLine(mat.GetLength(0)); // dimensão zero tem tamanho 2 (quantidade de linhas )
            Console.WriteLine(mat.GetLength(1)); //dimensão 1 tem tamanho 3 (Quantidade de colunas )
        }
    }
}
