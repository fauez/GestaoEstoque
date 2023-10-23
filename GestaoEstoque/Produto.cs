using System;
using System.Globalization;

namespace GestaoEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade +=  quantidade;
        }

        public void RemoveProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + " R$ "
                + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + " , "
                + Quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)
                ;

        }
    }
}
