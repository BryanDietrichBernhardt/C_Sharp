using System;
using ExercicioComposicao.Entities.Enums;
using ExercicioComposicao.Entities;

namespace ExercicioComposicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public void AddContract(HourContract contract)
        {

        }
        public void RemoveContract(HourContract contract)
        {

        }
        public double Income(int year, int mouth)
        {
            return 2.0;
        }
    }
}
