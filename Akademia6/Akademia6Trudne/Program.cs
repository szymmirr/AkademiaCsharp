﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia6zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Lista.ForEach((delegate(int liczba)
            {
                if (liczba % 3 == 0)
                {
                    Console.WriteLine(liczba);
                }
            }));
            Console.ReadKey();
        }
    }
}
