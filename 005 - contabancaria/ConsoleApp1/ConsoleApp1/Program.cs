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
            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char confirma = char.Parse(Console.ReadLine());

            if(confirma == 's' || confirma == 'S')
            {
                Console.Write("Entre um valor para depósito inicial: ");
                double depositoConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, titularConta, depositoConta);
            }else
            {
                conta = new Conta(numeroConta, titularConta);
            }

            Console.Clear();
            Console.WriteLine($"Dados da conta:\n{conta}");

            Console.Write("Entre um valor para depósito: ");
            conta.Deposita(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Clear();
            Console.WriteLine($"Dados da conta:\n{conta}");

            Console.Write("Entre uma valor para saque: ");
            conta.Saca(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Clear();
            Console.WriteLine($"Dados da conta:\n{conta}");
        }
    }
}
