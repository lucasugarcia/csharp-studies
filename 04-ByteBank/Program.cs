using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaLucas = new ContaCorrente();
            contaLucas.titular = "Lucas";

            Console.WriteLine("Saldo: " + contaLucas.saldo);
            
            bool retornoDoSaque = contaLucas.Sacar(50);

            Console.WriteLine("Saldo: " + contaLucas.saldo);

            contaLucas.Depositar(500);


            ContaCorrente contaJoao = new ContaCorrente();
            contaLucas.titular = "João";

            Console.WriteLine("Saldo Lucas: " + contaLucas.saldo);
            Console.WriteLine("Saldo João: " + contaJoao.saldo);

            bool resultadoTransferencia = contaLucas.Transferir(100, contaJoao);

            Console.WriteLine("Saldo Lucas: " + contaLucas.saldo);
            Console.WriteLine("Saldo João: " + contaJoao.saldo);

            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
