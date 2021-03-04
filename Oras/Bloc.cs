using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oras
{
    class Bloc
    {
        private static int Counter = 0;
        public static int count { get { return Counter; } }

        public int ap { get; set; }

        
        public Bloc()
        {
            Counter++;
        }
    }
}
