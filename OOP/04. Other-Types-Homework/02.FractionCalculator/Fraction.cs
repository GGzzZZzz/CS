/*Create a struct Fraction that holds the numerator and denominator of a fraction as fields. A fraction is the division of two rational numbers (e.g. 22 / 7, where 22 is the numerator and 7 is the denominator).
•	The struct constructor takes the numerator and denominator as arguments. They are integer numbers in the range [-9223372036854775808…9223372036854775807]. 
•	Validate the input through properties. The denominator cannot be 0. Throw proper exceptions with descriptive messages.
•	Overload the + and - operators to perform addition and subtraction on objects of type Fraction. The result should be a new Fraction.
•	Override ToString() to print the fraction in floating-point format.*/

using System;

public struct Fraction
{
    private long numerator;
    private long denominator;

    public Fraction(long numerator, long denominator)
        : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public long Numerator
    {
        get { return this.numerator; }
        set { this.numerator = value; }
    }

    public long Denominator
    {
        get
        {
            return this.denominator;
        }

        set
        {
            if (value == 0)
            {
                throw new DivideByZeroException("Denominator can not be 0!");
            }

            this.denominator = value;
        }
    }

    public static Fraction operator +(Fraction fr, Fraction fr2)
    {
        checked
        {
            long nominator = (fr.Numerator * fr2.Denominator) + (fr2.Numerator * fr.Denominator);
            long denominator = fr.Denominator * fr2.Denominator;
            return new Fraction(nominator, denominator);
        }
    }

    public static Fraction operator -(Fraction fr, Fraction fr2)
    {
        checked
        {
            long nominator = (fr.Numerator * fr2.Denominator) - (fr2.Numerator * fr.Denominator);
            long denominator = fr.Denominator * fr2.Denominator;
            return new Fraction(nominator, denominator);
        }
    }

    public override string ToString()
    {
        return ((decimal)this.Numerator / this.Denominator).ToString();
    }
}