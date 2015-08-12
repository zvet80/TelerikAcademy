//Problem 2. Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Please, enter your weight: ");
        double weightOnEarth = double.Parse(Console.ReadLine()); 
        double weightOnMoon = 0.17 * weightOnEarth;
        Console.WriteLine("Your weight on the Moon would be: {0}", weightOnMoon);
    }
}

