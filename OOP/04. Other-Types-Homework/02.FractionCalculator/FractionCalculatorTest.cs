using System;

internal class FractionCalculatorTest
{
    public static void Main()
    {
        checked
        {
            Fraction fractionOne = new Fraction(22, 7);
            Fraction fractionTwo = new Fraction(40, 4);

            Fraction sum = fractionOne + fractionTwo;

            Console.WriteLine(sum.Numerator);
            Console.WriteLine("————");
            Console.WriteLine(sum.Denominator);
            Console.WriteLine(sum);

            Fraction substraction = fractionOne - fractionTwo;

            Console.WriteLine();

            Console.WriteLine(substraction.Numerator);
            Console.WriteLine("————");
            Console.WriteLine(substraction.Denominator);
            Console.WriteLine(substraction);
        }
    }
}