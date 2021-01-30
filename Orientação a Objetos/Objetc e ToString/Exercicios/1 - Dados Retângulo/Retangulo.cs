using System;
using System.Globalization;
namespace Dados_Retângulo

{
    public class Retangulo
    {
        public double largura;
        public double altura;
        public double area;
        public double perimetro;
        public double diagonal;

        public double Calculo_Area()
        {
            return largura * altura;

        }
        public double Calculo_Perimetro()
        {
            return 2 * (largura + altura);

        }
        public double Calculo_Diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

        }

        public override string ToString()
        {
            return "Área do Triangulo: "+ Calculo_Area().ToString ("F2",CultureInfo.InvariantCulture) + "\n" + "Perimetro: "+ Calculo_Perimetro().ToString("F2",CultureInfo.InvariantCulture) + "\n" + "Diagonal: " + Calculo_Diagonal ().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}