namespace IgnorePositivesApp;
/// <summary>
/// Ignore positives and prints negative 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        
        Console.WriteLine("Please insert different ints");

        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Error in grades count");
            Environment.Exit(1);
        }

        while (num !=0 )
        {
            if (num < 0)
                count++;
            {
                if (!int.TryParse(Console.ReadLine() , out num))
                {
                    Console.WriteLine("Error in grades count");
                    Environment.Exit(1);
                }
            }
            Console.WriteLine($"Negatives count: {count}");
        }
    }
}