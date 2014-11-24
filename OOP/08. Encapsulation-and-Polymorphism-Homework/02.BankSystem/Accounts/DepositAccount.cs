using System;

public class DepositAccount : Account, IWithdrawable
{
    public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
    {
    }

    public override decimal CalculateInterest(uint months)
    {
        decimal interest = 0;

        if (this.Balance >= 1000)
        {
            interest = base.CalculateInterest(months);
        }

        return interest;
    }

    public void WithdrawMoney(decimal sum)
    {
        if (sum < 0 || sum > this.Balance)
        {
            throw new ArgumentOutOfRangeException(
                "sum", "Withdrawing sum should be positive and smaller than balance!");
        }

        this.Balance -= sum;
    }
}