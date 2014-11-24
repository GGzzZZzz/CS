using System;

public abstract class Account : IAccount, IDepositable
{
    private Customer customer;
    private decimal balance;
    private decimal interestRate;

    public Account(Customer customer, decimal balance, decimal interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    public Customer Customer
    {
        get
        {
            return this.customer;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("customer", "Customer can not be null!");
            }

            this.customer = value;
        }
    }

    public decimal Balance
    {
        get
        {
            return this.balance;
        }

        set
        {
            this.balance = value;
        }
    }

    public decimal InterestRate
    {
        get
        {
            return this.interestRate;
        }

        set
        {
            this.interestRate = value;
        }
    }

    public virtual decimal CalculateInterest(uint months)
    {
        decimal interest = (this.Balance * (1 + this.InterestRate * months)) / 100;

        return interest;
    }

    public void DepositMoney(decimal sum)
    {
        if (sum <= 0)
        {
            throw new ArgumentOutOfRangeException("sum", "Depositing sum should be greater then 0!");
        }

        this.Balance += sum;
    }
}