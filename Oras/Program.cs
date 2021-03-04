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
            CapeCodStyle capeCodStyleHouse = new CapeCodStyle();
            School school1 = new School();
            School school2 = new School();
            Bloc bloc = new Bloc();
            Church church = new Church();
            Console.Write("Houses: ");
            Console.WriteLine(House.count);
            Console.Write("Institutions: ");
            Console.WriteLine(Institution.count);
            Console.Write("All buildings: ");
            Console.WriteLine(Building.count);

           
            school1.StreetName = "Str. Henri Coanda";
            school1.BlockNumber = "Nr.17";
            school1.ApartmentNumber = "Ap.3";


            school2.StreetName = "Str. Moscovei";
            school2.BlockNumber = "Nr.1";

            Console.WriteLine("The Address of School 1: "+ school1.StreetName + " " + school1.BlockNumber + " ");
            Console.WriteLine("The Address of School Ady Endre: " + school2.StreetName + " " + school2.BlockNumber + " ");





        }
    }
}
