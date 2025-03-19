namespace SwappTwoNumbersApp;

/// <summary>
/// The act of swapping two variables refers to mutually exchanging the values of the variables.
/// Generally, this is done with the data in memory.
/// Using a temporary variable!! - The simplest method to swap two variables is to use a third temporary variable
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        int temp;

        int x;
        int y;
        int temp2;
        
        Console.WriteLine("Please insert a number ");
        a = int.Parse(Console.ReadLine()!);
        b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Number a is {0} and number b is {1}" , a, b);
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("The numbers now are a : {0} and b : {1} ", a, b);
        
        Console.Write("-------------------");
        
        Console.WriteLine("Please insert a number ");
        x = int.Parse(Console.ReadLine()!);
        y = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Number a is {0} and number b is {1}" , x, y);
        Swap(ref x, ref y);
        Console.WriteLine("The numbers are a : {0} and b : {1} ", x, y);

        string str ;
        ChangeStr(out str);
        Console.WriteLine(str);
    }
    
    /**
     * By value and reference ,
     * here a , b are references , NOT literals
     * The ref keyword ensures that the arguments passed to the method,
     * are references to the actual variables, not copies.
     * This allows the method to modify the original values directly.
     * The method uses a temporary variable temp to swap a and b.
     */
    public static void Swap(ref int a, ref int b)
    {
        // int temp = a;
        // a = b;
        // b = temp;
        
        // with tuples
        (a,b) = (b,a);
    }

    /**
     * We can change with ref, but gives NullException,
     * out is best option
     */
    public static void ChangeStr(out string str)
    {
        str = "World!!";
    }
}