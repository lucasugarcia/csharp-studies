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

            Console.ReadLine();
        }
    }
}
