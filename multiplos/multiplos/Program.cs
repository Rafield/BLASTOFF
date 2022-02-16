using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, r, d;

            Console.WriteLine("Digite o primeiro número: ");
            a= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            b = Convert.ToDouble(Console.ReadLine());

            if(a < b)
            {
                d = a;
                a = b;
                b = d;
            }

            r = a % b;

            if(r == 0)
            {
                Console.WriteLine("São multiplos!");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }

            Console.ReadLine();
        }
    }
}
