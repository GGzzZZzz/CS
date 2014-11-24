using System;
using System.Collections.Generic;

public class Teacher : Person
{
    private IList<Discipline> disciplines;

    public Teacher(string name, IList<Discipline> disciplines, string details = null)
        : base(name, details)
    {
        this.Disciplines = disciplines;
    }

    public IList<Discipline> Disciplines
    {
        get
        {
            return this.disciplines;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Disciplines can not be null!");
            }

            this.disciplines = value;
        }
    }
}