namespace Pratica
{
    public class Produto
    {
        private string _nome; // usar underline no nome da variavel privada //
        public float Preco { get ; private set;} // AUTO PROPETIE, JA DECLARO AQUI A PROPETIE, POSSO USAR O GET MAS NAO O SET NO PRECO (O PRECO PODE SER LIDO MAS NAO ALTERADO)
        private int _qtd;
    

        public Produto()
        {

        }
        public Produto(string nome, float preco, int qtd)
        {
            _nome = "TV";
            Preco = preco;
            _qtd = qtd;

        }

        public string Nome  // criando uma propetie. PULBIC + TIPO NOMEDAVARIAVEL  abre chaves , nao parentese //
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    _nome = ("Nome digitado menor que 1");
                }
            }
        }




        /* public override string ToString()
         {
             return "Produto:" + _nome + "\nPreço:" + _preco + "\nQuantidade:" + _qtd;
         } 
         */
    }
}