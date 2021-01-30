namespace Pratica
{
    public class Produto
    {
        private string _nome; // usar underline no nome da variavel privada //
        private float _preco;
        private int _qtd;

        public Produto()
        {

        }
        public Produto(string nome ,float preco, int qtd)
        {
            _nome = "TV";
            _preco = preco;
            _qtd = qtd;

        }
       
        public string GetNome()
        { // Função para retornar o nome do produto, não é possivel acessar mais o nome diretamente //
            return _nome;
        }
        
        
        public void SetNome(string nome) // funçao para alterar o nome do produto
        {   // se o nome não for nulo e tamanho dele for maior que um 
            if (nome != null && nome.Length > 1)
            {   
                _nome = nome;
            }
            else
            {
                _nome = ("Nome digitado menor que 1");
            }

            // função para alterar o nome do produto diretamente
        }


        /* public override string ToString()
         {
             return "Produto:" + _nome + "\nPreço:" + _preco + "\nQuantidade:" + _qtd;
         } 
         */
    }
}