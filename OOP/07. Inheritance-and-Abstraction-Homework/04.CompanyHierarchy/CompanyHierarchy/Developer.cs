using System.Collections.Generic;

public class Developer : RegularEmployee, IDeveloper
{
    private IList<IProject> projects;

    public Developer(int id, string firstName, string lastName, decimal salary, Department department, IList<IProject> projects)
        : base(id, firstName, lastName, salary, department)
    {
        this.Projects = projects;
    }

    public IList<IProject> Projects
    {
        get { return this.projects; }
        set { this.projects = value; }
    }

    public override string ToString()
    {
        return base.ToString() + string.Format(", Projects:{0}", string.Join("; ", this.Projects));
    }
}