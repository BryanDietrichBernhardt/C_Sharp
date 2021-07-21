using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Produto
    {


        private string _nome;
        internal double Preco { get; private set; }
        internal int Quantidade { get; private set; }

        public Produto() { } //Construtor Padrão (não recebe valores)
        public Produto(string nome, double preco, int quantidade) //Construtor atribuindo todo os valores obrigatórios
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        /*public Produto(string nome, double preco) //Construtor para atribuir apenas nome e preco obrigatórios
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; //Por padrão inicia com 0, podemos utilizar essa linha caso precise atribuir um valor != 0
        }*/

        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        /*
        public string GetNome() //Método Get
        {
            return _nome;
        }

        public bool SetNome(string nome) //Método Set
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
                return _flag = true;
            }
            else
                return _flag = false;
                
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetPreco(double preco)
        {
            _preco = preco;
        }
        */

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}