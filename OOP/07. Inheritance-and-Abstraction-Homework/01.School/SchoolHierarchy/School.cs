using System;
using System.Collections.Generic;

public class School
{
    private IList<SchoolClass> classes;

    public School(IList<SchoolClass> classes)
    {
        this.Classes = classes;
    }

    public IList<SchoolClass> Classes
    {
        get
        {
            return this.classes;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("School classes can not be null!");
            }

            this.classes = value;
        }
    }
}