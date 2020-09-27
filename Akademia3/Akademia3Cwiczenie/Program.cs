using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia3cwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto sam1 = new Auto();
            sam1.model = "Audi";
            sam1.nazwa = "Q7";
            sam1.pojemnoscPaliwa = 120;
            sam1.obecnaPojemnoscPaliwa = 30;
            sam1.konMech = 550;
            sam1.liczbaPrzejechanychKilometrow = 45000;

            Auto sam2 = new Auto();
            sam2.model = "Fiat";
            sam2.nazwa = "Multipla";
            sam2.pojemnoscPaliwa = 150;
            sam2.obecnaPojemnoscPaliwa = 40;
            sam2.konMech = 100;
            sam2.liczbaPrzejechanychKilometrow = 133000;

            sam1.PrzekrecLicznik();
            sam1.Informacje();

            sam2.PrzekrecLicznik();
            sam2.Informacje();

            Console.ReadKey();
        }

    }
}
