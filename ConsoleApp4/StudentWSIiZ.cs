using System;

public class StudentWSIiZ : Student
{
    public StudentWSIiZ(string imię, string nazwisko, string kierunek, int rok, int semestr)
        : base(imię, nazwisko, "WSIiZ", kierunek, rok, semestr)
    {
    }

    public new string WypiszPelnaNazweIUczelnie()
    {
        return $"{ZwrocPelnaNazwe()} – {Rok}{Semestr} {Kierunek} WSIiZ";
    }
}
