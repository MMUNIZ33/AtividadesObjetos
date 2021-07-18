using System.Globalization;
namespace A1010_CONTAB
{
    class ContaBancaria
    {
        public int Numero;
        public string Name;
        public double Valor;
        public ContaBancaria(int numero, string name)
        {
            Numero = numero;
            Name = name;
        }
        public ContaBancaria(int numero, string name, double valor) : this(numero, name)
        {
            Valor = valor;
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
            return ($"Conta: {Numero}, Titular: {Name}, Saldo: $ {Valor}");
        }
    }

}