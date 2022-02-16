using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duracao_da_partida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var horaI, horaF;
            TimeSpan dur;

            Console.WriteLine("Digite as horas: ");
            horaI = Convert.To(Console.ReadLine());

            Console.WriteLine("Digite as horas: ");
            horaF = Convert.ToDateTime(Console.ReadLine());

            System.TimeSpan dur = horaF - horaI;

            Console.WriteLine(dur);

            Console.ReadLine();
        }
    }
}
