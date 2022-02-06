using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            object conta = new ContaCorrente(456, 687876);

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado " + contaToString);
            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}
