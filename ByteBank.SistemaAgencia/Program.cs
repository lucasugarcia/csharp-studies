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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679754));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));

            ContaCorrente conta = new ContaCorrente(1, 1);

            lista.Adicionar(conta);
            
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            Console.ReadLine();
        }

        private static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[] {
                new ContaCorrente(874, 987654),
                new ContaCorrente(875, 987655),
                new ContaCorrente(873, 987656)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                Console.WriteLine($"Conta {indice} {contas[indice].Numero}");
            }
        }

        private static void TestaArrayInt()
        {
            int[] idades = new int[6] { 15, 28, 35, 50, 28, 60 };

            int acumulador = 0;

            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            Console.WriteLine($"Média das idades: {acumulador / idades.Length}");
        }
    }
}
