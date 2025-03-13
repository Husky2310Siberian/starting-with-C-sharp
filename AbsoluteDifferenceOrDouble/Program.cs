namespace AbsoluteDifferenceOrDouble;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Result(4,2));
        Console.WriteLine(Result(4,-2));
        Console.WriteLine(Result(-4,-2));
        Console.WriteLine(Result(14,22));
    }

    static int Result(int a, int b)
    {
        if (a > b)
        {
            return (a - b) * 2;
        }
        return b - a;
    }
}