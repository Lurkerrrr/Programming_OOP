DniTygodnia dzien = DniTygodnia.Wtorek;
if (dzien == DniTygodnia.Wtorek)
Console.WriteLine("Dzis jest wtorek");

enum DniTygodnia
{
    Poniedzialek = 1,
    Wtorek = 2,
    Sroda = 3,
    Czwartek = 4,
    Piatek = 5,
    Sobota = 6,
    Niedziela = 7
}

try
{
    int[] array = new int[5];
    array[10] = 1;
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine($"Blad: {ex.Message}");
} 
catch (Exception ex)
{
    Console.WriteLine($"Nieoczekiwany blad: {ex.Message}"); 
} 
//finally
//{
//    Console.WriteLine("blok finally");
//}
