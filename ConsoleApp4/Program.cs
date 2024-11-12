class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes sound");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog");
    }
}

public class Dog1 : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog1");
    }
}

public abstract class Shape
{
    public abstract double Area();

}

public class Circle : Shape
{
    double r;

    public Circle(double r) { this.r = r; }
    public override double Area()
    {
        return r;
    }
}

public interface IAnimal
{
    public void MakeSound() { Console.WriteLine(); }

    int Age { get; set; }

}

// Zadanie 3a 
public interface IOsoba
{
    string Imię { get; set; }
    string Nazwisko { get; set; }

    string FullData();
}

class Program
{
    static void Main(string[] args)
    {
        List<Osoba> listaOsob = new List<Osoba>();

        Osoba osoba1 = new Osoba("Jan", "Kowalski");
        Osoba osoba2 = new Osoba("Anna", "Nowak");
        Osoba osoba3 = new Osoba("Piotr", "Zielinski");

        listaOsob.Add(osoba1);
        listaOsob.Add(osoba2);
        listaOsob.Add(osoba3);

        foreach (Osoba osoba in listaOsob)
        {
            Console.WriteLine(osoba.FullData());
        }
    }
}

// Zadanie 3b 
public interface IOsoba
{
    string Imię { get; set; }
    string Nazwisko { get; set; }
    string FullData();
}

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

public static class OsobaExtensions
{
    public static void WypiszOsoby(this List<IOsoba> lista)
    {
        foreach (var osoba in lista)
        {
            Console.WriteLine(osoba.FullData());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IOsoba> listaOsob = new List<IOsoba>
        {
            new Osoba("Jan", "Kowalski"),
            new Osoba("Anna", "Nowak"),
            new Osoba("Piotr", "Zielinski")
        };

        listaOsob.WypiszOsoby();
    }
}

// Zadanie 3c 
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

public static class OsobaExtensions
{
    public static void PosortujOsobyPoNazwisku(this List<IOsoba> lista)
    {
        lista.Sort((o1, o2) => string.Compare(o1.Nazwisko, o2.Nazwisko));
    }

    public static void WypiszOsoby(this List<IOsoba> lista)
    {
        foreach (var osoba in lista)
        {
            Console.WriteLine(osoba.FullData());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IOsoba> listaOsob = new List<IOsoba>
        {
            new Osoba("Jan", "Kowalski"),
            new Osoba("Anna", "Nowak"),
            new Osoba("Piotr", "Zielinski"),
            new Osoba("Marek", "Kowalski"),
            new Osoba("Adam", "Zielinski")
        };

        Console.WriteLine("Przed sortowaniem:");
        listaOsob.WypiszOsoby();

        listaOsob.PosortujOsobyPoNazwisku();

        Console.WriteLine("\nPo sortowaniu:");
        listaOsob.WypiszOsoby();
    }
}

// Zadanie 3d 

public interface IOsoba
{
    string Imię { get; set; }
    string Nazwisko { get; set; }
    string FullData();
}

    public string FullData()
    {
        return $"{Imię} {Nazwisko}";
    }

    public string WypiszPelnaNazweIUczelnie()
    {
        return $"{FullData()} – {Rok}{Semestr}{Kierunek} {Uczelnia}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IStudent> listaStudentow = new List<IStudent>
        {
            new Student("Jan", "Kowalski", "WSIiZ", "IIID-P", 4, 1),
            new Student("Anna", "Nowak", "AGH", "Informatyka", 2, 2),
            new Student("Viktor", "Pylypenko", "WSIiZ", "3iiD-P", 4, 1),
            new Student("Piotr", "Zielinski", "UJ", "Matematyka", 3, 3)
        };

        foreach (var student in listaStudentow)
        {
            Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
        }
    }
}

// Zadanie 3e 

class Program
{
    static void Main(string[] args)
    {
        List<IStudent> listaStudentow = new List<IStudent>
        {
            new StudentWSIiZ("Jan", "Kowalski", "Informatyka", 4, 1),
            new StudentWSIiZ("Anna", "Nowak", "Zarządzanie", 2, 2),
            new StudentWSIiZ("Piotr", "Zielinski", "Elektryka", 3, 3)
        };

        foreach (var student in listaStudentow)
        {
            Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
        }
    }
}