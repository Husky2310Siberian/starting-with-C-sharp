namespace SwappTwoNumbersApp;

/// <summary>
/// The act of swapping two variables refers to mutually exchanging the values of the variables.
/// Generally, this is done with the data in memory.
/// Using a temporary variable!! - The simplest method to swap two variables is to use a third temporary variable
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        int temp;
        
        Console.WriteLine("Please insert a number ");
        a = int.Parse(Console.ReadLine()!);
        b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Number a is {0} and number b is {1}" , a, b);
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("The numbers now are a : {0} and b : {1} ", a, b);
    }
}