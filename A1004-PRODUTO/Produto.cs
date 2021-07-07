using System;
using System.Globalization;

namespace A1004_PRODUTO
{
    class Produto
    {
        public string name;
        public double preco;
        public int quantidade;

        public double ValorTotalEmStoque()
        {
            return preco * quantidade;
        }

        public override string ToString()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            return name + ", $ " 
            + preco.ToString("F2", CI) + ", " 
            + quantidade + " "
            + "unidades, " + "Total: $ " 
            + ValorTotalEmStoque().ToString("F2", CI);
        }

        public void AdicionarProdutos(int add)
        {
            quantidade += add;
        }

        public void RemoverProdutos(int rmv)
        {
            quantidade -= rmv;
        }
    }
}