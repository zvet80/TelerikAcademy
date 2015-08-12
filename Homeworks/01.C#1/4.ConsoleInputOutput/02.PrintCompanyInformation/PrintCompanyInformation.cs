//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter the following information");
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneN = Console.ReadLine();
        Console.Write("Fax number: ");
        string fax = Console.ReadLine();
        Console.Write("web site: ");
        string web = Console.ReadLine();
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Manager's phone number: ");
        string mPhoneNumber = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}",address);
        Console.WriteLine("Tel. {0}",phoneN);
        Console.WriteLine("Fax: {0}",fax);
        Console.WriteLine("Web site: {0}",web);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName,lastName,age,mPhoneNumber);
    }
}

