using System.Collections.Generic;

public interface ISalesEmployee
{
    IList<ISale> Sales { get; set; }
}