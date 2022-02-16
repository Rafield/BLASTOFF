using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, fatorial;

            Console.WriteLine("Digite o número que deseja calcular o fatorial!");
            a = Convert.ToInt32(Console.ReadLine());

            fatorial = a;
            for (int i = a - 1; i >= 1; i--)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine("O fatorial de "+ a + " é " +fatorial);

            Console.ReadLine();

        }
    }

}
    

