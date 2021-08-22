using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;

            idade = 10;
            Console.WriteLine(idade);

            idade = 13 + 11;
            Console.WriteLine(idade);

            idade = 4 + 4 * 2;
            Console.WriteLine(idade);

            idade = (4 + 4) * 2;
            Console.WriteLine(idade);
            Console.WriteLine("Sua idade é" + idade + "!");

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
