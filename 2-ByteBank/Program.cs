﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Lucas";

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
