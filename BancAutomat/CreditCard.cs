using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancAutomat
{
    class CreditCard
    {
        public string type { get;  }
        public string brand { get; }
        public string iban
        {
            get
            {
                return GetIBan();
            }
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
       
    }
}
