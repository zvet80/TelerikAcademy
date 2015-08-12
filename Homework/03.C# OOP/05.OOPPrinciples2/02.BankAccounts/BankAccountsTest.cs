﻿//Problem 2. Bank accounts
//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

namespace _02.BankAccounts
{
    using System;

    class BankAccounts
    {
        static void Main()
        {
            Account[] accounts = 
            {
                new DepositAccount(new Individual("Ivan"),5.2m,1030.6m),
                new LoanAccount(new Company("ABC"),2.3m,50000000.6m),
                new MortgageAccount(new Individual("Pesho"),6,8000)                
            };

            foreach (var a in accounts)
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine("The interest for 5 months paid in the {0} is {1:F2} ",
                    a.GetType().Name, a.CalcInterest(5));
            }
            Console.WriteLine();
            DepositAccount acc = new DepositAccount(new Individual("Ivan"), 5, 500);
            acc.Withdraw(100);
            Console.WriteLine("The balance of {0}'s account after withdrawal of 100 lv is:{1}", acc.Owner.Name, acc.Balance);
        }
    }

}