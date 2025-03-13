namespace CalculateApp;

class Program
{
    static void Main(string[] args)
    {
        double num1;
        double num2;
        //double result = 0;
        
        Console.WriteLine("Please insert two numbers : ");
        num1 = double.Parse(Console.ReadLine()!);
        num2 = double.Parse(Console.ReadLine()!);
        
        double add = num1 + num2;
        double minus = num1 - num2;
        double mul = num1 * num2;
        double divide = num1 / num2;
        double mod = num1 % num2;
        
        Console.WriteLine($"The result for : {num1} + {num2} = {add}");
        Console.WriteLine($"The result for : {num1} - {num2} = {minus}");
        Console.WriteLine($"The result for : {num1} * {num2} = {mul}");
        if (num2 == 0)
        {
            Console.WriteLine("Error, divisor can not be zero");
            Console.WriteLine("Error, divisor can not be zero");
        } else if (num2 != 0)
        {
            Console.WriteLine($"The result for : {num1} / {num2} = {divide}");
            Console.WriteLine($"The result for : {num1} % {num2} = {mod}");
        }
    }
}