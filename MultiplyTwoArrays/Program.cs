namespace MultiplyTwoArrays;
/// <summary>
/// Multiply corresponding elements of two arrays of integers
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {2, 4, 6, 8, 10};
        int[] array2 = {1, 3, 5, 7, 9};
        
        Console.WriteLine("\nArray 1 : [{0}]" , string.Join( ", " , array1));
        Console.WriteLine("\nArray 2 : [{0}]" , string.Join( ", " , array2));
        
        Console.WriteLine("\nNew Array will be the multiply of two arrays.\n");

        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write(array1[i] * array2[i] + " , ");
        }
    }
}