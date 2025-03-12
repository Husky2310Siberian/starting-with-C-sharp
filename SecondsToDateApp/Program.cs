namespace SecondsToDateApp;

class Program
{
    static void Main(string[] args)
    {
        double days;
        double hours;
        double minutes;
        double seconds;
        const double SECONDS_PER_MINUTE = 60D;
        const double SECONDS_PER_HOUR = 60 * SECONDS_PER_MINUTE;
        const double SECONDS_PER_DAY = 24 * SECONDS_PER_HOUR;
        
        Console.WriteLine("Please insert the amount of days in seconds : ");
        if (!double.TryParse(Console.ReadLine(), out double inputSeconds))
        {
            Console.WriteLine("Error. Please insert the amount of days in seconds : ");
        }
        days = inputSeconds / SECONDS_PER_DAY;
        seconds = inputSeconds % SECONDS_PER_DAY;
        
        hours = Math.Floor (seconds / SECONDS_PER_HOUR);
        seconds %= SECONDS_PER_HOUR;
        
        minutes = Math.Floor(seconds % SECONDS_PER_MINUTE);
        seconds %= SECONDS_PER_MINUTE;
        
        Console.WriteLine($"{inputSeconds} = {days:N0} days, {hours:N0} hours, {minutes:N0} minutes , {seconds:N0} seconds");
        
    }
}