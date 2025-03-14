namespace RightTriangleApp;

class Program
{
    static void Main(string[] args)
    {
        double a = 0.0;
        double b = 0.0;
        double c = 0.0;
        const double EPSILON = 0.000005;
        bool isRightTriangle = false;

        if (double.TryParse(Console.ReadLine(), out a)
            && double.TryParse(Console.ReadLine(), out b)
            && double.TryParse(Console.ReadLine(), out c)) ;
        
        isRightTriangle = Math.Abs(a * a - b * b - c * c) <= EPSILON;
        Console.WriteLine("Triangle is {0} right" , (isRightTriangle) ? " " : "not");
    }
}