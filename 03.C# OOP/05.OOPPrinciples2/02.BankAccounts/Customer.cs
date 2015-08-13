﻿
namespace _02.BankAccounts
{
    using System;

    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }
    }
}
