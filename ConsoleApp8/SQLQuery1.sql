CREATE TABLE Klienci (
    Id INT PRIMARY KEY IDENTITY(1,1), -- Use IDENTITY for auto-increment
    Imie NVARCHAR(50) NOT NULL,
    Nazwisko NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Telefon NVARCHAR(20),
    DataRejestracji DATETIME DEFAULT GETDATE() -- Use GETDATE for default timestamp
);

