namespace ConvertLineToLowerCase;
/// <summary>
/// Convert a given string into lowercase
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert a string of characters");
        string line = Console.ReadLine();

        if (line.Length == 0 || line[0] == '-' || line[0] == '+' || line[0] == ' ')  
        {
            Console.WriteLine("Please insert a string of characters");
            return;
        }
        
        Console.WriteLine("The new string in lower case is : ");
        Console.WriteLine(line.ToLower());
        
    }
}