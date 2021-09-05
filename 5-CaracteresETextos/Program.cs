using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)77;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = "teste";
            Console.WriteLine(palavra);

            palavra = palavra + 2021;
            Console.WriteLine(palavra);

            Console.ReadLine();
        }
    }
}