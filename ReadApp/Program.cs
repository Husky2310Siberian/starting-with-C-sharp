namespace ReadApp;
/// <summary>
/// Read two literals from std input
/// and prints the sum
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        int result = 0;
        
        Console.WriteLine("Please insert two integers");
        num1 = int.Parse(Console.ReadLine()!);
        num2 = int.Parse(Console.ReadLine()!);
        
        result = num1 + num2;
        
        Console.WriteLine($"{num1} + {num2} = {result}");
    }
}