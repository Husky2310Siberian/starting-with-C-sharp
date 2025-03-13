namespace CalculateApp1;
/// <summary>
/// Calculates arithmetic operators
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        double num1;
        double num2;
        double sum , sub , divide , mod , mul ;
        
        Console.WriteLine("Please insert two numbers : ");
        num1 = double.Parse(Console.ReadLine()!);
        num2 = double.Parse(Console.ReadLine()!);
        
        sum = num1 + num2;
        sub = num1 - num2;
        mul = num1 * num2;
        divide = num1 / num2;
        mod = num1 % num2;
        
        Console.WriteLine("The result for : {0:F2} + {1:F2} = {2:F2}" , num1, num2, sum);
        Console.WriteLine("The result for : {0:F2} - {1:F2} = {2:F2}" , num1, num2, sub);
        Console.WriteLine("The result for : {0:F2} * {1:F2} = {2:F2}" , num1, num2, mul);
        if (num2 == 0)
        {
            Console.WriteLine("Error, divisor can not be zero");
            Console.WriteLine("Error, divisor can not be zero");
        } else if (num2 != 0)
        {
            Console.WriteLine("The result for : {0:F2} / {1:F2} = {2:F2}" , num2, num2, divide);
            Console.WriteLine("The result for : {0:F2} % {1:F2} = {2:F2}" , num2, num2, mod);
        }
    }
}