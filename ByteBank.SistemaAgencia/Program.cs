using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFim = new DateTime(2022, 2, 4);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFim - dataCorrente;

            Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca));

            Console.ReadLine();
        }
    }
}
