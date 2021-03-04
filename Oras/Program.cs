using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oras
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartier cartier = new Cartier("Rogerius");
            Bloc bloc1 = new Bloc();
            Bloc bloc2 = new Bloc();

            Casa casa = new Casa();

            Console.WriteLine(cartier.SumaCaselor);
        }
    }
}
