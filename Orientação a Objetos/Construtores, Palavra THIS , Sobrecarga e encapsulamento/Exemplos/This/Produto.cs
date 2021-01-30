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
        public Produto( int qtd) 
        {
          
            Qtd =10;

        }
 /* SOBRECARGA , DOIS CONSTRUTORES COM MESMO NOME. UM COM A QTD PRE DETERMINADA */
        public Produto(string nome, float preco) : this ()  
       
        {
            Nome = nome;
            Preco = preco;
           
        } 
        // uso do THIS para puxar a QTD no contrutor anterior //

        public Produto (string nome, float preco, int qtd) : this (nome,preco)
        {
            Qtd = qtd;
            // uso do :this , puxando o nome e o preço do construtor anterior //
        }
        public override string ToString()
        {
            return "Produto:" + Nome + "\nPreço:" + Preco + "\nQuantidade:" + Qtd;
        }
    }
}