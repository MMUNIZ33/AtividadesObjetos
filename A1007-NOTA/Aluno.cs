using System;

namespace A1007_NOTA
{
    class Aluno
    {
        public string Name;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public void Aprovaçao()
        {
            string result;
            if (NotaFinal() >= 60)
            {
                result = "APROVADO";
                Console.WriteLine(result);
                Console.WriteLine();
            }
            else
            {
                double resto = 60 - NotaFinal();
                result = "REPROVADO";
                Console.WriteLine(result);
                System.Console.WriteLine($"FALTARAM {resto} PONTOS");
                Console.WriteLine();
            }
        }
    }
}