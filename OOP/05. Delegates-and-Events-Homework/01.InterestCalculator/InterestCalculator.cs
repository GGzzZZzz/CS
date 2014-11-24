using System;

public delegate decimal CalculateInterest(decimal sum, decimal interest, int period);

internal class InterestCalculator
{
    private decimal sum;
    private decimal interest;
    private int period;
    private decimal result;
    private CalculateInterest kindOfInterest;

    public InterestCalculator(decimal sum, decimal interest, int period, CalculateInterest kindOfInterest)
    {
        this.Sum = sum;
        this.Interest = interest;
        this.Period = period;
        this.kindOfInterest = kindOfInterest;
        this.Result = kindOfInterest(sum, interest, period);
    }

    public decimal Sum
    {
        get
        {
            return this.sum;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("value", "Sum can not be negative or 0!");
            }

            this.sum = value;
        }
    }

    public decimal Interest
    {
        get
        {
            return this.interest;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("value", "Interest can not be negative or 0!");
            }

            this.interest = value;
        }
    }

    public int Period
    {
        get
        {
            return this.period;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("value", "Period can not be negative or 0!");
            }

            this.period = value;
        }
    }

    public decimal Result
    {
        get { return this.result; }
        private set { this.result = value; }
    }

    public static decimal GetSimpleInterest(decimal sum, decimal interest, int period)
    {
        decimal simpleInterest = sum * (1 + (interest / 100) * period);

        return simpleInterest;
    }

    public static decimal GetCompoundInterest(decimal sum, decimal interest, int period)
    {
        decimal compoundInterest = sum * (decimal)Math.Pow(
            1 + ((double)(interest / 100) / 12), period * 12);
           
        return compoundInterest;
    }
}