using System;
using System.Collections.Generic;

public class Customer : ICloneable, IComparable<Customer>
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string id;
    private string permanentAddress;
    private string mobilePhone;
    private string email;
    private List<Payment> payments;
    private CustomerType customerType;

    public Customer(
        string firstName,
        string middleName,
        string lastName,
        string id,
        string permanentAddress,
        string mobilePhone,
        string email,
        List<Payment> payments,
        CustomerType customerType)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.Id = id;
        this.PermanentAddress = permanentAddress;
        this.MobilePhone = mobilePhone;
        this.Email = email;
        this.Payments = payments;
        this.CustomerType = customerType;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            CheckString(value, "First Name");

            this.firstName = value;
        }
    }

    public string MiddleName
    {
        get
        {
            return this.middleName;
        }

        set
        {
            CheckString(value, "Middle Name");

            this.middleName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            CheckString(value, "Last Name");

            this.lastName = value;
        }
    }

    public string Id
    {
        get
        {
            return this.id;
        }

        set
        {
            CheckString(value, "ID");

            this.id = value;
        }
    }

    public string PermanentAddress
    {
        get
        {
            return this.permanentAddress;
        }

        set
        {
            CheckString(value, "Permanent Address");

            this.permanentAddress = value;
        }
    }

    public string MobilePhone
    {
        get
        {
            return this.mobilePhone;
        }

        set
        {
            CheckString(value, "Mobile Phone");

            this.mobilePhone = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }

        set
        {
            CheckString(value, "Email");

            this.email = value;
        }
    }

    public List<Payment> Payments
    {
        get
        {
            return this.payments;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("payments", "Payments can not be null!");
            }

            this.payments = value;
        }
    }

    public CustomerType CustomerType
    {
        get { return this.customerType; }

        set { this.customerType = value; }
    }

    public static void CheckString(string value, string parameter)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException(parameter, parameter + " can not be null!");
        }
    }

    public override bool Equals(object obj)
    {
        Customer customer = obj as Customer;

        if (customer == null)
        {
            return false;
        }

        if (!Equals(this.FirstName, customer.FirstName))
        {
            return false;
        }

        if (!Equals(this.MiddleName, customer.MiddleName))
        {
            return false;
        }

        if (!Equals(this.LastName, customer.LastName))
        {
            return false;
        }

        if (!Equals(this.Id, customer.Id))
        {
            return false;
        }

        if (!Equals(this.PermanentAddress, customer.PermanentAddress))
        {
            return false;
        }

        if (!Equals(this.MobilePhone, customer.MobilePhone))
        {
            return false;
        }

        if (!Equals(this.email, customer.Email))
        {
            return false;
        }

        if (this.Payments.Count != customer.Payments.Count)
        {
            return false;
        }

        for (int i = 0; i < this.Payments.Count; i++)
        {
            if (!Equals(this.Payments[i], customer.Payments[i]))
            {
                return false;
            }
        }

        if (!Equals(this.CustomerType, customer.CustomerType))
        {
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        return string.Format(
            "First Name:{0}\nMiddle Name:{1}\nLast Name:{2}\nID:{3}\nPermanent Address:{4}\nMobile Phone:{5}\nEmail:{6}\nPayments:\n{7}\nCustomer Type:{8}",
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Id,
            this.PermanentAddress,
            this.MobilePhone,
            this.Email,
            string.Join("\n",this.Payments),
            this.CustomerType);
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.Id.GetHashCode() ^
                this.PermanentAddress.GetHashCode() ^
                this.MobilePhone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Payments.GetHashCode() ^
                this.CustomerType.GetHashCode();
    }

    public static bool operator ==(Customer customerOne, Customer customerTwo)
    {
        bool equal = Customer.Equals(customerOne, customerTwo);

        return equal;
    }

    public static bool operator !=(Customer customerOne, Customer customerTwo)
    {
        bool notEqual = !(Customer.Equals(customerOne, customerTwo));

        return notEqual;
    }

    public object Clone()
    {
        return new Customer(
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Id,
            this.PermanentAddress,
            this.MobilePhone,
            this.Email,
            this.Payments,
            this.CustomerType
            );
    }

    public int CompareTo(Customer otherCustomer)
    {
        if (this.FirstName != otherCustomer.FirstName)
        {
            return this.FirstName.CompareTo(otherCustomer.FirstName);
        }

        if (this.MiddleName != otherCustomer.MiddleName)
        {
            return this.MiddleName.CompareTo(otherCustomer.MiddleName);
        }

        if (this.LastName != otherCustomer.LastName)
        {
            return this.LastName.CompareTo(otherCustomer.LastName);
        }

        if (int.Parse(this.Id) != int.Parse(otherCustomer.Id))
        {
            return int.Parse(this.Id).CompareTo(int.Parse(otherCustomer.Id));
        }

        return 0;
    }
}