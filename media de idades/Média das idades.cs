using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_de_idades
{
    internal class Program
    {
        static void Main(string[] args)
            {
                int idade_i, idade_j, idade_k, idade_x, idade_y;
                double media;

                Console.WriteLine("Digite a idade de I");
                idade_i = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite a idade de j");
                idade_j = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite a idade de K");
                idade_k = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite a idade de X");
                idade_x = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite a idade de Y");
                idade_y = Convert.ToInt16(Console.ReadLine());

                media = (idade_i + idade_j + idade_k + idade_x + idade_y) / 5;

                Console.WriteLine("a media das idades é "+ media);

                Console.ReadLine();
            }
        }
    }

