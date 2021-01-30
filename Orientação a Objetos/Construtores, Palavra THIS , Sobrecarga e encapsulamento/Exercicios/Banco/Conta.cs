using System.Globalization;
namespace Banco
{
    public class Conta                          // OBJETO CONTA BANCARIA //
    {
        public string Nome { get; set; }         // ATRIBUTOS DO OBJETO CONTA //
        public int Numero_conta { get; private set; } // AUTO PROPETIE //
        public float Saldo { get; private set; }
        public Conta(int numero, string titular)                    // CONSTRUTOR DA CONTA BANCARIA //
        {
            Numero_conta = numero;
            Nome = titular;
        }
        public Conta(int numero, string titular, float saldo) : this(numero, titular)
        {
            Saldo = saldo;      // SOBRECARGA DO CONSTRUTOR //
        }
        public void Deposito(float Valor)
        {
            Saldo = Saldo + Valor;             // METODO PARA DEPOSITO //
        }
        public void Saque(float Valor)
        {
            Saldo = (Saldo - (Valor + 5));        // METODO PARA SAQUE //
        }
        public override string ToString()
        {
            return "Conta: "
            + Numero_conta + ", Titular: "
            + Nome + ", Saldo: R$ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}