using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    class Program
    {
        /*
        Zadanie nr 3:
            używając poniższego kodu przekształć program tak by korzystał on z pętli while i robił konwersje hex do dec (zmien nazwe pliku z test.txt na zad.file)
            */

        static void Main(string[] args)
        {
            foreach (var line in System.IO.File.ReadAllLines(@"..\..\test.file"))// odczytanie wszystkich linii w pliku test.txt
            {
                binToText(line);//wywołanie kodu z funkcji  static void binToText(string line)
            }
            Console.Write("\n");//wypisanie znaku końca linii 
            Console.ReadKey();
        }
        static void binToText(string line)
        {
            int dec = 0;
            int i = 0;
            for (; i < line.Length; i += 1)//zapis line.Length zwraca w postaci int długość naszej linii zaczytanej wcześniej z pliku
            {
                if (line[line.Length - i - 1] == '0')//line[line.Length - i - 1 -> zamianę z bin na dec zaczynamy od końca
                    continue;                       //jeśli na danym polu mamy zero komenda continue pomijamy nastepna linie kodu
                dec += (int)Math.Pow(2, i);//do zmiennej dec dodajemy potęgę 2, jeśli nie wiesz jak robi się konwersje z bin na dec to: https://pl.wikipedia.org/wiki/Dw%C3%B3jkowy_system_liczbowy
                
            }

            Console.Write("{0}", (char)dec); //wypisz przekształcony znak na ekran używając rzutowania czyli zmiany typu zmiennej z int na char: (char)dec
        }

    }
}

