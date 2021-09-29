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
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor terezinha = new Diretor("159.753.398-04");
            terezinha.Nome = "Terezinha";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta maria = new GerenteDeConta("326.985.628-89");
            maria.Nome = "Maria";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(terezinha);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(maria);

            Console.WriteLine(gerenciador.GetTotalBonificacao());
        }
    }
}
