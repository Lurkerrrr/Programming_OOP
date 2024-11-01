public class Osoba
{
    private string imie;

    public string Imie
    {
        get { return imie; }
        set { imie = value; }

    public required string Imie { get; set }

    public string Imie { get; private set; }

    Pojazd pojazd = new Pojazd();
    pojazd.Uruchom(); 

Samochod samochod = new Samochod();
    samochod.Klakson();
    samochod.Uruchom();

class Pojazd
    {
        public void Uruchom()
        {
            Console.WriteLine($"Pojazd uruchomiony");
        }
    }

    class Samochod : Pojazd
    {
        public void Klakson()
        {
            Console.WriteLine($"Samochod trabi");
        }

    }

    class Osoba
    {
        protected string Imie { get; set; }

        public Osoba(string imie)
        {
            Imie = imie;
        }
    }

    public class Pracownik : Osoba
    {
        public string Stanowisko { get; set; }
        public Pracownik(string imie, string stanowisko) : base(imie)
        {
            Stanowisko = stanowisko;

        }


    }
}



