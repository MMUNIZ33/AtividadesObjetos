using System.Globalization;

namespace A1006_SALARIO
{
    class Funcionario
    {
        public string Name;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            SalarioBruto -= Imposto;
            return SalarioBruto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * (porcentagem / 100.0));
        }
        public override string ToString()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            return $"{Name}, $ {SalarioLiquido().ToString("F2", CI)}";
        }
    }
}