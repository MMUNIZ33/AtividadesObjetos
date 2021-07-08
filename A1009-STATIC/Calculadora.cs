namespace A1009_STATIC
{
    public class Calculadora
    {
        static double Pi = 3.14;
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}