﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.nome = "Lucas";
            cliente.cpf = "123.963.987-45";
            cliente.profissao = "Desenvolvedor";

            conta.Titular = cliente;

            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.nome);

            Console.ReadLine();
        }
    }
}
