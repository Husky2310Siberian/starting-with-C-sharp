namespace BreakContinueDemo;
/// <summary>
/// Example readind numbers 1 -> 10 , with break / continue
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        int j = 0;
        int sum = 0;
        
        Console.WriteLine("Break Example , reads until 7");

        while (true)
        {
            Console.WriteLine($"i = {i}");
            if (i == 7)
                break;
            i = i + 1;
        }
        
        Console.WriteLine($"-----------------------------");
        Console.WriteLine("Continue Example , reads until 10 , WITHOUT reading 5");

        while (j <= 9)
        {
            j++;
            if (j == 5) continue;
            Console.WriteLine($"j = {j}");
        }
        
    }
}