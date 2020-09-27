using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia3cwiczenie
{
    class Auto
    {
        public int pojemnoscPaliwa;
        public int obecnaPojemnoscPaliwa;
        public int konMech;
        public int rokProdukcji;
        public string model;
        public string nazwa;
        public int liczbaPrzejechanychKilometrow;
        public void PrzekrecLicznik()
        {
            liczbaPrzejechanychKilometrow -= 20000;
        }
        public void Informacje()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Nazwa: " + nazwa);
            Console.WriteLine("Pojemnosc paliwa: " + pojemnoscPaliwa);
            Console.WriteLine("Obecna pojemnosc paliwa: " + obecnaPojemnoscPaliwa);
            Console.WriteLine("Konie mechaniczne: " + konMech);
            Console.WriteLine("Rok produkcji: " + rokProdukcji);
            Console.WriteLine();
        }
        public Auto()
        {

        }
        public Auto(string name, int fuelcap, int actualfuelcap)
        {
            nazwa = name;
            pojemnoscPaliwa = fuelcap;
            obecnaPojemnoscPaliwa = actualfuelcap;
        }
        public Auto(string name, int horses)
        {
            nazwa = name;
            konMech = horses;
        }
        
    }
}
