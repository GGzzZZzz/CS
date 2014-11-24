using System;

public class Payment
{
    private string productName;
    private decimal price;

    public Payment(string productName, decimal price)
    {
        this.ProductName = productName;
        this.Price = price;
    }

    public string ProductName
    {
        get
        {
            return this.productName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("productName", "Product Name can not be null or empty!");
            }

            this.productName = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price can not be negative!", "price");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Product Name:{0}, Price:{1}", this.ProductName, this.Price);
    }
}