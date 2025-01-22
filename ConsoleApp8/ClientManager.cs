using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class ClientManager
{
    private readonly DatabaseManager dbManager;

    public ClientManager(DatabaseManager dbManager)
    {
        this.dbManager = dbManager;
    }

    public void AddClient(Client client)
    {
        if (!ValidationHelper.IsValidEmail(client.Email))
            throw new ArgumentException("Nieprawidłowy format email.");
        if (!ValidationHelper.IsValidPhone(client.Phone))
            throw new ArgumentException("Nieprawidłowy format numeru telefonu.");

        string query = "INSERT INTO Klienci (Imie, Nazwisko, Email, Telefon) VALUES (@FirstName, @LastName, @Email, @Phone)";
        var parameters = new[]
        {
            new SqlParameter("@FirstName", client.FirstName),
            new SqlParameter("@LastName", client.LastName),
            new SqlParameter("@Email", client.Email),
            new SqlParameter("@Phone", client.Phone ?? (object)DBNull.Value),
        };

        dbManager.ExecuteNonQuery(query, parameters);
    }

    public List<Client> GetClients()
    {
        string query = "SELECT * FROM Klienci";
        var dataTable = dbManager.ExecuteReader(query);
        var clients = new List<Client>();

        foreach (DataRow row in dataTable.Rows)
        {
            clients.Add(new Client
            {
                Id = Convert.ToInt32(row["Id"]),
                FirstName = row["Imie"].ToString(),
                LastName = row["Nazwisko"].ToString(),
                Email = row["Email"].ToString(),
                Phone = row["Telefon"].ToString(),
                RegistrationDate = Convert.ToDateTime(row["DataRejestracji"]),
            });
        }

        return clients;
    }

    public void UpdateClient(Client client)
    {
        string query = "UPDATE Klienci SET Email = @Email, Telefon = @Phone WHERE Id = @Id";
        var parameters = new[]
        {
            new SqlParameter("@Id", client.Id),
            new SqlParameter("@Email", client.Email),
            new SqlParameter("@Phone", client.Phone ?? (object)DBNull.Value),
        };

        dbManager.ExecuteNonQuery(query, parameters);
    }

    public void DeleteClient(int clientId)
    {
        string query = "DELETE FROM Klienci WHERE Id = @Id";
        var parameters = new[] { new SqlParameter("@Id", clientId) };
        dbManager.ExecuteNonQuery(query, parameters);
    }

    public List<Client> SearchClientsByLastName(string lastName)
    {
        string query = "SELECT * FROM Klienci WHERE Nazwisko LIKE @LastName";
        var parameters = new[] { new SqlParameter("@LastName", $"%{lastName}%") };
        var dataTable = dbManager.ExecuteReader(query);
        var clients = new List<Client>();

        foreach (DataRow row in dataTable.Rows)
        {
            clients.Add(new Client
            {
                Id = Convert.ToInt32(row["Id"]),
                FirstName = row["Imie"].ToString(),
                LastName = row["Nazwisko"].ToString(),
                Email = row["Email"].ToString(),
                Phone = row["Telefon"].ToString(),
                RegistrationDate = Convert.ToDateTime(row["DataRejestracji"]),
            });
        }

        return clients;
    }
}
