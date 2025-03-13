namespace TemperatureConverterApp;
/// <summary>
/// Converts the temperature from F --> C and vice versa
/// </summary>
class Program
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius - 32) * 5 / 9;
    }
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Please press C to convert the celsius to fahrenheit , or F to convert the fahrenheit to Celsius");
        String choice = Console.ReadLine().Trim().ToUpper();

        if (choice != "C" && choice != "F")
        {
            Console.WriteLine("Please enter C or F");
            return;
        }
        Console.WriteLine("Please insert the desired temperature");
        if (!Double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.WriteLine("Please enter a valid temperature");
            return;
        }
        if (choice == "C")
        {
            double convertedtemperature = CelsiusToFahrenheit(temperature);
            Console.WriteLine("The conversion from Celsius : {0:F2} to fahrenheit is :{1:F2} " , temperature , convertedtemperature);
        }
        if (choice == "F")
        {
            double convertedtemperature = FahrenheitToCelsius(temperature);
            Console.WriteLine("The conversion from Fahrenheit : {0:F2} to Celsius is :{1:F2} " , temperature , convertedtemperature);
        }
    }
}