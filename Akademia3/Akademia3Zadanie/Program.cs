using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia3zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imie postaci: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj klase (Mag, Rycerz, Paladyn): ");
            string klasa = Console.ReadLine();
            Console.WriteLine();
            Hero bohater = new Hero();
            bohater.nazwa = nazwa;
            bohater.klasa = klasa;
            bohater.level = 1;
            if (klasa == "Mag")
            {
                bohater.atak = 3;
                bohater.obrona = 1;
                bohater.zycie = 200;
            }
            else if (klasa == "Rycerz")
            {
                bohater.atak = 1;
                bohater.obrona = 3;
                bohater.zycie = 200;
            }
            else if (klasa == "Paladyn")
            {
                bohater.atak = 2;
                bohater.obrona = 2;
                bohater.zycie = 200;
            }
            bohater.Wyswietl();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Napotkales malego potwora!");
            SmallMonster malypotwor = new SmallMonster();
            malypotwor.zycie = 50;
            while (bohater.zycie > 0 && malypotwor.zycie > 0)
            {
                Console.WriteLine("Nacisnij enter aby walczyc...");
                Console.WriteLine();
                Console.ReadKey();
                bohater.zycie -= malypotwor.Atakuj();
                Console.WriteLine("Pozostale zycie bohatera: " + bohater.zycie);
                if (bohater.zycie <= 0)
                {
                    Console.WriteLine("Nie zyjesz, koniec gry");
                    break;
                }
                malypotwor.zycie -= bohater.Atakuj();
                Console.WriteLine("Pozostale zycie potwora: " + malypotwor.zycie);
                if (malypotwor.zycie <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hura, potwor zginal!");
                    Console.WriteLine();
                    Console.ReadKey();
                    int poziomy=1;
                    bohater.Awansuj(poziomy);
                    bohater.Wyswietl();
                    Console.WriteLine();
                    break;
                }
                Console.WriteLine();
            }

            Console.WriteLine(">>NAPOTKALES BOSSA!<<");
            BigMonster duzypotwor = new BigMonster();
            duzypotwor.zycie = 100;
            while (bohater.zycie > 0 && duzypotwor.zycie > 0)
            {
                Console.WriteLine("Nacisnij enter aby walczyc...");
                Console.WriteLine();
                Console.ReadKey();
                bohater.zycie -= duzypotwor.Atakuj();
                Console.WriteLine("Pozostale zycie bohatera: " + bohater.zycie);
                if (bohater.zycie <= 0)
                {
                    Console.WriteLine("Nie zyjesz, koniec gry");
                    break;
                }
                duzypotwor.zycie -= bohater.Atakuj();
                Console.WriteLine("Pozostale zycie potwora: " + duzypotwor.zycie);
                if (duzypotwor.zycie <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hura, potwor zginal!");
                    Console.WriteLine();
                    Console.ReadKey();
                    int poziomy = 2;
                    bohater.Awansuj(poziomy);
                    bohater.Wyswietl();
                    Console.WriteLine();
                    Console.WriteLine("Ukonczyles gre!");
                    Console.WriteLine();
                    break;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
