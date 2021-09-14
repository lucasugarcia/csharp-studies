using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaLucas = new ContaCorrente();
            contaLucas.titular = "Lucas";
            contaLucas.agencia = 863;
            contaLucas.numero = 863452;

            ContaCorrente contaLucasSilva = new ContaCorrente();
            contaLucasSilva.titular = "Lucas";
            contaLucasSilva.agencia = 863;
            contaLucasSilva.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaLucas == contaLucasSilva));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaLucas = contaLucasSilva;
            Console.WriteLine(contaLucas == contaLucasSilva);

            contaLucas.saldo = 300;
            Console.WriteLine(contaLucas.saldo);
            Console.WriteLine(contaLucasSilva.saldo);

            Console.ReadLine();
        }
    }
}
