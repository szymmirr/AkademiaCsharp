using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia6zadanie1
{
    class Program
    {
        static void Main()
        {
            double pierwiastek = 1;
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new ArgumentException("Liczba nie moze byc ujemna");
                }
                pierwiastek = Math.Sqrt(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new ArgumentException("Liczba nie moze byc ujemna");
            }
            finally
            {
                Console.WriteLine(pierwiastek);
            }
            Console.ReadKey();
        }
    }
}
