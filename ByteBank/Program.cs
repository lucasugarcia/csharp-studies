using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario lucas = new Funcionario("456123789-89");
            lucas.Nome = "Lucas";
            lucas.Salario = 2000;

            gerenciador.Registrar(lucas);

            Console.WriteLine(lucas.Nome);
            Console.WriteLine(lucas.GetBonificacao());

            Diretor joao = new Diretor("456123789-89");
            joao.Nome = "João";
            joao.Salario = 5000;

            gerenciador.Registrar(joao);

            Console.WriteLine(joao.Nome);
            Console.WriteLine(joao.GetBonificacao());

            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
