using System.Numerics;

namespace ProductWhileApp;
/// <summary>
/// Calculates 1 * 2 * 3 * ... * n
/// Calculates 1 + 2 + 3 + ... + n
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int start = 0;
        int end = 0;
        int i = 1;
        int j = 0;
        BigInteger result1 = 1;
        BigInteger result2 = 0;
        
        Console.WriteLine("Please enter a start number");
        start = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a end number");
        end = int.Parse(Console.ReadLine());

        while ( i <= end && j <= end )
        {
            result1 *= i;
            i++;
            result2 += j;
            j++;
            
        }
        Console.WriteLine($"The multiply result for {start} to {end} is {result1}");
        Console.WriteLine($"The sum result for {start} to {end} is {result2}");
    }
}