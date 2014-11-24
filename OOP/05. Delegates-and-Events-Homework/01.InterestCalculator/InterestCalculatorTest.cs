using System;

internal static class InterestCalculatorTest
{
    public static void Main()
    {
        InterestCalculator compoundInterest = new InterestCalculator(500m,
            5.6m,
            10,
            InterestCalculator.GetCompoundInterest);
        Console.WriteLine("{0:f4}", compoundInterest.Result);

        InterestCalculator simpleInterest = new InterestCalculator (2500m,
            7.2m,
            15,
            InterestCalculator.GetSimpleInterest);
        Console.WriteLine("{0:f4}", simpleInterest.Result);
    }
}