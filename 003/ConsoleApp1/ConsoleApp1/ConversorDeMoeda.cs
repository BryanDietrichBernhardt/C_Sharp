using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConversorDeMoeda
    {
        public static double cotacaoDolar = 3.10;
        private static double iof = 0.06;
        public static double valorComprar;

        public static double Converte()
        {
            return (((valorComprar * cotacaoDolar) * iof) + (valorComprar * cotacaoDolar));
        }
    }
}
