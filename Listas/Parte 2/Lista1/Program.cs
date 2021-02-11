using System;
using System.Collections.Generic;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();
            Lista.Add("Maria"); //0 ADD -> ADICIONA AO FINAL DA LISTA
            Lista.Add("Alex"); //1
            Lista.Add("Ana"); //2
            Lista.Add("Bruno"); //3
            Lista.Add("Joao");
            Lista.Add("Gabriel");

            Lista.Insert(1, "Marcio"); // INSERT -> VOCÊ DEFINE EM QUE POSIÇÃO SALVAR 



            foreach (string nomes in Lista)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("Tamanho da lista: " + Lista.Count); // COUNT -> TAMANHO DA LISTA 

            string S1 = Lista.Find(x => x[0] == 'A'); // ENCONTRA NA LISTA PRIMEIRO NOME COMEÇADO COM A. LAMBDA => , X[0] indica o primeiro caracter
            Console.WriteLine("O primeiro nome com A é: " + S1);

            string S2 = Lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("O ultimo nome começado com A é: " + S2); // ENCONTRA NA LISTA ULTIMO NOME COMEÇADO COM A. LAMBDA => , X[0] indica o primeiro caracter
            int Pos1 = Lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do primeiro nome com a letra A: " + Pos1); // ENCONTRA NA LISTA  A POSIÇÃO DO PRIMEIRO NOME COMEÇADO COM A. LAMBDA => , X[0] indica o primeiro caracter
            int Pos2 = Lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do ultimo nome com a letra A: " + Pos2);// ENCONTRA NA LISTA A POSIÇÃO DO ULTIMO NOME COMEÇADO COM A. LAMBDA => , X[0] indica o primeiro caracter
            Console.WriteLine("==================================");

            List<string> Lista2 = Lista.FindAll(x => x.Length == 5); // ENCONTRAR ITEM NA LISTA COM A CONDIÇÃO DESEJADA, NESSE CASO QUE TENHA 5 CARACTERES
           foreach (string Nomes2 in Lista2)
            {
                Console.WriteLine("Nomes com 5 caracteres: " + Nomes2);
            }
            Console.WriteLine("==================================");
            Lista.Remove("Bruno"); // REMOVER UM ITEM DA LISTA 
            foreach (string Nomes in Lista)
            {
                Console.WriteLine(Nomes);
            }
            Console.WriteLine("==================================");
            Lista.RemoveAll(x => x[0] == 'M'); // REMOVE TODOS OS ITENS NA CONDIÇÃO DE NOME COMEÇAR COM M 
            foreach (string Nomes in Lista)
            {
                Console.WriteLine(Nomes);
            }
            Console.WriteLine("==================================");
            Lista.RemoveAt(1); // REMOVER ITEN NA POSIÇÃO
            foreach (string Nomes in Lista)
            {
                Console.WriteLine(Nomes);
            }

            Console.WriteLine("==================================");
            Lista.RemoveRange(2, 2); // REMOVER A PARTI DA POSIÇÃO X , N ELEMENTOS. AQUI REMOVE A PARTI DA POSIÇÃO 2 , 2 NOMES

            foreach (string Nomes in Lista)
            {
                Console.WriteLine(Nomes);
            }
        }
    }
}
