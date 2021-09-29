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

            Funcionario lucas = new Funcionario(2000, "456123789-89");
            lucas.Nome = "Lucas";

            lucas.AumentarSalario();
            Console.WriteLine("Novo salário: " + lucas.Salario);

            gerenciador.Registrar(lucas);

            Diretor joao = new Diretor("456123789-89");
            joao.Nome = "João";

            joao.AumentarSalario();
            Console.WriteLine("Novo salário: " + joao.Salario);

            gerenciador.Registrar(joao);

            Console.ReadLine();
        }
    }
}
