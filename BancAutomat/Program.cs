using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancAutomat
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard();
            User user = new User();
            user.AddMoney(100);
            Console.WriteLine(user.Balance);
            Console.WriteLine("asd");

            Console.WriteLine("TestingBranch1");

        }
    }
}
