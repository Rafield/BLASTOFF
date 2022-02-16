using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Digite o número a ser testado: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = 0;
            
                for(int i = 1; i <= a; i++)
                {
               
                    if(a % i == 0)
                    {
                        b++;
                    }
                }

                    if (b == 2)
                    {
                        Console.WriteLine("Esse número é primo!");
                        Console.WriteLine(b);
                    }

                    else
                    {
                        Console.WriteLine("Esse número não é primo!");
                    }
        
        
            Console.ReadLine();
        }
    }
}
