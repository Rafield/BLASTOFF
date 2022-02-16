using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palíndromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int x;

            Console.WriteLine("Digite a palavra a ser verificada: ");
            palavra = Console.ReadLine();

            x = palavra.Length - 1;

            while(x != -1)
            {
                for(int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == palavra[x])
                    {
                        if (x == 0)
                        {
                            Console.WriteLine("A palavra é um palíndromo!");
                            Console.ReadLine();
                        }
                        
                        x--;
                    }
                    else
                    {
                        Console.WriteLine("A palavra não é um palíndromo!");
                        i = palavra.Length;
                        x = -1;
                        Console.ReadLine();
                    }
                    }
                }

            }
        }
    }

