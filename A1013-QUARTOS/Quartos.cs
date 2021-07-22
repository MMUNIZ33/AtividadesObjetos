namespace A1013_QUARTOS
{
    public class Quartos
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int NumQuarto { get; set; }
        
        public Quartos(string name, string email, int numQuarto)
        {
            Name = name;
            Email = email;
            NumQuarto = numQuarto;
        }
        public override string ToString()
        {
            return (Name + ", " + Email);
        }
    }
}