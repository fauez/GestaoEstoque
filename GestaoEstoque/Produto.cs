using System;
using System.Globalization;

namespace GestaoEstoque
{
    internal class Produto
    {

        private string _nome;
        public double Preco { get;  set; }
        public int Quantidade { get;  set; }

        public Produto() 
        { 
        
        } // Aqui criamos um novo construtor chamada de sobre cargas, podento estacinar sem inptar valor


        public Produto(string nome, double preco, int quantidade) 
         {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
         }
      
        public string Nome
        {
            get { return _nome; }
            set { 
                if(value != null && value.Length > 1) 
                { 
                _nome = value;
                }
            }
        }
       
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
