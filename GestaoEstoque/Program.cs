using GestaoEstoque;
using System.Globalization;
using System.Net.Http.Headers;

namespace gestaoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre dados do Produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
           int quantidade = int.Parse(Console.ReadLine());
 

         //   Produto p = new Produto(nome, preco);//Com construtor com inputar valor
      
            Produto p = new Produto(nome,preco, quantidade); // Contrutor sobrecarga

          
            
         
        
          Console.WriteLine("Dados do produto: "+p);
          Console.WriteLine();
          Console.Write("Digita o numero de produtos a ser adicionado: ");
          int qtd = int.Parse(Console.ReadLine());
          p.AdicionarProduto(qtd);
          Console.WriteLine();
          Console.WriteLine("Dados Atualizados : " +p);
          Console.WriteLine();
          Console.Write("Digita o numero de produtos a ser removido: ");
          qtd = int.Parse(Console.ReadLine());
          p.RemoveProduto(qtd);
          Console.WriteLine();
          Console.WriteLine("Dados Atualizados : " + p);
    
          
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        }
    }
}