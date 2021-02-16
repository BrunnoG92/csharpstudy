using System;

namespace Func_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";
            string S1 = original.ToUpper(); //CONVERTE PARA MAIUSCULO 
            string S2 = original.ToLower(); // CONVETER PARA MINUSCULO
            string S3 = original.Trim(); // REMOVE ESPAÇOS EM BRANCOS
            string S4 = original.Substring(3); // RECORTAR STRING A PARTI DA POSIÇÃO
            string S5 = original.Substring(3,5); // RECORTAR STRING A PARTI DA POSIÇÃO 3 E CORTA 5 CARACTERES
            string S6 = original.Replace("a", "x"); // TROCA TODO O CARACTER 'a' POR X NA STRING
            string S7 = original.Replace("abc", "xy"); // TROCA TODO O CARACTER 'a' POR X NA STRING


            int N1 = original.IndexOf("bc"); // PRIMEIRA OCORRENCIA DA STRING (COMEÇA COM 0 )
            int N2 = original.LastIndexOf("bc"); //ULTIMA OCORRENCIA DO BC

            bool B1 = String.IsNullOrEmpty(original); // TESTA SE A STRING É NULA / VAZIA
            bool B2 = String.IsNullOrWhiteSpace(original); //TESTA SE A VARIAVEL É NULA OU SOMENTE ESPAÇOS EM BRANCO



            Console.WriteLine("Original: -" + original +"-");
            Console.WriteLine("ToUpper: -" + S1 +"-");
            Console.WriteLine("ToLower: -" + S2 + "-");
            Console.WriteLine("Trim: -" + S3 + "-");
            Console.WriteLine("IndexOf bc: " + N1);
            Console.WriteLine("LastIndexOf bc: " + N2);
            Console.WriteLine("SubString 3: " + S4);
            Console.WriteLine("SubString 3: " + S5);
            Console.WriteLine("Replace 'a'com 'x' : " + S6);
            Console.WriteLine("Replace 'abc'com 'xy' : " + S7);
            Console.WriteLine("IS NULL /EMPTV:" + B1);
            Console.WriteLine("IS NULL /EMPTV:" + B2);




        }
    }
}
