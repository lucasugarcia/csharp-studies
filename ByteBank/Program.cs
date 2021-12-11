﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO MÉTODO MAIN");
            }

            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("contas1.txt"))
            { 
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }

        private static void TesteInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 789654123);
                ContaCorrente conta2 = new ContaCorrente(346, 356345346);

                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);

                throw;
            }
        }
    }
}