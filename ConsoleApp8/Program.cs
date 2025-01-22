using System;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "your_connection_string_here";
        var dbManager = new DatabaseManager(connectionString);
        var clientManager = new ClientManager(dbManager);

        while (true)
        {
            Console.WriteLine("1. Dodaj klienta");
            Console.WriteLine("2. Wyświetl klientów");
            Console.WriteLine("3. Edytuj klienta");
            Console.WriteLine("4. Usuń klienta");
            Console.WriteLine("5. Wyszukaj klienta po nazwisku");
            Console.WriteLine("0. Wyjdź");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Imię: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Nazwisko: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Telefon: ");
                    string phone = Console.ReadLine();

                    var client = new Client { FirstName = firstName, LastName = lastName, Email = email, Phone = phone };
                    clientManager.AddClient(client);
                    break;

                case 2:
                    var clients = clientManager.GetClients();
                    foreach (var c in clients)
                    {
                        Console.WriteLine($"{c.Id}: {c.FirstName} {c.LastName}, {c.Email}, {c.Phone}, {c.RegistrationDate}");
                    }
                    break;

                case 3:
                    Console.Write("Podaj ID klienta do edycji: ");
                    int idToUpdate = int.Parse(Console.ReadLine());
                    Console.Write("Nowy email: ");
                    string newEmail = Console.ReadLine();
                    Console.Write("Nowy telefon: ");
                    string newPhone = Console.ReadLine();

                    var clientToUpdate = new Client { Id = idToUpdate, Email = newEmail, Phone = newPhone };
                    clientManager.UpdateClient(clientToUpdate);
                    break;

                case 4:
                    Console.Write("Podaj ID klienta do usunięcia: ");
                    int idToDelete = int.Parse(Console.ReadLine());
                    clientManager.DeleteClient(idToDelete);
                    break;

                case 5:
                    Console.Write("Podaj nazwisko klienta: ");
                    string lastNameToSearch = Console.ReadLine();
                    var foundClients = clientManager.SearchClientsByLastName(lastNameToSearch);
                    foreach (var c in foundClients)
                    {
                        Console.WriteLine($"{c.Id}: {c.FirstName} {c.LastName}, {c.Email}, {c.Phone}, {c.RegistrationDate}");
                    }
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }
}

