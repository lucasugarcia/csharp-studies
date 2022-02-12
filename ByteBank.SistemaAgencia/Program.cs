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
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(1);
            idades.Adicionar(2);
            idades.Adicionar(3);

            Console.ReadLine();
        }

        private static void TestaListaDeContaCorrente()
        {
            Lista<ContaCorrente> lista = new Lista<ContaCorrente>();

            lista.AdicionarVarios(new ContaCorrente(222, 1234), new ContaCorrente(222, 1234));

            ContaCorrente conta = new ContaCorrente(1, 1);
            ContaCorrente[] contas = new ContaCorrente[]
            {
                conta,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
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
