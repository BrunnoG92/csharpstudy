using System.Globalization;
namespace Exercicio_Resolvido
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;
        public double ValorTotal()
        {
            return Preco * Qtd;
        }

        public void Adiciona_Produto (int qtd_produto)
        {
            Qtd = Qtd + qtd_produto;
        }
        public void Remove_Produto (int qtd_produto)
        {
            Qtd = Qtd - qtd_produto;
        }
        
        public override string ToString()
        {
            return Nome + " R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + "," + Qtd + " unidades , Total R$ " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


