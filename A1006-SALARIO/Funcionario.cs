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
    }
}