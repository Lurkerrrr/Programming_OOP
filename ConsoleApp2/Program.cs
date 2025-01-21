// Zadanie 1 
public class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;

    public string Imie
    {
        get => imie;
        set
        {
            if (value.Length >= 2)
                imie = value;
            else
                throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
        }
    }

    public string Nazwisko
    {
        get => nazwisko;
        set
        {
            if (value.Length >= 2)
                nazwisko = value;
            else
                throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");
        }
    }

    public int Wiek
    {
        get => wiek;
        set
        {
            if (value > 0)
                wiek = value;
            else
                throw new ArgumentException("Wiek musi być liczbą dodatnią.");
        }
    }

    public Osoba(string imie, string nazwisko, int wiek)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Wiek = wiek;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
    }
}

// Zadanie 2 
public class BankAccount
{
    private decimal saldo;

    public string Wlasciciel { get; private set; }
    public decimal Saldo => saldo;

    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        saldo = poczatkoweSaldo > 0 ? poczatkoweSaldo : throw new ArgumentException("Saldo początkowe musi być dodatnie.");
    }

    public void Wplata(decimal kwota)
    {
        if (kwota > 0)
            saldo += kwota;
        else
            throw new ArgumentException("Kwota wpłaty musi być dodatnia.");
    }

    public void Wyplata(decimal kwota)
    {
        if (kwota > 0 && kwota <= saldo)
            saldo -= kwota;
        else
            throw new ArgumentException("Niewystarczające środki lub nieprawidłowa kwota.");
    }
}

// Zadanie 3 
public class Student
{
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    private List<int> oceny;

    public double SredniaOcen => oceny.Count > 0 ? oceny.Average() : 0;

    public Student(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        oceny = new List<int>();
    }

    public void DodajOcene(int ocena)
    {
        if (ocena >= 1 && ocena <= 5)
            oceny.Add(ocena);
        else
            throw new ArgumentException("Ocena musi być w przedziale od 1 do 5.");
    }

    public void WyswietlOceny()
    {
        Console.WriteLine($"Oceny studenta {Imie} {Nazwisko}: {string.Join(", ", oceny)}");
    }
}

// Zadanie 4 

public class Licz
{
    private int value;

    public Licz(int initialValue)
    {
        value = initialValue;
    }

    public void Dodaj(int wartosc)
    {
        value += wartosc;
    }

    public void Odejmij(int wartosc)
    {
        value -= wartosc;
    }

    public void WypiszStan()
    {
        Console.WriteLine($"Aktualna wartość: {value}");
    }
}

// Zadanie 5 

public class Sumator
{
    private int[] liczby;

    public Sumator(int[] liczby)
    {
        this.liczby = liczby ?? throw new ArgumentNullException(nameof(liczby));
    }

    public int Suma()
    {
        return liczby.Sum();
    }

    public int SumaPodziel2()
    {
        return liczby.Where(x => x % 2 == 0).Sum();
    }

    public int IleElementow()
    {
        return liczby.Length;
    }

    public void WypiszElementy()
    {
        Console.WriteLine($"Elementy tablicy: {string.Join(", ", liczby)}");
    }

    public void WypiszElementyWZakresie(int lowIndex, int highIndex)
    {
        for (int i = Math.Max(0, lowIndex); i <= Math.Min(liczby.Length - 1, highIndex); i++)
        {
            Console.WriteLine($"Indeks {i}: {liczby[i]}");
        }
    }
}

