using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia6zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                n = Int32.Parse(Console.ReadLine());
                if (n == 7)
                {
                    throw new Wyjatek("Liczba nie moze wynosic 7!");
                }
            }
            catch (Wyjatek ex)
            {
                Console.WriteLine(ex);
                throw new Wyjatek("Liczba nie moze wynosic 7!");
            }
            finally
            {
                Console.WriteLine("Twoja liczba to: "+n);
            }
            Console.ReadKey();
        }
    }
    public class Wyjatek : Exception
    {
        public Wyjatek(string message)
            : base(message)
        {
            
        }
    }
}
