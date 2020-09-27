using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia3zadanie
{
    class Hero
    {
        public int zycie;
        public int mana;
        public int atak;
        public int obrona;
        public int level;
        public int inteligencja;
        public string nazwa;
        public string klasa;

        public int Atakuj()
        {
            Random rnd = new Random();
            int obrazenia = rnd.Next(1, 30);
            Console.WriteLine("Zadales "+obrazenia+" obrazen!");
            return obrazenia;
        }
        public void Awansuj(int poziomy)
        {
            if (klasa == "Mag")
            {
                level += poziomy;
                atak += 3;
                obrona += 1;
                inteligencja += 1;
            }
            if (klasa == "Rycerz")
            {
                level += poziomy;
                atak += 1;
                obrona += 3;
                inteligencja += 1;
            }
            if (klasa == "Paladyn")
            {
                level += poziomy;
                atak += 2;
                obrona += 2;
                inteligencja += 1;
            }
            Console.WriteLine("Awansowales na " + level + " poziom!");
        }
        public void Wyswietl()
        {
            Console.WriteLine("Imie: " + nazwa);
            Console.WriteLine("Klasa: " + klasa);
            Console.WriteLine("Atak: " + atak);
            Console.WriteLine("Obrona: " + obrona);
            Console.WriteLine("Inteligencja: " + inteligencja);
        }
        public Hero()
        {

        }
        public Hero(string name, string vocation)
        {
            nazwa = name;
            klasa = vocation;
        }
        public Hero(string name)
        {
            nazwa = name;
        }
    }
}
