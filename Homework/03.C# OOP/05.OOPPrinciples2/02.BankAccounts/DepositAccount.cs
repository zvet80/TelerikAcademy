
namespace _02.BankAccounts
{
    using System;

    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer owner,
                       decimal interestRate,
                       decimal balance)
            : base(owner, interestRate, balance)
        {
        }

        public override decimal CalcInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return (months * (this.InterestRate / 100) * this.Balance);
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Withdrawn amount cannot exceed account balance");
            }
            this.Balance -= amount;
        }
    }
}
