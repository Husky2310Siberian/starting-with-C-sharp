namespace PowerApp;
/// <summary>
/// Calculates b ^ power --> 2 ^ 10 = 1024
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        double b = 0;
        double power = 0;
        double result = 1;
        double root = 0;
        
        
        b = double.Parse(Console.ReadLine());
        power = double.Parse(Console.ReadLine());

        for (int i = 1; i <= power; i++)
        {
            result *= b;
        }
        
        root = Math.Sqrt(result);
        
        Console.WriteLine("The result of {0} ^ {1} = {2:N2}",  b, power, result);
        Console.Write("The square root of {0} is {1}" , result, root);
        
    }
}