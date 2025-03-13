namespace FindLongestAndShorterWord;
/// <summary>
/// Find the longest and shortest word in a string
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string line = "Write a C# Sharp Program to display the following pattern using the alphabet";

        string[] words = line.Split();

        string smallestword = "";
        string longestword = "";
        int counter = 0;

        foreach (string s in words)
        {
            if (s.Length > counter)
            {
                longestword = s;
                counter = s.Length;
            }
        }

        foreach (string s in words)
        {
            if (s.Length < counter)
            {
                smallestword = s;
                counter = s.Length;
            }
        }
        Console.WriteLine("The smallest word of given line <<{0}>> is: ---> <<{1}>> ",  line , smallestword);
        Console.WriteLine("The longest word of given line <<{0}>> is: ---> <<{1}>> ",  line , longestword);
    }
}