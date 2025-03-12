namespace EurosToDollarsApp;
/// <summary>
/// Reads from standard input an integer , that represents an amount
/// in euro and converts to dollars and cents. Assume that 1 Euro == 0,97 USD
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        const decimal RATE = 0.97m;
        const int CENTS_PER_DOLLAR = 100;
        decimal dollars = 0;
        decimal cents = 0;
        
        Console.WriteLine("Please insert an amount in euros");
        if (!decimal.TryParse(Console.ReadLine(), out decimal inputEuros))
        {
            Console.WriteLine("Error. Please enter a valid number");
        }
        dollars = inputEuros * RATE;
        cents = dollars * CENTS_PER_DOLLAR % 100;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Your input amount is {0:N2} euros --> \u0024dollars are {1:N2}, cents are \u0024{2:N2}" , inputEuros, dollars, cents);
    }
}