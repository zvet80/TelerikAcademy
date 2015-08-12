//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


using System;

class Age
{
    static void Main()
    {
        Console.WriteLine("Please, write your birthday (dd.mm.yyyy):");

        DateTime userBirthday=DateTime.Parse(Console.ReadLine());
        int userAge = DateTime.Today.Year - userBirthday.Year;
        
        if (DateTime.Today.Month < userBirthday.Month ||
           (DateTime.Today.Month == userBirthday.Month && DateTime.Today.Day < userBirthday.Day))
            
            userAge = userAge - 1;
        
        Console.WriteLine("Your Age: " + userAge);
        Console.WriteLine("Your Age after 10 Years: " + (userAge + 10));
    }
}

