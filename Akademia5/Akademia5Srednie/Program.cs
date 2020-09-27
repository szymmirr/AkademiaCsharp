using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia5srednie
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();
            tekst=tekst.Trim();
            string tekst2 = new string(tekst.Where(c => !char.IsPunctuation(c)).ToArray());
            String[] wyrazy = tekst2.Split();
            SortedDictionary<string, int> dsi = new SortedDictionary<string, int>();
            foreach (var wyraz in wyrazy)
            {
                if (dsi.ContainsKey(wyraz.ToLower()))
                {
                    dsi[wyraz.ToLower()] += 1;
                }
                else
                {
                    dsi.Add(wyraz.ToLower(), 1);
                }
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, int> pair in dsi)
            {
                Console.Write("{1} {0} | ",
                pair.Key,
                pair.Value);
            }
            Console.ReadKey();
        }
    }
}
