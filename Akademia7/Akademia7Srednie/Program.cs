using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia7zadanie2
{
    class Klasa
    {
        private int zmienna = 0;
        public int Wlasciwosci1
        {
            get
            {
                return zmienna;
            }
            set
            {
                ++zmienna;
            }
        }
        public int Wlasciwosci2
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
