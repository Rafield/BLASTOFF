using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ler_numeros_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = { 1, 2, 3, 4, 5, 6, 7, 8};

            // leitura dos dados
        
            for(int i = 0; i <= 7; i++)
            {
                if(v1[i] % 2 == 0)
                {
                    Console.Write(v1[i] + " ");
                }
            }
        
            Console.ReadLine();
        }
    }
}
