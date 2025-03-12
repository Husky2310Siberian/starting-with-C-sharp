namespace OutputApp;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 10_123_153;
        int num2 = 20_000_000;

        Console.WriteLine("Num1: " + num1);
        Console.WriteLine("Num1 : {0,6:N2} , Num2 : {1,6:N0}" , num1 , num2);
        Console.WriteLine($"Num1 : {num1,6:N0} , Num2 : {num2,6:N2}");
    }
}