using System;

namespace Dados_Retângulo
{
    class Dados_Retângulo
    {
        static void Main(string[] args)
        {
            Retangulo dados = new Retangulo();
            Console.Write("Base do Retângulo: ");
            dados.largura = double.Parse (Console.ReadLine());
            Console.Write ("Altura do Retângulo: ");
            dados.altura = double.Parse (Console.ReadLine ());
            dados.Calculo_Area ();
            dados.Calculo_Diagonal ();
            dados.Calculo_Perimetro ();
            Console.WriteLine ("Dados do retângulo: " + dados);
        }
    }
}
