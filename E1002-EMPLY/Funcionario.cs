namespace E1002_EMPLY
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary {get; set private; }

        public Funcionario(int id, string name, double Salary)
        {
            
        }
    }
}