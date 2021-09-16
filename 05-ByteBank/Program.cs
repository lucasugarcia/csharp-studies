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
            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.titular.nome = "Lucas";
            conta.titular.profissao = "Desenvolvedor";
            conta.titular.cpf = "123.321.456-22";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563427;

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.profissao);
            Console.WriteLine(conta.titular.cpf);

            Console.ReadLine();
        }
    }
}
