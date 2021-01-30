namespace Pratica
{
    public class Produto
    {
        public string Nome;
        public float Preco;
        public int Qtd;

        public Produto()
        {
            
        }
        public Produto(string nome, float preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;

        }
        public Produto(string nome, float preco)  // SOBRECARGA , DOIS CONSTRUTORES COM MESMO NOME. UM COM A QTD PRE DETERMINADA
        {
            Nome = nome;
            Preco = preco;
            Qtd = 10;
        }
        public override string ToString()
        {
            return "Produto:" + Nome + "\nPreço:" + Preco + "\nQuantidade:" + Qtd;
        }
    }
}