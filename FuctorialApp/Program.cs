using System.Numerics;

namespace FuctorialApp;

class Program
{
    static void Main(string[] args)
    {
        int num = 5;
        
        Console.WriteLine($"Iterative factorial of number {num} : {FactoIterative(num)}");
        Console.WriteLine($"Recursive factorial of number {num} : {FactoRecursive(num)}");

        for (int i = 0; i <= 20; i++)
        {
            Console.WriteLine($"{i,3}! = {FactoRecursive(i):N0}");
        }
    }
    /// <summary>
    /// Iterative version of fuctorial
    /// </summary>
    /// <param name="n"></param>
    /// <returns>The result of fuctorial</returns>
    public static BigInteger FactoIterative(int n)
    {
        BigInteger result = 1;
        
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    /// <summary>
    /// Recursive version of factorial.
    /// </summary>
    /// <param name="n"></param>
    /// <returns>The result of fuctorial</returns>
    public static BigInteger FactoRecursive(int n)
    {
        return (n > 1) ? n * FactoRecursive(n - 1) : 1;
    }
}