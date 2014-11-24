using System.Collections.Generic;

public interface IDeveloper
{
    IList<IProject> Projects { get; set; }
}