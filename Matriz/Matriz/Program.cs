using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2,5];

            Console.WriteLine("Digite os valores: ");

                for (int i = 0; i <= 1; i++)
                {                
                    for (int z = 0; z <= 4; z++)
                    {
                        a[i, z] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            for (int i = 0; i <= 1; i++)
            {
                for(int z = 0; z <= 4; z++)
                {
                    Console.Write(" "+a[i, z]);
                }
  
            }
           


            Console.ReadLine();
        }
    }
}
