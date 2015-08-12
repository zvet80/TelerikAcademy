
namespace _02.BankAccounts
{
    using System;

    public abstract class Account : IDepositable
    {
        private Customer owner;
        private decimal interestRate;
        private decimal balance;

        public Account(Customer owner,
                       decimal interestRate,
                       decimal balance)
        {
            this.Owner = owner;
            this.InterestRate = interestRate;
            this.Balance = balance;
        }

        public Customer Owner { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Balance { get; set; }

        public abstract decimal CalcInterest(int months);

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount cannot be negative");
            }
            this.Balance += amount;
        }

        public override string ToString()
        {
            return string.Format("{0,5}, Owner:{1}, Balance:{2}",
                this.GetType().Name, this.Owner.Name, this.Balance);
        }
    }
}
