using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente titular = new Cliente();
            titular.nome = "Lucas";
            titular.profissao = "Desenvolvedor";
            titular.cpf = "12332145622";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = titular;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563427;

            Console.WriteLine(titular.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
