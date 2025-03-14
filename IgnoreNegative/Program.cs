namespace IgnoreNegative;

class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        int negativeCount = 0;
        int positiveCount = 0;

        try
        {
            do
            {
                Console.WriteLine("Please insert a number (integer)");
                num = int.Parse(Console.ReadLine()!);
                if (num > 0)
                    positiveCount++;
                if (num < 0)
                    negativeCount++;
                if (num == 0) break;
            } while (true);
            Console.WriteLine($"The number of positives is : {positiveCount} , " +
                              $"The number of negatives is :  {negativeCount}");
        } catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}