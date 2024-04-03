using System;

class TimeConvert
{
    static void Main(string[] args)
    {
        Console.WriteLine("What conversion would you like to perform?");
        Console.WriteLine("0. Convert seconds to minutes");
        Console.WriteLine("1. Convert minutes to hours");
        Console.WriteLine("2. Convert hours to days");
        Console.WriteLine("3. Convert days to months");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 0:
                Console.WriteLine("Enter seconds:");
                double seconds = Convert.ToDouble(Console.ReadLine());
                result = SecondsToMinutes(seconds);
                Console.WriteLine($"{seconds} seconds = {result} minutes");
                break;
            case 1:
                Console.WriteLine("Enter minutes:");
                double minutes = Convert.ToDouble(Console.ReadLine());
                result = MinutesToHours(minutes);
                Console.WriteLine($"{minutes} minutes = {result} hours");
                break;
            case 2:
                Console.WriteLine("Enter hours:");
                double hours = Convert.ToDouble(Console.ReadLine());
                result = HoursToDays(hours);
                Console.WriteLine($"{hours} hours = {result} days");
                break;
            case 3:
                Console.WriteLine("Enter days:");
                double days = Convert.ToDouble(Console.ReadLine());
                result = DaysToMonths(days);
                Console.WriteLine($"{days} days = {result} months");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static double SecondsToMinutes(double seconds)
    {
        return seconds / 60;
    }

    static double MinutesToHours(double minutes)
    {
        return minutes / 60;
    }

    static double HoursToDays(double hours)
    {
        return hours / 24;
    }

    static double DaysToMonths(double days)
    {
        return days / 30;
    }
}
