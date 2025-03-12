namespace FiboIterativeApp;

class Program
{
    static void Main(string[] args)
    {
        int num = 50;
        for (int i = 0; i <= num; i++)
        {
            Console.WriteLine("Fibonaci " +Fibo(i) + " equals to " + $"{i,3}" );
        }
        
    }

    /// <summary>
    /// The recursive technique to the mathematical
    /// definition of Fibonacci numbers
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int Fibo(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        return Fibo(n - 1) + Fibo(n - 2);
    }
}