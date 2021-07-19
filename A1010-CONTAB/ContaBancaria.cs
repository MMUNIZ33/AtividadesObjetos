using System.Globalization;
namespace A1010_CONTAB
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Name { get; set; }
        public double Valor { get;  private set; }

        public ContaBancaria(int numero, string name)
        {
            Numero = numero;
            Name = name;
        }
        public ContaBancaria(int numero, string name, double depositoInicial) : this(numero, name)
        {
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia)
        {
            Valor += quantia;
        }
        public void Saque(double quantia)
        {
            Valor -= quantia;
            Valor -= 5.0;
        }

        public override string ToString()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            return ($"Conta: {Numero}, Titular: {Name}, Saldo: $ {Valor.ToString("F2", CI)}");
        }
    }

}