using System.Globalization;

namespace E1002_EMPLY
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void AlterarSalary(double porcentagem)
        {
            Salary += Salary * porcentagem / 100.0;
        }

        public override string ToString()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            return ($"{Id}, {Name}, {Salary.ToString("F2", CI)}");
        }
    }
}