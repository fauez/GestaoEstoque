using GestaoEstoque;
using System.Globalization;

namespace gestaoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre dados do Produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture   );
           
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
            Console.WriteLine();
        }
    }
}