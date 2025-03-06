using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario renan = new Funcionario();
            renan.Nome = "Renan";
            renan.CPF = "426.410.508.03";
            renan.Salario = 2000;

            gerenciador.Registrar(renan);

            Diretor laura = new Diretor();
            laura.Nome = "Laura";
            laura.CPF = "123.456.789.10";
            laura.Salario = 5000;

            Funcionario lauraTeste = laura;        

            Console.WriteLine("Bonificacao de uma referência de Diretor: " + laura.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referência de Funcionario: " + lauraTeste.GetBonificacao());


            gerenciador.Registrar(laura);

            Console.WriteLine(renan.Nome);
            Console.WriteLine(renan.GetBonificacao());

            Console.WriteLine(laura.Nome);
            Console.WriteLine(laura.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}