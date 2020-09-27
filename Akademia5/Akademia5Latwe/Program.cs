using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia5latwe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab1={
                            {1,2,3},
                            {4,5,6},
                            {7,8,9}
                        };
            int[,] tab2 ={
                            {1,2,3},
                            {1,2,3},
                            {1,2,3}
                        };
            int[,] tab3 ={
                            {1,2,3},
                            {2,1,2},
                            {3,2,1}
                        };
            wypisz(tab1);
            Console.WriteLine();
            wypisz(tab2);
            Console.WriteLine();
            wypisz(tab3);
            Console.ReadKey();
        }

        private static void wypisz(int[,] tab1)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j=0; j < 3; j++)
                {
                    Console.Write(tab1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
