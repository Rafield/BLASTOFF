using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumo_de_combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distancia, combustivel, kml;

            Console.WriteLine("Qual a kilometragem percorrida?");
            distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantos litros de combustivel foram gasto?");
            combustivel = Convert.ToDouble(Console.ReadLine());

            kml = distancia / combustivel;

            Console.WriteLine("O veiculo fez " + kml + "Km/L");

            Console.ReadLine();
        }
    }
}
