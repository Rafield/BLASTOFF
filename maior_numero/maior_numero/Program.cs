using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            double maior;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                maior = n1;
            }
            else
            {
                maior = n2;
            }
            if (maior < n3)
            {
                maior = n3;
            }

            Console.WriteLine("O maior número é " + maior);

            Console.ReadLine();
        }
    }
}
