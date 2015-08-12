
namespace _02.BankAccounts
{
    using System;

    class LoanAccount : Account
    {
        public LoanAccount(Customer owner,
                       decimal interestRate,
                       decimal balance)
            : base(owner, interestRate, balance)
        {
        }

        public override decimal CalcInterest(int months)
        {
            if ((this.Owner is Individual && months <= 3) ||
                (this.Owner is Company && months <= 2))
            {
                return 0;
            }
            else if (this.Owner is Individual)
            {
                months -= 3;
            }
            else
            {
                months -= 2;
            }
            return (months * (this.InterestRate / 100) * this.Balance);
        }
    }
}
