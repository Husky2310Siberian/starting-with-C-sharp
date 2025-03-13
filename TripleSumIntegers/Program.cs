namespace TripleSumIntegers;
/// <summary>
/// Computes the sum of two given integers, if two values are equal then return the triple of their sum
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SumTriple(2,12));
        Console.WriteLine(SumTriple(12,12));
        Console.WriteLine(SumTriple(12,-12));
    }

    public static int SumTriple(int a, int b)
    {
        // If 'a' equals 'b', return the triple sum of 'a' and 'b', otherwise return their sum
        return a == b ? (a + b) * 3 : a + b; 
    }
}