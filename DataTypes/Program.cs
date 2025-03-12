namespace DataTypes;

class Program
{
    static void Main(string[] args)
    {
        int num = 5;
        
        Console.WriteLine($"int: {sizeof(int) * 8} , Min: {int.MinValue} , Max: {int.MaxValue}");
        Console.WriteLine($"double : {sizeof(double) * 8} , Min: {double.MinValue} , Max: {double.MaxValue}");
        Console.WriteLine($"decimal : {sizeof(decimal) * 8} , Min: {decimal.MinValue} , Max: {decimal.MaxValue}");
        Console.WriteLine($"sbyte : {sizeof(sbyte) * 8} , Min: {sbyte.MinValue} , Max: {sbyte.MaxValue}");
        Console.WriteLine($"byte : {sizeof(byte) * 8} , Min: {byte.MinValue} , Max: {byte.MaxValue}");
        
        // When 5.ToString() is executed, it converts the integer 5 into the string "5".
        Console.WriteLine(5.ToString());
        
    }
}