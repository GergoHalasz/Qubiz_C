using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oras
{
    class Cartier
    {
        public string Nume { get; }

        //public int SumaBlocurilor { get { return GetSumaBlocurilor(); }  }

        //public int SumaCaselor { get { return GetSumaCaselor(); } }

        //private int GetSumaCaselor()
        //{
        //    return Casa.count;
        //}

        //private int GetSumaBlocurilor()
        //{
        //    return Bloc.count;
        //}

        public Cartier(string nume)
        {
           Nume = nume;
        }
    }
}
