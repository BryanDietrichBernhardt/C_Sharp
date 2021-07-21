using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto first = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            first.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            first.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            first.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do produto: {first}");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            first.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {first}");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            first.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {first}");
            Console.ReadLine();
        }
    }
}
