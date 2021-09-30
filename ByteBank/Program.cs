using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor terezinha = new Diretor("159.753.398-04");
            terezinha.Nome = "Terezinha";
            terezinha.Senha = "123456";

            sistemaInterno.Logar(terezinha, "123456");
            sistemaInterno.Logar(terezinha, "abc");

            GerenteDeConta maria = new GerenteDeConta("326.985.628-89");
            maria.Nome = "Maria";
            maria.Senha = "123456";

            sistemaInterno.Logar(maria, "123456");
            sistemaInterno.Logar(maria, "abc");
            
            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123456";

            sistemaInterno.Logar(parceiroComercial, "123456");
            sistemaInterno.Logar(parceiroComercial, "abc");
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
