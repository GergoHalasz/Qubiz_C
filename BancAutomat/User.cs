using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancAutomat
{
    class User
    {
        public double money = 2000.86;
        public double Balance { get { return GetBalance(); } }

       

        public string Name { get { return GetName(); } }

        private string GetName()
        {
            return "Halasz Gergo";
        }

        private double GetBalance()
        {
            return money;
        }
        public void AddMoney(double moneyToAdd)
        {
           money += moneyToAdd;
           
        }
        public void WithdrawMoney(double moneyToWithdraw)
        {
            money -= moneyToWithdraw;
        }
    }
}
