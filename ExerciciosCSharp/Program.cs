using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira o ID do produto:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nInsira o NOME do produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("\n\nInsira o PREÇO do produto:");
            string preco = Console.ReadLine();

            Console.WriteLine("\n\nInsira a DESCRIÇÃO do produto:");
            string descricao = Console.ReadLine();

            Console.WriteLine("\n\nInsira a QUANTIDADE do produto:");
            int qtd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nInsira o O ANO DE VENCIMENTO do produto:");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nInsira o O MÊS DE VENCIMENTO do produto:");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nInsira o O DIA DE VENCIMENTO do produto:");
            int dia = Convert.ToInt32(Console.ReadLine());


            Produto prod = new Produto(id, nome, decimal.Parse(preco), descricao, qtd, new DateTime(ano,mes,dia));
            Console.Write(prod);
            Console.Read();

        }
    }

    class Produto
    {
        private int id;
        private string nome;
        private decimal valor;
        private string descricao;
        private int quantidade;
        private DateTime dataValidade;

        public Produto(int id, string nome, decimal valor, string descricao, int quantidade, DateTime dataValidade) 
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.dataValidade = dataValidade;

        }

        override public string ToString()
        {
            return $"Id: {this.id} - Nome: {this.nome} - Valor: {this.valor} - Descrição: {this.descricao} - Quantidade: {this.quantidade} - Data de validade: {this.dataValidade}";
        }
    }

}
