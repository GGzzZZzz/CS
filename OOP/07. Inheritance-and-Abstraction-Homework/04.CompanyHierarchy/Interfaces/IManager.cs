using System.Collections.Generic;

public interface IManager
{
    IList<IEmployee> SubordinateEmployees { get; set; }
}