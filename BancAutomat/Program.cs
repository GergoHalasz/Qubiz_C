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
            CreditCard creditCard1 = new CreditCard("1234");
            CreditCard creditCard2 = new CreditCard("1234");
            creditCard1.AddMoney(100);
            Console.WriteLine(creditCard1.Balance);

            

          
        }
    }
}
