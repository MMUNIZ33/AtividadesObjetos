using System.Globalization;

namespace A1004_PRODUTO
{
    class Produto
    {
        // get = receber
        // set = definir/alterar
        private string _name;
        public double Preco { get; private set; }        
        public int Quantidade { get; private set; }
        
        public Produto()
        {

        }
        public Produto(string name, double preco, int quantidade)
        {
            _name = name;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value != null && value.Length > 1) 
            {
                _name = value;
            }
            }
        }
        // public string GetName()
        // {
        //     return _name;
        // }
        // public double Preco
        // {
        //     get { return Preco; }
        //     // set { Preco = value; }
        // }
        // public double GetPreco()
        // {
        //     return Preco;
        // }
        // public int Quantidade
        // {
        //     get { return Quantidade; }
        //     // set { Quantidade = value; }
        // }
        // public int GetQuantidade()
        // {
        //     return Quantidade;
        // }
        // public void SetName(string name)
        // {
        //     if (name != null && name.Length > 0) 
        //     {
        //         _name = name;
        //     }
        // }

        public double ValorTotalEmStoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            return _name + ", $ " 
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