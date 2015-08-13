//Problem 10.* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter a time in format 'hh:mm tt'");
        DateTime time;
        DateTime begin = DateTime.Parse("01:00 pm");
        DateTime end = DateTime.Parse("03:00 pm");
        
        if (DateTime.TryParse(Console.ReadLine(),out time))
        {
            if ((time > begin) && (time < end))
            {
                Console.WriteLine("beer time");
            }                
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

