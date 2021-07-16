using ExercicioComposicao.Entities.Enums;
using System.Collections.Generic;

namespace ExercicioComposicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) //Add Worker contract
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract) //Remove Worker contract
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int mouth) //Add Worker income
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mouth)
                    sum += contract.TotalValue();
            }
            return sum;
        }
    }
}
