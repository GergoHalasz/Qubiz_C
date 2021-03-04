using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancAutomat
{
    public interface ICards
    {
        double GetBalance();
       
    }
    class CreditCard : User,ICards
    {
        public string type { get { return GetType(); } }
        public string brand { get; }
        public string iban
        {
            get
            {
                return GetIBan();
            }
        }

        
        
        public string GetType()
        {
            return "ING";
        }
        public string pin
        {
            get
            {
                return GetPIN();
            }
        }
        private string GetIBan()
        {
            return "RO98KNCB0123324580909876";
        }

        private string GetPIN()
        {
            return "1234";
        }

        public double GetBalance()
        {
            throw new NotImplementedException();
        }

        public CreditCard(string pin)
        {
            if(this.pin == pin)
            {
                User user = new User();

            }
            
        }
       
        
    }
    
}
