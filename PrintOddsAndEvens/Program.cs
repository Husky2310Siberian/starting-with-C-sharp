namespace PrintOddsAndEvens;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(PrintOdds(i));
        }
    }

    public static double PrintOdds(double a)
    {
        if (a % 2 == 0)
        {
            return a;
        }
        return Math.Sqrt(a);
    }
}