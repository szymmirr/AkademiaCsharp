using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia7zadanie1
{
    class Obliczenia
    {
        /// <summary>
        /// Funkcja przyjmuje dwie zmienne i zwraca ich sumę
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Dodawanie(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Obliczenia.Dodawanie(3, 5));
            Console.ReadKey();
        }
    }
}
