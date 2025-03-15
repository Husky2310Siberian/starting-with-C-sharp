namespace AddOnlyOdds;
/// <summary>
/// Calculates odds numbers from 2 to...
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int startnumber = 0;
        int endnumber = 0; 
        int sum = startnumber + endnumber;
        Console.WriteLine("Please enter number: ");
        startnumber = Convert.ToInt32(Console.ReadLine());
        endnumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The odd sum from given numbers {0} to {1} :  ", startnumber, endnumber);
        Console.WriteLine(FindAndAddOdds(startnumber, endnumber));
    }

    public static int FindAndAddOdds(int number1, int number2)
    {
        int sum = 0;
        for (int i = 0; i <= number2; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}