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
            int[] idades = new int[5] { 15, 28, 35, 50, 28 };

            Console.WriteLine(idades.Average());

            Console.ReadLine();
        }
    }
}
