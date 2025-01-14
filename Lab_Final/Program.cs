using Kolokwium_Zadanie_1;
using System;

using System;

namespace Kolokwium_Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Swiadectwo swiadectwo = new Swiadectwo();

            // Uzytkownik wprowadza dane do aplikacji
            Console.Write("Podaj liczbę przedmiotów: ");
            int liczbaPrzedmiotow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaPrzedmiotow; i++)
            {
                Console.Write($"Nazwa przedmiotu {i + 1}: ");
                string nazwa = Console.ReadLine();

                Console.Write($"Ocena dla {nazwa}: ");
                int ocena = int.Parse(Console.ReadLine());

                // Dodanie przedmiotu
                swiadectwo.DodajPrzedmiot(nazwa, ocena);
            }

            // Wyniki
            swiadectwo.Wyswietl();
        }
    }
}
