using System;
using System.Collections.Generic;

public class BankSystemTest
{
    public static void Main()
    {
        Customer kircho = new IndividualCustomer("Kircho Kirev");
        Customer bulPc = new CompanyCustomer("BulPC");

        List<Account> accounts = new List<Account>
        {
           new DepositAccount(kircho, 22500m, 7.2m),
           new LoanAccount(bulPc, 50000m, 12.3m),
           new MortgageAccount(kircho, 100250m, 9.1m)
        };

        foreach (Account account in accounts)
        {
            Console.WriteLine(account.GetType() + " Interest:{0:F2}", account.CalculateInterest(15));
        }
    }
}