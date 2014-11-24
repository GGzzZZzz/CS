using System;
using System.Collections.Generic;

public class Manager : Employee, IManager
{
    private IList<IEmployee> subordinateEmployees;

    public Manager(int id, string firstName, string lastName, decimal salary, Department department, IList<IEmployee> subordinateEmployees)
        : base(id, firstName, lastName, salary, department)
    {
        this.SubordinateEmployees = subordinateEmployees;
    }

    public IList<IEmployee> SubordinateEmployees
    {
        get
        {
            return this.subordinateEmployees;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("employees", "Employees can not be null!");
            }

            this.subordinateEmployees = value;
        }
    }

    public override string ToString()
    {
        string result = string.Empty;
        foreach (var item in this.SubordinateEmployees)
        {
            result += " " + item.Id + ", " + item.FirstName + " " + item.LastName + "; ";
        }

        return base.ToString() + string.Format(", Subordinate Employees:" + result);
    }
}