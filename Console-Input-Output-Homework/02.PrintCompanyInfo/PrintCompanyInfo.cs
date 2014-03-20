using System;

class PrintCompanyInfo
{
    static void Main()
    {
        //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.

        Console.Write("Company's name: ");
        string compName = Console.ReadLine();
        Console.Write("Company's address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        long compNum = long.Parse(Console.ReadLine());
        Console.Write("Fax number: ");
        long faxNum = long.Parse(Console.ReadLine());
        Console.Write("Web site: ");
        string site = Console.ReadLine();
        Console.Write("Manager's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager's age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Manager's phone number: ");
        long manPnone = long.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The company name is {0} and it is located in {1}.", compName, address);
        Console.WriteLine("You can contact the company by this phone number: {0} \r\nor send a message on its fax number: {1}."
            , compNum, faxNum);
        Console.WriteLine("You also can visit company's web site {0}.", site);
        Console.WriteLine("The manager of the company is Mr {0} {1}.", firstName, lastName);
        Console.WriteLine("He is {0} years old and if you want contact him call this number {1}.", age, manPnone);
    }
}