namespace CheckPositiveAndNegative;
/// <summary>
/// Checks a pair of integers and return true, if one is negative and the other is positive.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        double num1;
        double num2;
        bool result = false;
        
        Console.WriteLine("Please give two numbers : ");
        num1 = double.Parse(Console.ReadLine()!);
        num2 = double.Parse(Console.ReadLine()!);

        if (num1 > 0 && num2 < 0)
        {
            result = true;
        }
        Console.WriteLine("Your chosen numbers are {0} and {1} , result is {2}" , num1, num2, result);
    }
}