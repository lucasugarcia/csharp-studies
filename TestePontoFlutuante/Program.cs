using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.70;

            Console.WriteLine(salario);

            Console.WriteLine("Meu salario é " + salario);

            /*não compila
            int valor = 12.5;*/

            /*não compila
            int valor2 = 0.0;*/

            double teste = 125.50;

            /*não compila
            int valor3 = teste;*/

            int divisao = 5 / 2;
            Console.WriteLine(divisao);

            double divisao2 = 5.0 / 2;
            Console.WriteLine(divisao2);

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            Console.ReadLine();
        }
    }
}
