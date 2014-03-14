using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            /*A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
             * bank name, IBAN, 3 credit card numbers associated with the account.
             * Declare the variables needed to keep the information for a single bank account using the appropriate data
             * types and descriptive names.*/

            Console.WriteLine("Enter first name:");
            string firstName = (Console.ReadLine());
            Console.WriteLine("Enter middle name:");
            string middleName = (Console.ReadLine());
            Console.WriteLine("Enter last name:");
            string lastName = (Console.ReadLine());
            decimal balance = 1.75297249m;
            string bankName = "West Bank";
            string iban = "WBUS190734662837903";
            string bicCode = "WBCOUS23WAS";
            ulong creditCard1 = 3450969503025605;
            ulong creditCard2 = 9583474954834732;
            ulong crediCard3 = 7532949403456965;
            Console.WriteLine("===========================BANK ACCOUNT INFORMATION=============================");
            Console.WriteLine("Balance:" + "" + balance);
            Console.WriteLine("Bank Name:" + "" + bankName);
            Console.WriteLine("IBAN:" + "" + iban);
            Console.WriteLine("BIC Code:" + "" + bicCode);
            Console.WriteLine("1.Credit Card Number:" + "" + creditCard1);
            Console.WriteLine("2.Credit Card Number:" + "" + creditCard2);
            Console.WriteLine("3.Credit Card Number:" + "" + crediCard3);
        }
    }
}
