//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        string middleName = "Ivanov";
        decimal balance = 10000000M;
        string bankName = "ABC";
        string IBAN = "BG07FINV915010BGN0CH47";
        ulong cardNumber1 = 1100110011001100U;
        ulong cardNumber2 = 1100110011001101U;
        ulong cardNumber3 = 1100110011001102U;
        Console.WriteLine("Name:" + firstName + " " + middleName + " " + lastName);
        Console.WriteLine("Balance: {0}",balance);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.WriteLine("Credit Card Number: {0}", cardNumber1);
        Console.WriteLine("Credit Card Number: {0}", cardNumber2);
        Console.WriteLine("Credit Card Number: {0}", cardNumber3);
    }
}

