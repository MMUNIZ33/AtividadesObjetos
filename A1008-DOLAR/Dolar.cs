namespace A1008_DOLAR
{
    public class Dolar
    {
        static double Iof = 6.0;

        public static double ConverterDolar(double ValorDolar, double Comprar)
        {
            double total = (ValorDolar * Comprar);
            total += total * Iof / 100.0;
            return total;
        }
    }
}