using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaLucas = new ContaCorrente();

            contaLucas.titular = "Lucas";
            contaLucas.agencia = 863;
            contaLucas.numero = 863452;
            contaLucas.saldo = 100;

            Console.WriteLine(contaLucas.titular);
            Console.WriteLine("Agência: " + contaLucas.agencia);
            Console.WriteLine("Número: " + contaLucas.numero);
            Console.WriteLine("Saldo: " + contaLucas.saldo);

            Console.ReadLine();
        }
    }
}
