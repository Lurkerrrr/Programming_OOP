// 1. Napisz program pozwalający na zapisanie do pliku o wskazanej nazwie, nr albumu osoby, która
// napisała program. 

using ConsoleApp7;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj nazwę pliku:");
        string fileName = Console.ReadLine();

        Console.WriteLine("Podaj numer albumu:");
        string nrAlbumu = Console.ReadLine();

        File.WriteAllText(fileName, nrAlbumu);
        Console.WriteLine($"Numer albumu zapisano do pliku {fileName}.");
    }
}

// 2. Napisz program pozwalający na wczytanie zawartości pliku o wskazanej nazwie. 

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj nazwę pliku do odczytu:");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string content = File.ReadAllText(fileName);
            Console.WriteLine($"Zawartość pliku {fileName}:\n{content}");
        }
        else
        {
            Console.WriteLine($"Plik {fileName} nie istnieje.");
        }
    }
}

// 3. Napisz program wczytujący listę peseli z pliku pesels.txt, a następnie zaimplementuj funkcję
// sprawdzającą, ile jest żeńskich peseli we wczytanym zbiorze. Plik pesel.txt należy wygenerować z
// użyciem generatora pesel. 

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "pesels.txt";

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"Plik {fileName} nie istnieje.");
            return;
        }

        List<string> pesels = new List<string>(File.ReadAllLines(fileName));
        int femaleCount = CountFemalePesels(pesels);

        Console.WriteLine($"Liczba żeńskich PESEL-i: {femaleCount}");
    }

    static int CountFemalePesels(List<string> pesels)
    {
        int count = 0;
        foreach (var pesel in pesels)
        {
            if (pesel.Length == 11 && (pesel[9] - '0') % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}

// 4. Wykorzystując bazę danych „db.json”, zawierającą informację o populacji USA, Indii i Chin od roku
// 1960 

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "db.json";
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"Plik {fileName} nie istnieje.");
            return;
        }

        var jsonData = File.ReadAllText(fileName);
        var populationData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, long>>>(jsonData);

        // Przykładowe działania
        Console.WriteLine("Różnica populacji Indii (1970-2000):");
        Console.WriteLine(CalculatePopulationDifference(populationData, "India", 1970, 2000));

        Console.WriteLine("Różnica populacji USA (1965-2010):");
        Console.WriteLine(CalculatePopulationDifference(populationData, "USA", 1965, 2010));

        Console.WriteLine("Różnica populacji Chin (1980-2018):");
        Console.WriteLine(CalculatePopulationDifference(populationData, "China", 1980, 2018));
    }

    static long CalculatePopulationDifference(Dictionary<string, Dictionary<string, long>> data, string country, int year1, int year2)
    {
        if (!data.ContainsKey(country)) throw new ArgumentException("Nieprawidłowy kraj.");
        var countryData = data[country];
        return countryData[year2.ToString()] - countryData[year1.ToString()];
    }
}

// 5. Napisz program implementujący interfejs IPersonRepository, poprzez klasę FilePersonRepository
// pracującą na plikowej bazie danych. (Json, record per line, etc).

class Program
{
    static void Main(string[] args)
    {
        IPersonRepository repository = new FilePersonRepository("persons.json");

        repository.AddPerson(new Person(1, "Jan Kowalski", 25));
        repository.AddPerson(new Person(2, "Anna Nowak", 30));

        var allPersons = repository.GetAllPersons();
        Console.WriteLine("Wszyscy zapisani ludzie:");
        foreach (var person in allPersons)
        {
            Console.WriteLine($"{person.Id}: {person.Name}, {person.Age} lat");
        }
    }
}

