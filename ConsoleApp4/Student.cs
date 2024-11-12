﻿using System;

public class Student : IStudent
{
    public string Imię { get; set; }
    public string Nazwisko { get; set; }

    public string Uczelnia { get; set; }
    public string Kierunek { get; set; }
    public int Rok { get; set; }
    public int Semestr { get; set; }

    public Student(string imię, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
    {
        Imię = imię;
        Nazwisko = nazwisko;
        Uczelnia = uczelnia;
        Kierunek = kierunek;
        Rok = rok;
        Semestr = semestr;
    }

    public string ZwrocPelnaNazwe()
    {
        return $"{Imię} {Nazwisko}";
    }

    public string WypiszPelnaNazweIUczelnie()
    {
        return $"{ZwrocPelnaNazwe()} – {Rok}{Semestr} {Kierunek} {Uczelnia}";
    }
}