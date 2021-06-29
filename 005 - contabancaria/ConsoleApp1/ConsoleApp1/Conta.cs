using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial) :this(numero, titular)
        {
            Deposita(depositoInicial);
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void Saca(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
