using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interseccao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 3, 4}, b = {1, 2, 5, 8};

            for (int i = 0; i <= 3; i++)
            {
                if(a[i] == b[i])
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
