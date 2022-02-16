using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] a = { 1, 2, 3, 4 }, b = { 1, 2, 5, 8 };

                a = a.Concat(b).ToArray();

                foreach (var c in a)
                {
                    Console.WriteLine(c);
                }    
                
                Console.ReadLine();
        }
    }
}




