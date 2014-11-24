using System.Collections.Generic;

public class SalesEmployee : RegularEmployee, ISalesEmployee
{
    private IList<ISale> sales;

    public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, IList<ISale> sales)
        : base(id, firstName, lastName, salary, department)
    {
        this.Sales = sales;
    }

    public IList<ISale> Sales
    {
        get
        {
            return this.sales;
        }

        set
        {
            this.sales = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + string.Format(", Sales:{0}", string.Join("; ", this.Sales));
    }
}