namespace TernaryOperator;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber = 0;
        int abs = 0;
        
        Console.WriteLine("Enter number: ");
        inputNumber = int.Parse(Console.ReadLine());
        
        abs = (inputNumber >= 0) ? inputNumber : -inputNumber;
        
        Console.WriteLine("Your absolute of input number is {0}" , abs);
    }
}