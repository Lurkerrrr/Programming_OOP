using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_Zadanie_1
{
    public class Swiadectwo
    {
        private List<Przedmiot> przedmioty;

        // Konstruktor
        public Swiadectwo()
        {
            przedmioty = new List<Przedmiot>();
        }

        // Oblusga bledow
        public void DodajPrzedmiot(string nazwa, int ocena)
        {
            try
            {
                przedmioty.Add(new Przedmiot(nazwa, ocena));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }

        // Obliczenia sredniej
        public double Srednia()
        {
            var oceny = przedmioty.Where(p => p.Ocena > 0).Select(p => p.Ocena).ToList();

            return oceny.Count > 0 ? Math.Round(oceny.Average(), 2) : 0.0;
        }

        // Sprawdzenie promocji
        public bool CzyPromocja()
        {
            return !przedmioty.Any(p => p.Ocena == 1 || p.Ocena == 2);
        }

        // Wyswietlanie swiadectwa
        public void Wyswietl()
        {
            Console.WriteLine($"Liczba przedmiotów: {przedmioty.Count}");
            foreach (var przedmiot in przedmioty)
            {
                Console.WriteLine($"{przedmiot.Nazwa}: {przedmiot.Ocena}");
            }

            Console.WriteLine($"Średnia ocen: {Srednia()}");
            Console.WriteLine($"Promocja {(CzyPromocja() ? "uzyskana." : "nieuzyskana.")}");
        }
    }
}


