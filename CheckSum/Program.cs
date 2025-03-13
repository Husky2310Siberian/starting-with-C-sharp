namespace CheckSum;
/// <summary>
/// Checks the sum of the two given integers, and return true if one of the integer is 20 or if their sum is 20
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int x ;
        int y;
        Console.WriteLine("Please enter two numbers: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        int sum = x + y;
        
        int FIND_NUMBER = 20;
        bool checksum = false;
        
        Console.WriteLine(sum);
        
         Console.WriteLine(CheckForSum(sum , FIND_NUMBER));
    }

    public static int CheckForSum(int a, int b)
    {
        int  c = 20;
        bool checksum = false;
        if (a == c || b == c || a + b == c)
        {
            return c;
        }
        return a + b ;
    }
}