namespace CalculatorApp2;
/// <summary>
/// Calculator 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;
        char operation = ' ';
        bool goOn = true;
        double result = 0;

        while (true)
        {
            Console.WriteLine("Please enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please enter the operation symbol: + , - , * , / , % ");
            operation = char.Parse(Console.ReadLine());
            
            goOn = (operation == '+') || (operation == '-') 
                                      || (operation == '*') 
                                      || (operation == '/')
                                      || (operation == '%');
            if (!goOn)
            {
                Console.WriteLine("Exit!!");
                Environment.Exit(1);
            }
            
            Console.WriteLine("Please enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0 && (operation == '/' || operation == '%'))
            {
                Console.WriteLine("Error. Divider by zero , is not permitted.");
                Environment.Exit(0);
            }

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Result: " + result);
        }
    }
}