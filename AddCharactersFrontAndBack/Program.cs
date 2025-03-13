namespace AddCharactersFrontAndBack;
/// <summary>
/// Add a character to Front and Back in a given string
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please give a string: ");
        string input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Please give a string: ");
            return;
        }
        Console.WriteLine("Your given string is : " + input);
        Console.WriteLine("Please give a character , that you want to insert in front and back: ");
        string inputChar = Console.ReadLine();
        if (inputChar == null)
        {
            Console.WriteLine("Please give a string: ");
            return;
        }
        string newString = input.Insert(0,  inputChar);
        Console.WriteLine(newString + inputChar);
    }
}