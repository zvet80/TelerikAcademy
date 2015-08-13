namespace _02.BankAccounts
{
    using System;

    class MortgageAccount : Account
    {
        public MortgageAccount(Customer owner,
                               decimal interestRate,
                               decimal balance)
            : base(owner, interestRate, balance)
        {
        }

        public override decimal CalcInterest(int months)
        {
            if (this.Owner is Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                return ((months - 6) * (this.InterestRate / 100) * this.Balance);

            }
            else
            {
                if (months <= 12)
                {
                    return (months * ((this.InterestRate / 2) / 100) * this.Balance);
                }
                return ((12 * ((this.InterestRate / 2) / 100)) + ((months - 12) * (this.InterestRate / 100)) * this.Balance);
            }
        }
    }
}
