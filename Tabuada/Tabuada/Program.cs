using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int[] tabuada = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] respostas = new int[10];

            Console.WriteLine("Digite o número que deseja calcular a tabuada!");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 9; i++)
            {
                respostas[i] = a * tabuada[i];
                Console.WriteLine(a + " X " + tabuada[i] + " = " + respostas[i]);
                
            }


            Console.ReadLine();
        }
    }
}
