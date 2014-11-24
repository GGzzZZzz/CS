using System;

public class Customer : Person, ICustomer
{
    private decimal totalAmount;

    public Customer(int id, string firstName, string lastName, decimal totalAmount)
        : base(id, firstName, lastName)
    {
        this.TotalAmount = totalAmount;
    }

    public decimal TotalAmount
    {
        get
        {
            return this.totalAmount;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    "Customer's total amount can not be negative!", "totalAmount");
            }

            this.totalAmount = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + string.Format(", Total Amount:{0:F2}", this.TotalAmount);
    }
}