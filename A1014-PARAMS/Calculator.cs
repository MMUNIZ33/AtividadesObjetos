namespace A1014_PARAMS
{
    public class Calculator
    {
        // // ref e out são considerados "code smells" (design ruim). É bom evitar usá-los.
        // // return é mais indicado.
        // public static void Triple(int x, out int y)
        // {
        //     y = x * 3;
        // }
        
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