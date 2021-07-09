using System;
using System.Globalization;

namespace A1004_PRODUTO
{
    class Produto
    {
        public string Name;
        public double Preco;
        public int Quantidade;
        public Produto(string name, double preco, int quantidade)
        {
            Name = name;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmStoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            return Name + ", $ " 
            + Preco.ToString("F2", CI) + ", " 
            + Quantidade + " "
            + "unidades, " + "Total: $ " 
            + ValorTotalEmStoque().ToString("F2", CI);
        }

        public void AdicionarProdutos(int add)
        {
            Quantidade += add;
        }

        public void RemoverProdutos(int rmv)
        {
            Quantidade -= rmv;
        }
    }
}