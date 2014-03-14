using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            /*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
             * Use descriptive names. Print the data at the console.*/

            Console.WriteLine("Enter your first name");
            string firstName = (Console.ReadLine());
            Console.WriteLine("Enter your last name");
            string lastName = (Console.ReadLine());
            Console.WriteLine("Enter your age");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your ID number");
            uint idNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter your employee number 27560000 to 27569999");
            uint employeenum = uint.Parse(Console.ReadLine());
            if (employeenum < 27560000)
            {
                Console.WriteLine("Invalid number!");

            }
            else if (employeenum > 27569999)
            {
                Console.WriteLine("Invalid number!");
            }

            else
            {
                Console.WriteLine("================================================================================");
                Console.WriteLine("Information about employee:");
                Console.WriteLine("First name:" + "" + firstName);
                Console.WriteLine("Last name:" + "" + lastName);
                Console.WriteLine("Age:" + "" + age);
                Console.WriteLine("Gender:" + "" + gender);
                Console.WriteLine("ID number:" + "" + idNumber);
                Console.WriteLine("Employee number:" + "" + employeenum);
            }
        }
    }
}
