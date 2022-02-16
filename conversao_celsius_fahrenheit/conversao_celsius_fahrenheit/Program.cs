using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao_celsius_fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempc, tempf;

            Console.WriteLine("Digite a temperatura em C: ");
            tempc = Convert.ToDouble(Console.ReadLine());

            tempf = ((tempc/5) * 9) + 32;

            Console.WriteLine("Está "+ tempf + " graus Fahrenheit!");

            Console.ReadLine();
        }
    }
}
