using System;

public class Osoba : IOsoba
{
    public string Imię { get; set; }
    public string Nazwisko { get; set; }

    public Osoba(string imię, string nazwisko)
    {
        Imię = imię;
        Nazwisko = nazwisko;
    }

    public string FullData()
    {
        return $"{Imię} {Nazwisko}";
    }
}
