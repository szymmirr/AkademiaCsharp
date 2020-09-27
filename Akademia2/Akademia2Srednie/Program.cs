using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia2zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj swoje imie i nazwisko:");
                string imienazwisko = Console.ReadLine();
                Console.WriteLine("Podaj liczbe:");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.WriteLine("Wygrales samochod!");
                        break;
                    case "2":
                        Console.WriteLine("Wygrales motocykl!");
                        break;
                    case "3":
                        Console.WriteLine("Wygrales rower!");
                        break;
                    default:
                        Console.WriteLine("Wygrales uscisk dloni!");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
