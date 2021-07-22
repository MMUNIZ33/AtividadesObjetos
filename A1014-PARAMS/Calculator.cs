namespace A1014_PARAMS
{
    public class Calculator
    {
        public static int Soma(params int[] numero)
        {
            var soma = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                soma += numero[i];
            }
            return soma;
        }
    }
}