﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia3zadanie
{
    class BigMonster
    {
        public int zycie;
        public int mana;
        public int atak;
        public int obrona;
        public int level;
        public string nazwa;
        public string klasa;

        public int Atakuj()
        {
            Random rnd2 = new Random();
            int obrazenia = rnd2.Next(10, 35);
            Console.WriteLine("Potwor zadal " + obrazenia + " obrazen!");
            return obrazenia;
        }
        public void Awansuj()
        {

        }
        public void Wyswietl()
        {
            Console.WriteLine("Imie: " + nazwa);
            Console.WriteLine("Klasa: " + klasa);
            Console.WriteLine("Atak: " + atak);
            Console.WriteLine("Obrona: " + obrona);
            Console.WriteLine("Level: " + level);
        }
        public BigMonster()
        {

        }
        public BigMonster(string name, string vocation)
        {
            nazwa = name;
            klasa = vocation;
        }
        public BigMonster(string name)
        {
            nazwa = name;
        }
    }
}
