namespace Pratica
{
    public class Produto
    {
        public string Nome;
        public float Preco;
        public int Qtd;

        public Produto (string nome, float preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;

        }
        public override string ToString()
        {
            return "Produto:" + Nome + "\nPreço:" + Preco + "\nQuantidade:" + Qtd;
        }
    }
}