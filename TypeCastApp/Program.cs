namespace TypeCastApp;

/// <summary>
/// Typecast between int - long
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int myInt = 10;
        long myLong = 100_000_000_000_000L;
        float myFloat = 100_000_000_000_000F;
        decimal myDecimal = 1200.67M;
        
        Console.WriteLine($"{myInt}");
        Console.WriteLine($"{myLong}");
        Console.WriteLine($"{myFloat}");
        Console.WriteLine($"{myDecimal}");
    }
}