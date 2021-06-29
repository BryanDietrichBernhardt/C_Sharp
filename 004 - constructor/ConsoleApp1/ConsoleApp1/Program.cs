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
            Produto p = new Produto("TV", 500, 10);
            while (true)
            {
                Console.Clear();

                Console.Write("Produto: ");
                Console.WriteLine(p);
                Console.Write("GetName: ");
                Console.WriteLine(p.Nome);

                Console.Write("SetName: ");
                p.Nome = Console.ReadLine();
                //p.Preco = 5;

                Console.Write("Produto att: ");
                Console.WriteLine(p);
                Console.Write("GetName att: ");
                Console.WriteLine(p.Nome);

                Console.ReadLine();
            }

            /*
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco);
            Console.WriteLine($"Dados do produto: {p}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {p}");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {p}");
            Console.ReadLine();
            */
        }
    }
}
