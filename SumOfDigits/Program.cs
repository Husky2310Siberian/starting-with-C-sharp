namespace SumOfDigits;
/// <summary>
/// Compute the sum of the digits of an integer
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Please insert a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The sum of given digit is : " + SumOfDigits(num));
    }

    public static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0) 
        {
            sum += number % 10; 
            number /= 10;
        }
        return sum;
    }
}