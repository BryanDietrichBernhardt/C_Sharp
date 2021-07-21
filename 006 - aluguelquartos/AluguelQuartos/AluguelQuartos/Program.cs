using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AluguelQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Rent[] rents = new Rent[10];
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                rents[room] = new Rent { Name = name, Email = email, Room = room };
                Console.WriteLine();
            }

            for (int i = 0; i <= rents.Length - 1; i++)
            {
                if (rents[i] != null)
                {
                    Console.WriteLine("Busy rooms:");
                    Console.WriteLine($"{rents[i]}");
                }
            }
            Console.Read();

        }
    }
}
