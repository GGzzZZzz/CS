public class MortgageAccount : Account
{
    public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
        : base(customer, balance, interestRate)
    {
    }

    public override decimal CalculateInterest(uint months)
    {
        const int IndividualFreeInterestPeriod = 6;
        const int CompanyHalfInterestPeriod = 12;

        decimal interest = 0;

        if (this.Customer is IndividualCustomer && months >= IndividualFreeInterestPeriod)
        {
            interest = base.CalculateInterest(months - IndividualFreeInterestPeriod);
        }

        if (this.Customer is CompanyCustomer && months <= CompanyHalfInterestPeriod)
        {
            interest = base.CalculateInterest(months) / 2;
        }
        else
        {
            interest = (base.CalculateInterest(CompanyHalfInterestPeriod) / 2) + base.CalculateInterest(months - CompanyHalfInterestPeriod);
        }

        return interest;
    }
}