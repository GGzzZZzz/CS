public class LoanAccount : Account
{
    public LoanAccount(Customer customer, decimal balance, decimal interestRate)
        : base(customer, balance, interestRate)
    {
    }

    public override decimal CalculateInterest(uint months)
    {
        const int IndividualFreeInterestPeriod = 3;
        const int CompanyFreeInterestPeriod = 2;

        decimal interest = 0;

        if (this.Customer is IndividualCustomer && months >= IndividualFreeInterestPeriod)
        {
            interest = base.CalculateInterest(months - IndividualFreeInterestPeriod);
        }

        if (this.Customer is CompanyCustomer && months >= CompanyFreeInterestPeriod)
        {
            interest = base.CalculateInterest(months - CompanyFreeInterestPeriod);
        }

        return interest;
    }
}