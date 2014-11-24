public interface IAccount
{
    Customer Customer { get; set; }

    decimal Balance { get; set; }

    decimal InterestRate { get; set; }

    decimal CalculateInterest(uint months);
}