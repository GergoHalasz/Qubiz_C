using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oras
{
    class Casa
    {
        private static int Counter = 0;
        public static int count { get { return Counter; } }
        public Casa()
        {
            Counter++;
        }
    }
}
