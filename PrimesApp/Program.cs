namespace PrimesApp;
/// <summary>
/// Calculates numbers tha are primitives 7 , 11 , 13 .
/// No 8 , 4 , 20 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
       int startNum = 0;
       int endNum = 0;
       PrintPrimeRange(startNum, endNum);
       Console.WriteLine(isPrime(5));
    }
    public static void PrintPrimeRange(int startNumber , int endNumber)
    {
        Console.WriteLine("Please insert a start number");
        startNumber = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Please insert a end number");
        endNumber = int.Parse(Console.ReadLine()!);
        Console.WriteLine("The Prime numbers between {0} and {1} are:" , startNumber, endNumber);
        for (int i = startNumber; i <= endNumber; i++)
        {
            int counter = 0;

            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    counter++;
                    break;
                }
            }
            if (counter == 0 && i != 1)
            {
                Console.WriteLine("{0} is a prime number", i);
            }
        }
    }

    public static bool isPrime(int number)
    {
        if (number < 2 )
        {
            return false;
        }
        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}