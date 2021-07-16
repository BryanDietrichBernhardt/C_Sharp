using System;
using System.Globalization;
using ExercicioComposicao.Entities;
using ExercicioComposicao.Entities.Enums;

namespace ExercicioComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine()); //convert string to WorkerLevel
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Department deptartament = new Department(deptName); //create departament
            Worker worker = new Worker(name, level, baseSalary, deptartament); //create worker
            
            Console.Write("How many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());
            for(int i = 1; i <= numberOfContracts; i++)
            {
                Console.WriteLine($"\nEnter #{i} contract data:");
                Console.Write("Date (DD/MM/YY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(dateContract, valuePerHour, duration); //create contract
                worker.AddContract(contract); //add created contract to worker
            }

            Console.Write("\nEnter mouth and year to calculate income (MM/YYYY): ");
            string mouthAndYear = Console.ReadLine();
            int mouth = int.Parse(mouthAndYear.Substring(0, 2));
            int year = int.Parse(mouthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}"); //show worker name
            Console.WriteLine($"Department: {worker.Department.Name}"); //show department name
            Console.WriteLine($"Income for {mouthAndYear}: {worker.Income(year, mouth).ToString("F2", CultureInfo.InvariantCulture)}"); //show income for the date
        }
    }
}
